using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Assignment
{
    class Section
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public  Section(string name)
        {
            this.name = name;
        }
        public void ShowAllSection()
        {
            Console.WriteLine("Section : " + Name);
        }
    }
}
