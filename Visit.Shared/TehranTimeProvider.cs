using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Visit.Shared
{
    public class TehranTimeProvider
    {
        public static async Task<DateTime> GetDateTimeAsync()
        {
            const string ntpServer = "pool.ntp.org";
            byte[] buffer = new byte[48];
            buffer[0] = 0x1B; // کد درخواست NTP

            var addresses = await Dns.GetHostAddressesAsync(ntpServer);
            var ip = addresses.First(a => a.AddressFamily == AddressFamily.InterNetwork);
            var endPoint = new IPEndPoint(ip, 123);

            // توابع کمکی برای خواندن داده های NTP
            uint Read32(byte[] buf, int index) => BitConverter.ToUInt32(buf, index);
            uint SwapEndian(uint x) =>
                (x & 0x000000FFU) << 24 |
                (x & 0x0000FF00U) << 8 |
                (x & 0x00FF0000U) >> 8 |
                (x & 0xFF000000U) >> 24;

            using (var udp = new UdpClient())
            {
                await udp.SendAsync(buffer, buffer.Length, endPoint);
                var response = await udp.ReceiveAsync();

                uint seconds = SwapEndian(Read32(response.Buffer, 40));
                uint fraction = SwapEndian(Read32(response.Buffer, 44));

                // محاسبه میلی ثانیه از ثانیه و کسر ثانیه
                long milliseconds = (long)(seconds * 1000L + (fraction * 1000.0 / uint.MaxValue));

                // ساخت تاریخ UTC با تعیین دقیق Kind به Utc
                DateTime utc = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(milliseconds);

                // تبدیل به زمان تهران (با پشتیبانی از DST)
                var tehranZone = TimeZoneInfo.FindSystemTimeZoneById("Iran Standard Time");
                return TimeZoneInfo.ConvertTimeFromUtc(utc, tehranZone);
            }
        }
        public static async Task<TimeSpan> GetTimeSpanAsync()
        {
            var dt = await GetDateTimeAsync();
            return dt.TimeOfDay;
        }
    }
}
