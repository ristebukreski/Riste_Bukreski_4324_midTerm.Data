using System;
using System.Collections.Generic;
using System.Text;

namespace InternetServices.Model.SurveyUser
{
    class SurveyUserCreateModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DoB { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
    }
}
