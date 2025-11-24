using Visit.Shared;

namespace Visit.DAL
{
    public static class Mapper
    {
        public static User MapToUser(this BimarInfo info)
        {
            User user = new User()
            {
                FirstName = info.FirstName,
                LastName = info.LastName,
                MobileNumber = info.MobileNumber,
                Picture = info.Picture,
            };
            return user;
        }
        public static User MapToUser(this DoctorInfo info)
        {
            User user = new User()
            {
                FirstName = info.FirstName,
                LastName = info.LastName,
                MobileNumber = info.MobileNumber,
                Picture = info.Picture,
            };
            return user;
        }
        public static Bimar MapToBimar(this BimarInfo info)
        {
            Bimar bimar = new Bimar()
            {
                NationalCode = info.NationalCode
            };
            return bimar;
        }
        public static Doctor MapToDoctor(this DoctorInfo info)
        {
            Doctor doctor = new Doctor()
            {
                DoctorID = info.DoctorID,
                CodeNezamPezeshki = info.CodeNezamPezeshki,
                StartWorkingTime=info.StartTime,
                EndWorkingTime=info.EndTime,
                IsOnline=info.IsOnline,
            };
            return doctor;
        }
        public static Visit MapToVisit(this VisitInfo info)
        {
            Visit visit = new Visit()
            {
                BimarID = info.BimarID,
                DoctorID = info.DoctorID,
                DateTime = info.DateTime,
            };
            return visit;
        }
        public static Doctor_Takhasos MapToDoctorTakhasos(this Doctor_TakhasosInfo takhasos)
        {
            Doctor_Takhasos doctor_Takhasos = new Doctor_Takhasos()
            {
                DoctorID = takhasos.DoctorID,
                TakhasosID = takhasos.TakhasosID,
            };
            return doctor_Takhasos;
        }
    }
}
