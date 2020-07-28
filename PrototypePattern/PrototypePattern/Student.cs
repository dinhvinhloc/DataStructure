using System;

namespace PrototypePattern
{
    internal class Student : ICloneable
    {
        public string Name { get; set; }
        private Course StudentCourse;

        public Student(string name, string courseName, string courseID)
        {
            this.Name = name;
            this.StudentCourse = new Course(courseName, courseID);
        }
        internal string getName() {
            return Name;
        }


        internal Student Clone() //Shallow copy
        {
            return (Student)base.MemberwiseClone();
        }

        internal Course getCourse()
        {
            return StudentCourse;
        }

        object ICloneable.Clone() //Shallow copy
        {
            return base.MemberwiseClone();
        }


        internal Student DeepCopy() //Deep copy
        {
            Student temp = (Student)base.MemberwiseClone();
            temp.StudentCourse = new Course(StudentCourse.getName(), StudentCourse.getID());
            return temp;
        }
    }
}