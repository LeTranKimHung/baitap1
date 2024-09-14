using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(1, "Hung", 18);
            student s2 = new student(2, "Huy", 8);
            student s3 = new student(3, "Hien", 20);
            student s4 = new student(4, "Anh", 21);
            student s5 = new student(5, "Dat", 15);
            List<student> students = new List<student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            //a.Danh sách học sinh
            Console.WriteLine("Danh sach hoc sinh: ");
            foreach (student student in students)
            {
                Console.WriteLine(student);
            }
            //b.Danh sách các học sinh có tuổi từ 15 đến 18
            foreach (var x in students) { Console.WriteLine(x.ToString()); };
            var st = students.Where(x => x.Age >= 15 && x.Age <= 18);
            Console.WriteLine("Danh sach hoc sinh co tuoi tu 15-18: ");
            foreach (var x in st) { Console.WriteLine(x.ToString()); };
            //c.Học sinh có tên bắt đầu bằng chữ A
            Console.WriteLine("Hoc sinh bat dau bang chu A: ");
            var stA = students.Where(x => x.Name.StartsWith("A"));
            foreach (var x in stA) { Console.WriteLine(x.ToString()); };
            //d. Tính tổng tuổi của tất cả học sinh 
            int TT = students.Sum(x => x.Age);
            Console.WriteLine($"Tong tuoi cua hoc sinh:{TT}");
            // e. Học sinh có tuổi lớn nhất
            var max = students.Where(x => x.Age == students.Max(y => y.Age));
            Console.WriteLine("Danh sach tuoi lon nhat:");
            foreach (var x in max) { Console.WriteLine(x.ToString()); };
            // f. Sắp xếp học sinh theo tuổi tăng dần 
            Console.WriteLine("Danh sach hoc sinh sap xep theo tuoi tang dan:");
            var sx = students.OrderBy(x => x.Age).ThenBy(n => n);
            foreach (var x in sx) { Console.WriteLine(x.ToString()); };
        }
    }
}