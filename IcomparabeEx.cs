using System;
using System.Collections;
//using System.Collections.Generic;

namespace IComparableDemo
{
    public class Student : IComparable<Student>
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int CompareTo(Student student)
        {
            if(this.RollNo==student.RollNo)
            {
                return this.Name.CompareTo(student.Name);
            }
            return student.RollNo.CompareTo(this.RollNo);
        }
        public override string ToString()
        {
            return this.RollNo.ToString()+" : "+this.Name;
        }

    }
    class IcomparabeEx
    {
        static void Main(string[] args)
        {
            ArrayList AL = new ArrayList();
            AL.Add(new Student() { Name = "Vivek", RollNo = 17 });
            AL.Add(new Student() { Name = "Krunal", RollNo = 50 });
            AL.Add(new Student() { Name = "Nirbhay", RollNo = 7 });
            AL.Add(new Student() { Name = "Abhi", RollNo = 17 });
            AL.Add(new Student() { Name = "Sameer", RollNo = 29 });

            foreach(var e in AL)
            {
                Console.WriteLine(e);
            }
        }
    }
}
