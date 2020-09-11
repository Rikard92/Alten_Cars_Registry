using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alten_Cars_Registry.Models;
using System.Threading;

namespace Alten_Cars_Registry.Controllers
{
    
    public class HomeController : Controller
    {
        public List<Car> emp;
        public HomeController()
        {
            emp = new List<Car>()
            {
                new Car()
                {VehicleId= "YS2R4X20005399401",Regnr="ABC123",Customer="Kalles Grustransporter AB",Addres="Cementvägen 8, 111 11 Södertälje",Status="Connected"},
                new Car()
                {VehicleId= "VLUR4X20009093588",Regnr="DEF456",Customer="Kalles Grustransporter AB",Addres="Cementvägen 8, 111 11 Södertälje",Status="Connected"},
                new Car()
                {VehicleId= "VLUR4X20009048066",Regnr="GHI789",Customer="Kalles Grustransporter AB",Addres="Cementvägen 8, 111 11 Södertälje",Status="Connected"},
                new Car()
                {VehicleId= "YS2R4X20005388011",Regnr="JKL012",Customer="Johans Bulk AB",Addres="Balkvägen 12, 222 22 Stockholm",Status="Connected"},
                new Car()
                {VehicleId= "YS2R4X20005387949",Regnr="MNO345",Customer="Johans Bulk AB",Addres="Balkvägen 12, 222 22 Stockholm",Status="Connected"},
                new Car()
                {VehicleId= "VLUR4X20009048066",Regnr="PQR678",Customer="Haralds Värdetransporter AB",Addres="Budgetvägen 1, 333 33 Uppsala",Status="Connected"},
                new Car()
                {VehicleId= "YS2R4X20005387055",Regnr="STU901",Customer="Haralds Värdetransporter AB",Addres="Budgetvägen 1, 333 33 Uppsala",Status="Connected"}
            };
            

            Thread thr1 = new Thread(method1);
            thr1.Start();
        }

        public void method1()
        {
            changeAllStatus();
        }


        public void changeAllStatus()
        {

            Random rnd = new Random();
            while (true)
            {
                Thread.Sleep(60000);
                foreach (Car C in emp)
                {
                    int num = rnd.Next(0, 99);
                    if (num < 30)
                    {
                        C.Status = "Disconnected";
                    }
                    else
                    {
                        C.Status = "Connected";
                    }
                }
            }            
        }




        public ActionResult Index()
        {           

            return View(emp);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}