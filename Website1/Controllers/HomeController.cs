using Microsoft.AspNetCore.Mvc;
using Website1.Models;

namespace Website1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Useremp useremp = new Useremp();
            useremp.employee.Ename = "ram";
            useremp.employee.Eage = 34;
            useremp.employee.EId = 402;

            useremp.user.Name = "KUMAR";
            useremp.user.Age = 40;
            useremp.user.Id = 342;





            return View(useremp);
        }


        public IActionResult about()
        {

            Class1 user = new Class1();
            user.Name = "SAKTHIVEL A";
            user.Age = 20;
            user.Id = 102;
            return View(user);
        }
        public IActionResult Login()
        {

            List<Class1> Listuser1 = new List<Class1>
            {
                new Class1{Name="SAKTHIVEL A",Age=20,Id=201},
                new Class1{Name="BHARATH",Age=21,Id=323},
                 new Class1{Name="VEL",Age=21,Id=323},
                  new Class1{Name="SRI",Age=21,Id=323},
                   new Class1{Name="NATH",Age=21,Id=323},
                    new Class1{Name="GOKUL",Age=21,Id=323},
                     new Class1{Name="HARISH",Age=21,Id=323},
                      new Class1{Name="VASANTH",Age=21,Id=323},

                       new Class1{Name="YUGI",Age=21,Id=323},
                new Class1{Name="LOGESH",Age=21,Id=323},

                       new Class1{Name="SUDHIN",Age=21,Id=323},
                       new Class1{Name="VIJAY",Age=21,Id=323},
                       new Class1{Name="RAJ",Age=21,Id=323},
                       new Class1{Name="RAM",Age=21,Id=323},
            };

            return View(Listuser1);
        }
        public IActionResult Register()
        {

            Class1 user = new Class1();
            user.Name = "HELLO USER";
            user.Age = 21;
            user.Id = 101;

            Emp employee = new Emp();
            employee.Ename = "HELLO EMPLOYEE";
            employee.Eage = 45;
            employee.EId = 102;





            return View((user, employee));





        }
        [HttpPost]
        public IActionResult Add()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Fetchdata()
        {
            return View();
        }
        [HttpPut]
        public IActionResult Update()
        {
            return View();
        }
        [HttpDelete]
        public IActionResult Deletedata()
        {
            return View();
        }
        [HttpPatch]
        public IActionResult specific_update()
        {
            return View();
        }


        public IActionResult Displaymodel()
        {

            Class1 user = new Class1();
            user.Name = "SAKTHI";
            user.Age = 21;
            user.Id = 101;
          
            




            return View(user);
        }
    }
}
