using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visit.Shared;

namespace Visit.DAL
{
    public static class ErrorExeptionRepository
    {
        public static async Task AddLogAsync(this Exception ex)
        {
            var realDateTime = await TehranTimeProvider.GetDateTimeAsync();

            try
            {
                using (var db = new VisitDbContext())
                {
                    var exception = new ExceptionLog()
                    {
                        Message = ex.Message,
                        CreatedAt = realDateTime,
                        StackTrace = ex.StackTrace,
                        ExceptionType = ex.GetType().Name,
                        Source = ex.Source,
                    };

                    await db.ExceptionLogs.AddAsync(exception);
                    await db.SaveChangesAsync();
                }
            }
            catch
            {
                var logText =
                    $"[{realDateTime}] | {ex.GetType().Name} | {ex.Message}\n{ex.StackTrace}\n";

                if (File.Exists("ErrorException.txt"))
                {
                    File.AppendAllText("ErrorException.txt", logText + Environment.NewLine);
                }
                else
                {
                    File.WriteAllText("ErrorException.txt", logText + Environment.NewLine);
                }
            }
        }
    }
}
