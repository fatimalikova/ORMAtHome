using OrmConnection.Data;
using System;
using OrmConnection.Models;

namespace OrmConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();
            //Student student = new Student()
            //{
            //    Name = "John Doe",
            //    Description = "A sample student",
            //    Age = 21
            //};
            //context.Students.Add(student);
            //context.SaveChanges();
            //Console.WriteLine("Student added successfully.");

            //Bulk insert
            Student[] students = new Student[]
            {
                new Student() { Name = "Jane Smith", Description = "Another student", Age = 22 },
                new Student() { Name = "Mike Johnson", Description = "Yet another student", Age = 23 },
                new Student() { Name = "Emily Davis", Description = "More students", Age = 20 }
            };
            context.Students.AddRange(students);
            context.SaveChanges();
            Console.WriteLine("Bulk students added successfully.");


        }
    }
}
