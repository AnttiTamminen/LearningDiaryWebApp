﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LearningDiaryApp.Models
{
    public partial class Topic
    {
        public Topic()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? TimeToMaster { get; set; }
        public decimal? TimeSpent { get; set; }
        public string Source { get; set; }
        public DateTime? StartLearningDate { get; set; }
        public bool? InProgress { get; set; }
        public DateTime? CompletionDate { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
