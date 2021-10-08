using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoviesWebiste_V01.Models;
namespace MoviesWebiste_V01.CustomClasses
{
    public class CustomerManger
    {
        public static bool AddCustomerDetials(customer temp)
        {
            
            using (var dbContext = new MoviesWebsiteDBEntities())
            {
                dbContext.customers.Add(temp);
                dbContext.SaveChanges();
            }
            return true;
        }
    }
}