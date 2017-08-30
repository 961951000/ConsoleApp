using ConsoleApp.Db;
using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Helper
{
    public class DbHelper
    {
        private readonly DefaultDbContext _db = new DefaultDbContext();
        public int Insert()
        {
            var school = new School
            {
                SchoolName = "School"
            };

            var students = new[] {
                new Student
                {
                    StudentName = "Student1",
                    School = school
                },
                new Student
                {
                    StudentName = "Student2",
                    School = school
                }
            };
            _db.Student.AddRange(students);

            return _db.SaveChanges();
        }

        public int Delete()
        {
            var school = _db.School.FirstOrDefault();
            if (school != null)
            {
                var students = _db.Student.Where(x => x.SchoolRefId == school.SchoolId);
                _db.Student.RemoveRange(students);
                _db.School.Remove(school);
            }

            return _db.SaveChanges();
        }

        public int Update()
        {
            var school = _db.School.FirstOrDefault();

            if (school != null)
            {
                school.SchoolName = "ShanghaiSchool";
                foreach (var student in _db.Student.Where(x => x.SchoolRefId == school.SchoolId))
                {
                    student.StudentName = $"Shanghai{student.StudentName}";
                }
            }

            return _db.SaveChanges();
        }

        public School Select()
        {
            var school = _db.School.FirstOrDefault();
            if (school != null)
            {
                school.Students = _db.Student.Where(x => x.SchoolRefId == school.SchoolId);
            }
            return _db.School.FirstOrDefault();
        }
    }
}
