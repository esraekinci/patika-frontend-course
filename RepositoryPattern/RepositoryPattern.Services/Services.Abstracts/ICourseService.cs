using Repository.Domain.Entities;
using System.Collections.Generic;

namespace RepositoryPattern.Services.Services.Abstracts
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAll();
        public void Add(Course course);
        IEnumerable<Course> GetById(int id);
        
        //IEnumerable<Course> Update();
        public void Update(Course course);
        IEnumerable<Course> UpdateGetAll();
    }
}
