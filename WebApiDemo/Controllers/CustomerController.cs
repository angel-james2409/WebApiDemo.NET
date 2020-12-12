using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class CustomerController : ApiController
    {
        Context context = new Context();
    
    [HttpGet]
    public IEnumerable<Customer> GetCustomer()
    {
        return context.customer.ToList();
    }


        [HttpGet]
        public Customer GetCustomer(int id)
        {
            return context.customer.Find(id);
        }

        [HttpPost]
        public bool AddCustomer(Customer c)
        {
            bool successFlag = false;
            context.customer.Add(c);
            context.SaveChanges();
            successFlag = true;
            return successFlag;
        }

        [HttpPut]
        public bool UpdateCustomer(Customer c)
        {
            bool successflag = false;
            var cus = context.customer.SingleOrDefault(x => x.Id == c.Id);

            if (cus != null)
            {
                cus.Id = c.Id;
                cus.Name = c.Name;
                cus.Address = c.Address;
                cus.phoneNo = c.phoneNo;
                context.SaveChanges();
                successflag = true;
                return successflag;
            }
            return successflag;




        }

        [HttpDelete]
        public bool DeleteCustomer(int id)
        {
            bool successflag = false;
            var cus = context.customer.SingleOrDefault(x => x.Id == id);
            if (cus != null)
            {
                context.customer.Remove(cus);
                context.SaveChanges();
                successflag = true;
                return successflag;
            }

            return successflag;
        }

    }

}

