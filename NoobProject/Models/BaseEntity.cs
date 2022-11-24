﻿using System;

namespace NoobProject.Models
{
    public class BaseEntity
    {
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
