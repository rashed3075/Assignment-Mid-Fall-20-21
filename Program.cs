using System;

namespace Mid_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            University u1 = new University("AIUB", 4, 100);
            Console.WriteLine("**************************************");
            Console.WriteLine("Welcome to " + u1.Name + " Management System");
            Console.WriteLine("**************************************");
            Department d1 = new Department("CSE", "1101", 20);
            Department d2 = new Department("EEE", "1102", 15);
            Department d3 = new Department("BBA", "1103", 13);
            
            Department d4 = new Department("CE", "1104", 10);
            u1.InsertDepartment(d1,d2,d3,d4);
            Console.WriteLine("**************************************");
            u1.ShowAllDept();
            Console.WriteLine("**************************************");
            u1.DeleteDepartment(d3);
            Console.WriteLine("**************************************");
            u1.ShowAllDept();
            Console.WriteLine("**************************************");
            Faculty f1 = new Faculty("Mr.X","19-39431-1","1@gmail.com",5);
            Faculty f2 = new Faculty("Mr.A","19-39422-1","2@gmail.com",6);
            Faculty f3 = new Faculty("Mr.Y","19-39411-1","3@gmail.com",3);
            Faculty f4 = new Faculty("Mr.z","19-39453-1","4@gmail.com",4);
            u1.InsertFaculty(f1, f2, f3, f4);
            u1.DeleteFaculty(f2);
            Console.WriteLine("**************************************");
            u1.ShowAllFaculty();
            Console.WriteLine("**************************************");
            Course c1 = new Course("IPL","CSE 1",4,10);
            Course c2 = new Course("DS","CSE 2",4,7);
            Course c3 = new Course("DM","CSE 3",3,5);
            Course c4 = new Course("Electric","EEE 1",4,10);
            Course c5 = new Course("Device","EEE 2",4,9);
            Course c6 = new Course("History","BBA 1",3,10);
            Course c7 = new Course("Business Studie","BBA 2",3,12);
            d1.InsertCourse(c1, c2, c3);
            d2.InsertCourse(c4,c5);
            d3.InsertCourse(c6, c7);
            Console.WriteLine("**************************************");
            d1.ShowInfo();
            Console.WriteLine("**************************************");
            d2.ShowInfo();
            Console.WriteLine("**************************************");
            d3.ShowInfo();
            Console.WriteLine("**************************************");
            Section s1 = new Section("A");
            Section s2 = new Section("B");
            Section s3 = new Section("C");
            Section s4 = new Section("D");
            Section s5 = new Section("E");
            Section s6 = new Section("F");
            Section s7 = new Section("G");
            Section s8 = new Section("H");
            Section s9 = new Section("I");
            Section s10 = new Section("J");
            Section s11 = new Section("K");
            c1.InsertSection(s1, s2, s3, s4, s5);
            c2.InsertSection(s1, s2, s3, s4);
            c3.InsertSection(s1, s2, s3, s4, s5,s6,s7);
            c4.InsertSection(s1, s2, s3, s4, s5,s6);
            c5.InsertSection(s1, s2, s3);
            c6.InsertSection(s1, s2, s3, s4, s5,s6,s7,s8);
            c7.InsertSection(s1, s2, s3, s4, s5);
            Console.WriteLine("**************************************");
            c2.ShowAllSection();
            Console.WriteLine("**************************************");
            f1.insertSection(s1,s3,s5,s6);
            f2.insertSection(s1,s2,s3,s6);
            f3.insertSection(s1,s3,s5,s6,s10);
            f4.insertSection(s1,s3,s5,s2);
            Console.WriteLine("**************************************");
            f1.ShowInfo();
            Console.WriteLine("**************************************");
            f2.ShowInfo();
            Console.WriteLine("**************************************");
        }
    }
}
