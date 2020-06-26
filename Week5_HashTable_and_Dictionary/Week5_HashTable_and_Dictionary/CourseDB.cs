using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_HashTable_and_Dictionary
{
    class CourseDB
    {
        public Dictionary<string, Course> courseList = null;

        public CourseDB()
        {
            courseList = new Dictionary<string, Course>();
        }

        public bool SaveCourse(Course course)
        {
            if (course.Code == "")
                return false;
            courseList.Add(course.Code, course);
            return true;
        }

        public Course FindCourse(string courseCode)
        {
            if (!courseList.ContainsKey(courseCode))
                return null;
            else
            {
                Course courseFound = courseList[courseCode] as Course;
                return courseFound;
            }
        }

        public Course[] GetCourses()
        {
            return courseList.Values.ToArray<Course>();
        }

        public bool DeleteCourse(String courseCode)
        {
            if (courseList.ContainsKey(courseCode))
            {
                courseList.Remove(courseCode);
                return true;
            }
            return false;
        }
    }
}
