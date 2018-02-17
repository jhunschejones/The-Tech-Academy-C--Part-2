using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }

        public string printStudents()
        {
            string result = "Student " + this.StudentId.ToString() + " - ";
            result += this.Name + " : ";
            foreach (Course course in Courses)
            {
                result += course.Name + ", ";
            }
            result = result.Remove(result.Length - 2) + "<br />";
            return result;
        }
    }
}