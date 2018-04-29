using System;
using Dolittle.Events;

namespace Events.StaffUser.Registration
{
    public class DataOwnerRegistered : IEvent 
    {
        public DataOwnerRegistered (Guid staffUserId, string fullName, string displayName, 
            string email, DateTimeOffset registeredAt, Guid nationalSociety, int language, 
            int sex, int birthYear, string position, string dutyStation) 
        {
            DutyStation = dutyStation;
            Position = position;
            StaffUserId = staffUserId;
            FullName = fullName;
            DisplayName = displayName;
            Email = email;
            RegisteredAt = registeredAt;
            NationalSociety = nationalSociety;
            PreferredLanguage = language;
            Sex = sex;
            BirthYear = birthYear;

        }

        public Guid StaffUserId { get; set; }

        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public DateTimeOffset RegisteredAt { get; set; }
        
        public string Position { get; set; }
        public string DutyStation { get; set; }
        public Guid NationalSociety { get; set; }
        public int PreferredLanguage { get; set; }
        public int BirthYear { get; set; }
        public int Sex { get; set; }
    }

}