using Visit.Shared.Attributes;

namespace Visit.Shared
{
    public class UserInfo : BaseValidation
    {
        [FirstNameValidation]
        public string FirstName { get; set; }
        [LastNameValidation]
        public string LastName { get; set; }
        [MobileValidation]
        public string MobileNumber { get; set; }
        public string Picture { get; set; }
    }
}
