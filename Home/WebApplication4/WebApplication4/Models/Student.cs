using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Student
    {
        private static List<StudentItem> students = new List<StudentItem>() {
            new StudentItem{Id=1,Name="aaa",GroupId=1},
            new StudentItem{Id=2,Name="bbb",GroupId=2},
            new StudentItem{Id=3,Name="ccc",GroupId=3 }
        };


        public static List<StudentItem> GetAllStudents()
        {
            return students;
        }
        }

    public class StudentItem {
        public int Id { get; set; }

        public int GroupId { get; set; }

        public string Name { get; set; }
    }
    }
