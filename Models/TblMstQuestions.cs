using System;
using System.Collections.Generic;

namespace QuizApi.Models
{
    public partial class TblMstQuestions
    {
        public int QuestionId { get; set; }
        public int QuizCategoryId { get; set; }
        public string Questions { get; set; }
        public string IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
