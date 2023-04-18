using Microsoft.AspNetCore.Mvc;
using Student.DataAccess;
using Student.Models;
using Student.ViewModels;
using System.Collections.Generic;

namespace Student.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()
        {
            List<Groups> groups = Data.Groups;
            List<Students> students = Data.Students;


            GroupViewModels viewMd = new GroupViewModels
            {
                Groups = groups,
                Students = students
            };

            return View(viewMd);
        }

        public ViewResult Detail(int id)
        {
            List<Students> students = Data.Students;

            Students stud = students.Find(x => x.Id == id);


            return View(stud);
        }

       
    }
}
