using Microsoft.AspNetCore.Mvc;
using Buoi3.Models;
using System.Collections.Generic;
using System.Linq;

namespace Buoi3.Controllers
{
    public class StudentController : Controller
    {
        // Giả lập danh sách lưu thông tin sinh viên
        private static List<Student> students = new List<Student>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowKQ(Student student)
        {
            students.Add(student);

            // Đếm số lượng SV cùng chuyên ngành
            int count = students.Count(s => s.ChuyenNganh == student.ChuyenNganh);

            ViewBag.MSSV = student.MSSV;
            ViewBag.HoTen = student.HoTen;
            ViewBag.ChuyenNganh = student.ChuyenNganh;
            ViewBag.Count = count;

            return View();
        }
    }
}
