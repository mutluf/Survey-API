﻿using MaSurvey.Domain.Entities.Common;

namespace MaSurvey.Domain.Entities
{
    public class AnsweredQuestion:BaseEntity
    {
        public Response? Response { get; set; }
        public int ResponseId { get; set; }
        public ICollection<AnsweredOption>? Options { get; set; }


        public Question? Question { get; set; }
        public int QuestionId { get; set; }
    }
}
