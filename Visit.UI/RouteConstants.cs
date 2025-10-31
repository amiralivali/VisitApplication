namespace Visit.UI
{
    internal class RouteConstants
    {
        public const string BaseUrl = "https://localhost:7054";
        public const string InsertBimar = "Bimar/Insert";
        public const string InsertDoctor = "Doctor/Insert";
        public const string UpdateBimar = "Bimar/Update";
        public const string UpdateDoctor = "Doctor/Update";
        public const string ExistBimar = "Bimar/ExistBimar?nc={0}&mobile={1}";
        public const string ExistDoctor = "Doctor/ExistDoctor?nezam={0}&mobile={1}";
        public const string SendSms = "Sms/Send";
        public const string SavePhoto = "Photo/Save";
        public const string GetBimar = "Bimar/GetBimar?nc={0}&mobile={1}";
        public const string GetDoctor = "Doctor/GetDoctor?nezam={0}&mobile={1}";
    }
}
