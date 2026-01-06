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
            //Student[] students = new Student[]
            //{
            //    new Student() { Name = "Jane Smith", Description = "Another student", Age = 22 },
            //    new Student() { Name = "Mike Johnson", Description = "Yet another student", Age = 23 },
            //    new Student() { Name = "Emily Davis", Description = "More students", Age = 20 }
            //};
            //context.Students.AddRange(students);
            //context.SaveChanges();
            //Console.WriteLine("Bulk students added successfully.");

            Group group = new Group()
            {
                Name = "Group A",
                Limit = 30
            };
            context.Group.Add(group);
            context.SaveChanges();
            Console.WriteLine("Group added successfully.");
            Group group1 = new Group()
            {
                Name = "Group B",
                Limit = 25
            };
            context.Group.Add(group1);
            context.SaveChanges();
            Console.WriteLine("Group added successfully.");

            Student student1 = new Student()
            {
                Name = "Alice Brown",
                Description = "Student in Group A",
                Age = 19,
                GroupId = group.Id
            };
            context.Students.Add(student1);
            context.SaveChanges();
            Console.WriteLine("Student with group added successfully.");
            AppDbContext context2 = new AppDbContext();
            var studentsInGroupA = context2.Students
                .Where(s => s.GroupId == group.Id)
                .ToList();
            Console.WriteLine("Students in Group A:");
            foreach (var student in studentsInGroupA)
            {
                Console.WriteLine(student);


            }

        }
    }
}
