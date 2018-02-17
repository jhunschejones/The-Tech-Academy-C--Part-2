using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */

            List<Course> courses = new List<Course>() {
                new Course { CourseId=101, Name="Basic Math", Students=new List<Student>() {
                    new Student() { StudentId = 01, Name = "Joe"},
                    new Student() { StudentId = 02, Name = "Bob" },
                    new Student() { StudentId = 03, Name = "Linda" }
                } },
                new Course { CourseId=102, Name="Intro Chemistry", Students=new List<Student>() {
                    new Student() { StudentId = 04, Name = "Sara" },
                    new Student() { StudentId = 03, Name = "Linda" }
                } },
                new Course { CourseId = 202, Name = "Intermediate Spanish", Students=new List<Student>() {
                    new Student() { StudentId = 01, Name = "Bob" },
                    new Student() { StudentId = 05, Name = "Dan" }
                } }
            };
            
            foreach (Course course in courses)
            {
                resultLabel.Text += course.printCourses();
            }
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            Dictionary<int, Student> myStudents = new Dictionary<int, Student>();
            myStudents.Add(01, new Student {
                StudentId = 01,
                Name = "Joe",
                Courses = new List<Course>() {
                    new Course() { CourseId = 101, Name = "Basic Math"},
                    new Course() { CourseId = 102, Name = "Intro Chemistry"}
                }
            });
            myStudents.Add(02, new Student
            {
                StudentId = 02,
                Name = "Bob",
                Courses = new List<Course>() {
                    new Course() { CourseId = 101, Name = "Basic Math"},
                    new Course() { CourseId = 202, Name = "Intermediate Spanish"}
                }
            });
            myStudents.Add(03, new Student
            {
                StudentId = 03,
                Name = "Linda",
                Courses = new List<Course>() {
                    new Course() { CourseId = 202, Name = "Intermediate Spanish"},
                    new Course() { CourseId = 102, Name = "Intro Chemistry"}
                }
            });

            foreach (var student in myStudents)
            {
                resultLabel.Text += student.Value.printStudents();
            }
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */
            Student student = new Student()
            {
                StudentId = 03,
                Name = "Linda"
            };

            student.Grades = new List<Grade>()
            {
                new Grade() { StudentGrade = 92, StudentCourse = new Course() { CourseId = 202, Name = "Intermediate Spanish"} },
                new Grade() { StudentGrade = 85, StudentCourse = new Course() { CourseId = 102, Name = "Intro Chemistry"} }
            };

            resultLabel.Text = String.Format("Grades for student ID {0} -- {1} <br />", student.StudentId.ToString(), student.Name);

            foreach (var grade in student.Grades)
            {
                resultLabel.Text += grade.StudentGrade.ToString() + "% in " + grade.StudentCourse.Name + "<br />";
            }

        }
    }
}