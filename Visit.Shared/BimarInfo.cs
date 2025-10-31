namespace Visit.Shared
{
    public class BimarInfo : UserInfo
    {
        public int BimarID { get; set; }
        [NationalCodeValidation]
        public string NationalCode { get; set; }
    }
}
