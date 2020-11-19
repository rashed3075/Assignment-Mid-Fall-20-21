using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Assignment
{
    class University
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int sizeOfDepartment;

        public int SizeOfDepartment
        {
            get { return sizeOfDepartment; }
            set { sizeOfDepartment = value; }
        }

        private int sizeOfFaculty;

        public int SizeOfFaculty
        {
            get { return sizeOfFaculty; }
            set { sizeOfFaculty = value; }
        }




        Department[] department;
        Faculty[] faculty;

        public University() { }
        public University(string name, int sizeOfDepartment, int sizeOfFaculty)
        {
            this.name = name;
            department = new Department[sizeOfDepartment];
            faculty = new Faculty[SizeOfFaculty];
        }
        public void InsertDepartment( params Department[] dept)
        {
            foreach(var d in dept)
            {
                for (int i = 0; i < department.Length; i++)
                {

                    if (department[i] != null)
                    {
                        if (department[i].Id.Equals(d.Id) || department[i].Name.Equals(d.Name))
                        {
                            Console.WriteLine("Opps! The Department already exist!");
                            break;
                        }
                    }
                    if (department[i] == null)
                    {
                        department[i] = d;
                        break;
                    }
                }
            }
            
           
        }
        public void DeleteDepartment(params Department[] dept)
        {
            foreach (var d in dept)
            {
                for (int i = 0; i < department.Length; i++)
                {
                    if (department[i] == d)
                    {
                        department[i] = null;
                        break;
                    }

                }
            }
               
        }
        public Department SearchDepartment(string deptId)
        {
            Department d = null;
            for (int i = 0; i < department.Length; i++)
            {
                if (department[i] != null)
                {
                    if (department[i].Id.Equals(deptId))
                    {
                        d = department[i];
                        break;
                    }
                }
            }
            return d;
        }
        public void ShowAllDept()
        {
            foreach (Department d in department)
            {
                if (d != null)
                {
                    d.ShowInfo();
                }
            }
        }

        public void InsertFaculty(params Faculty[] fac)
        {
            foreach (var f in fac)
            {

                for (int i = 0; i < faculty.Length; i++)
                {

                    if (faculty[i] != null)
                    {
                        if (faculty[i].Id.Equals(f.Id))
                        {
                            Console.WriteLine("Opps! The Faculty already exist!");
                            break;
                        }
                    }

                    if (faculty[i] == null)
                    {
                        faculty[i] = f;
                        break;
                    }

                }
            }

        }
        public void DeleteFaculty(params Faculty[] fac)
        {
            foreach (var f in fac)
            {
                for (int i = 0; i < faculty.Length; i++)
                {
                    if (faculty[i] == f)
                    {
                        faculty[i] = null;
                        break;
                    }

                }
            }

            
        }
        public Faculty SearchFaculty(string factId)
        {
            Faculty f = null;
            for (int i = 0; i < faculty.Length; i++)
            {
                if (faculty[i] != null)
                {
                    if (faculty[i].Id.Equals(factId))
                    {
                        f = faculty[i];
                        break;
                    }
                }
            }
            return f;
        }
        public void ShowAllFaculty()
        {
            foreach (Faculty f in faculty)
            {
                if (f != null)
                {
                    f.ShowInfo();
                }
            }
        }
    }
}
