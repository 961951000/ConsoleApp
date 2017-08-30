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
        public static readonly DefaultDbContext _db = new DefaultDbContext();
        public static int Insert()
        {
            //添加学校
            _db.School.Add(new School()
            {
                SchoolName = "学校"
            });

            //添加学生
            _db.Student.AddRange(new Student[] {
                new Student()
                {
                StudentName = "学生1",
                },
                new Student()
                {
                StudentName = "学生2",
                }
            });

            //找到学校  
            School school = _db.School.FirstOrDefault();

            //找到学生  
            IEnumerable<Student> students = _db.Student;

            //给学生添加学校 
            foreach (var student in students)
            {
                //给学生添加学校 
                student.School = school;
                student.SchoolRefId = school.SchoolId;
            }

            //让学校知道有哪些学生选择了它  
            school.Students = students;

            return _db.SaveChanges();
        }

        public static int Delete()
        {

            return _db.SaveChanges();
        }

        public static int Update()
        {

            return _db.SaveChanges();
        }

        public static int Select()
        {

            return _db.SaveChanges();
        }
    }
}
