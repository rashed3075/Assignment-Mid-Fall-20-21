using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Assignment
{
    class Course
    {
        private string courseName;

        public string Name
        {
            get { return courseName; }
            set { courseName = value; }
        }
        private string courseId;

        public string Id
        {
            get { return courseId; }
            set { courseId = value; }
        }
        private int credit;

        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
        private int teachingHour;

        public int TeachingHour
        {
            get { return teachingHour; }
            set { teachingHour = value; }
        }


        private int sectionNumber;

        public int SecNumber
        {
            get { return sectionNumber; }
            set { sectionNumber = value; }
        }
        Section[] section;
        public Course() { }
        public Course(string courseName,string courseId , int credit,int sectionNumber)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.credit = credit;
          
            section = new Section[sectionNumber];
        }
        public void ShowAllCourse()
        {
            Console.WriteLine("Course Name : " + Name);
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Credit : " + Credit + " hours");
        }
        public void InsertSection(params Section[] s)
        {
            foreach (var sec in s)
            {
                for (int i = 0; i < section.Length; i++)
                {
                    if (section[i] == null)
                    {
                        section[i] = sec;
                        break;
                    }
                }
            }
                
        }
        public void DeleteSection(params Section[] s)
        {
            foreach (var sec in s)
            {
                for (int i = 0; i < section.Length; i++)
                {
                    if (section[i] == sec)
                    {
                        section[i] = null;
                        break;
                    }
                }
            }

            
        }
        public void ShowAllSection()
        {
            foreach(Section s in section)
            {
                if(s!=null)
                {
                    s.ShowAllSection();
                }
            }
        }
    }
}
