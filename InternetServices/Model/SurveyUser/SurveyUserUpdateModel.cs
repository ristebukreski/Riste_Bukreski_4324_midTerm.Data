using System;

namespace InternetServices.Model.SurveyUser
{
    class SurveyUserUpdateModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DoB { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
    }
}
