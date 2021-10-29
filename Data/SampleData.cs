using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Assignment1.Models;

namespace Assignment1.Data
{
    public class SampleData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                // Look for any Provinces.
                if (context.Students.Any())
                {
                    return;   // DB has already been seeded
                }

                var students = GetStudents().ToArray();
                context.Students.AddRange(students);
                context.SaveChanges();

            }
        }

        public static List<Student> GetStudents()
        {
            List<Student> Students = new List<Student>() {
            new Student() {
                FirstName="Jim",
                LastName="Potter",
                MobileNumber="604-123-4567",
                Email="jim@potter.com",
                City="Chilliwack",
                Specialization="Nursing"
            },
            new Student() {
                FirstName="Harry",
                LastName="Potter",
                MobileNumber="778-754-7898",
                Email="harrypotterisawesome@gmail.com",
                City="Burnaby",
                Specialization="Nursing"
            },
            new Student() {
                FirstName="Tom",
                LastName="Gardner",
                MobileNumber="778-878-7895",
                Email="tomgardner@email.com",
                City="Richmond",
                Specialization="FSWD"
            },
            new Student() {
                FirstName="James",
                LastName="Jone",
                MobileNumber="604-352-5325",
                Email="jamesjone@email.com",
                City="Burnaby",
                Specialization="Nursing"
            },
            new Student() {
                FirstName="Susan",
                LastName="Taylor",
                MobileNumber="604-123-1234",
                Email="Susantaylor@email.com",
                City="Vancouver",
                Specialization="CIT"
            },
            new Student() {
                FirstName="Ann",
                LastName="Lee",
                MobileNumber="604-314-4214",
                Email="annlee@email.com",
                City="Richmond",
                Specialization="FSWD"
            },
            new Student() {
                FirstName="Peter",
                LastName="White",
                MobileNumber="777-888-9999",
                Email="peter@white.com",
                City="Surrey",
                Specialization="CIT"
            },
            new Student() {
                FirstName="Philip",
                LastName="Fox",
                MobileNumber="444-555-6666",
                Email="philip@fox.com",
                City="Burnaby",
                Specialization="FSWD"
            },
            new Student() {
                FirstName="Donna",
                LastName="Ray",
                MobileNumber="111-222-3333",
                Email="donna@ray.com",
                City="Abbotsford",
                Specialization="CST"
            },
        };

            return Students;
        }

    }
}