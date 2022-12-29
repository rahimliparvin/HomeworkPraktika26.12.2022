using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerService
    {
        

        public int GetCustomerCountByFiltered()
        {
            var customers = GetAll();

            int count = 0;
            foreach (var item in customers)
            {
                if(item.Age > 25 && item.Age < 30)
                {
                    count++;
                }
            }

            return count;
        }

        public double GetCustomersAverageByAges()
        {
            var customers = GetAll();

            
            double sumAge = 0;

            foreach (var item in customers)
            {
                sumAge += item.Age;
            }
            //sumAge / customers.Length;
            return Math.Ceiling (sumAge / customers.Length);

        }

        public Customer[] GetCustomersByFiltered(int startAge, int endAge)
        {
            var customers = GetAll();

            Customer[] result = new Customer[customers.Length];

            int count = 0;

            foreach (var item in customers)
            {
                if (item.Age > startAge && item.Age < endAge)
                {
                    result[count++] = item;
                    count++;
                }
            }


            return result;
        }

       
        
        private Customer[] GetAll()
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                Name = "Mahir",
                Surname = "Abdullayev",
                Age = 26,
                Position = "Fullstack developer"
            };

            Customer customer2 = new Customer
            {
                Id = 2,
                Name = "Kamal",
                Surname = "Babayev",
                Age = 25,
                Position = "Backend developer"
            };


            Customer customer3 = new Customer
            {
                Id = 3,
                Name = "Ayxan",
                Surname = "Velizade",
                Age = 19,
                Position = "Software instructor"
            };


            Customer customer4 = new Customer
            {
                Id = 4,
                Name = "Murad",
                Surname = "Camalov",
                Age = 28,
                Position = "Frontend developer"
            };

            Customer[] customers = {customer1,customer2,customer3,customer4};
            return customers;
        }
   
        

    }
}
