using System;

namespace Repository.Domain
{
    public abstract class BaseEntity
    {
        public int CourseId { get; set; } 
        public bool IsDeleted { get; set; } 
        public DateTime CreatedDate { get; set; }   
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; } //It can be null.

    }
}
