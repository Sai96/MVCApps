using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.com.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes{ get; set; }
        public Customers customers { get; set; }

    }
}