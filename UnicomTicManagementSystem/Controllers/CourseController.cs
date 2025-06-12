using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTicManagementSystem.Controllers
{
        public class CourseController
        {
            private readonly DatabaseManager db;

            public CourseController()
            {
                db = new DatabaseManager();
            }

            public List<Courses> GetCourses()
            {
                return db.GetAllCourses();
            }

            public void Add(Courses course)
            {
                db.AddCourse(course);
            }

            public void Update(Courses course)
            {
                db.UpdateCourse(course);
            }

            public void Delete(int courseId)
            {
                db.DeleteCourse(courseId);
            }
        }
    
}

