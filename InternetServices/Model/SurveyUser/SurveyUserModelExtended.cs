using System;

namespace InternetServices.Model.SurveyUser
{
    public class SurveyUserModelExtended
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DoB { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
    }
}
