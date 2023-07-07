﻿namespace MaSurvey.Application.DTOs
{
    public class OptionResponse
    {
        public int Id { get; set; }
        public string OptionContent { get; set; }
        public int VoteAmount { get; set; }
        public ICollection<AnsweredOptionDTO> AnsweredOptions { get; set; }
    }
}
