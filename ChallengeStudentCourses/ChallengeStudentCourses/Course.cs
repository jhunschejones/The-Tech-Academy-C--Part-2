using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public string printCourses()
        {
            string result = "";
            result = this.CourseId.ToString() + " ";
            result += this.Name + ": ";
            foreach (Student student in Students)
            {
                result += student.Name + ", ";
            }
            result = result.Remove(result.Length - 2) + "<br />";
            return result;
        }
    }
}