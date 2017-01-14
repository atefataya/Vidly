using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        //application db context to access the database
        private ApplicationDbContext _context;

        public CustomersController()
        {
            //initializing the _context
            _context = new ApplicationDbContext();
         
        }

        protected override void Dispose(bool disposing)
        {
            //disposing the _context
            _context.Dispose();
        }
        // GET: Customers
        [Route("customers/index")]
        public ViewResult Index()
        {

            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }
        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer {Id = 1, Name = "Atef Ataya"},
        //        new Customer {Id = 2, Name = "John Smith"}
        //    };

        //}

    }
}