using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Assignment
{
    class Faculty
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

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private double teachingHour;

        public double TeachingHour
        {
            get { return teachingHour; }
            set { teachingHour = value; }
        }
        private int secCount;

        public int SecCount
        {
            get { return secCount; }
            set { secCount = value; }
        }


        Section[] section;        
        public Faculty() { }
        public Faculty(string name, string id, string email,int secCount)
        {
            this.name = name;
            this.id = id;
            this.email = email;
            
            section = new Section[secCount];
        }
        public void insertSection(params Section[] sec)
        {
            foreach (var s in sec)
            {
                for (int i = 0; i < section.Length; i++)
                {
                    if (section[i] == null)
                    {
                        if (TeachingHour <= 21)
                        {
                            section[i] = s;
                            TeachingHour = TeachingHour + 5;
                        }
                    }
                }
            }
             
        }
        public void ShowInfo()
        {
            Console.WriteLine("Faculty Name : " + Name);
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Email : " + Email);
            
        }

    }
}
