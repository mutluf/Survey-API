﻿namespace MaSurvey.Application.DTOs
{
    public class AnsweredOptionDTO
    {
        public int Id { get; set; }
        public string? OptionContent { get; set; }
  
        public int OptionId { get; set; }
        public int QuestionId { get; set; }
    }
}
