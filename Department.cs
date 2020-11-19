using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Assignment
{
    class Department
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private int courseSize;

        public int CourseSize
        {
            get { return courseSize; }
            set { courseSize = value; }
        }
        Course[] course;

        public Department() { }
        public Department(string name, string id,int courseSize)
        {
            this.name = name;
            this.id = id;
            course = new Course[courseSize];
        }

        public void ShowInfo()
        {

            Console.WriteLine("Department name : " + Name);
            Console.WriteLine("Department id : " + Id);
            foreach (Course c in course)
            {
                if (c != null)
                {
                    c.ShowAllCourse();
                }
            }
        }
        public void InsertCourse(params Course[] c)
        {
            foreach(var f in c)
            {
                for (int i = 0; i < course.Length; i++)
                {
                    if (course[i] != null)
                    {
                        if (course[i].Id.Equals(f.Id))
                        {
                            Console.WriteLine("Opps! The Course already exist!");
                            break;
                        }
                    }
                    if (course[i] == null)
                    {
                        course[i] = f;
                        break;
                    }
                }
            }
            
            
            
        }
        public void RemoveCourse(params Course[] c)
        {
            foreach (var f in c)
            {
                for (int i = 0; i < course.Length; i++)
                {
                    if (course[i] == f)
                    {
                        course[i] = null;
                        break;
                    }
                }
            }
              
        }
        public Course SearchCourse(string courseId)
        {
            Course c = null;
            for(int i = 0; i<course.Length;i++)
            {
                if(course[i]!=null)
                {
                    if(course[i].Id.Equals(courseId))
                    {
                        c = course[i];
                    }
                }
            }
            return c;
        }
        
    }
}
