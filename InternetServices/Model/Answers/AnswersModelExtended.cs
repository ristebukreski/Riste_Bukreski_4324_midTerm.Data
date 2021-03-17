namespace InternetServices.Model.Answers
{
    class AnswersModelExtended
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OptionId { get; set; }
        public virtual Option Option { get; set; }        
        public virtual SurveyUser User { get; set; }
    }
}
