using Microsoft.EntityFrameworkCore;
using SaledDbLib.Models;
using SalesDbLib.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesDbLib.Controllers;

namespace ef_tutorial_codefirst
{
    class Program
    {
        async static void Main(string[] args)
        {
            var ordCtrl = new OrdersController();
            var orders = await ordCtrlCrtl.GetAll();
            orders.ForEach(o => Console.WriteLine($"{o.Descritpion} | {o.Customer.Name}"));

            var cusCtrl = new CustomersController();
            var customer = await cusCtrl.GetAll();
            customer.ForEach(c => Console.WriteLine(c.Name));
        }
        
    }
}
