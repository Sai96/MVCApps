﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.com.Models;
using Vidly.Models;
using System.Data.Entity;
using Vidly.com.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult CustomersList()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        public ActionResult CustomerForm()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View("CustomerForm",viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customers customers)
        {
            if(customers.Id==0)
            _context.Customers.Add(customers);
            else
            {
                var customerinDB = _context.Customers.Single(c=>c.Id==customers.Id);
                customerinDB.Name = customers.Name;
                customerinDB.BirthDate = customers.BirthDate;
                customerinDB.IsSubscribedToNewsletter = customers.IsSubscribedToNewsletter;
                customerinDB.MembershipTypeId = customers.MembershipTypeId;
            }

            _context.SaveChanges();
            return RedirectToAction("CustomersList", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerViewModel
            {
                customers = customer,
                MembershipTypes = _context.MembershipTypes.ToList()

            };
            return View("CustomerForm",viewModel);


        }
    }
}