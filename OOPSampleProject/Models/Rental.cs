using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSampleProject.Models
{
    public class Rental
    {
        private bool isRent { get; set; }

        public int CarId  { get; set; }
        public string CarName { get; set; }
        public decimal Price { get; set; }


        public string Rentme()
        {
            if (!isRent)
            {
                isRent = true;
                return "You are eligible to rent a car";
            }
            else
            {
                return "This car is already rented";
            }
        }

       
        }
    }

