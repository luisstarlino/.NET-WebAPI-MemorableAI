﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemorableAI.Application.Models
{
    public class TaskRequestModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? CreateBy { get; set; }
    }

    public class TaskPromptRequestModel
    {
        public string Prompt { get; set; } = String.Empty;
    }
    public class TaskSearchRequestModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
