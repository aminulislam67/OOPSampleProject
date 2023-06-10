using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSampleProject.Models
{
    public class Car
    {
        private Car()
        {
            Price = 50;
        }

        public Car(Engine engine):this()
        {
            this.CarEngine = engine;
        }

        public Car(Rental rental)
        {
            this.Rent1 = rental;
        }

        public string Model
        {
            get;set;
        }

        public string Co7lor { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }

        private Engine CarEngine { get; set; }
        private Rental Rent1 { get; set; }

        public string Start()
        {
            return CarEngine.Start();
        }

        public string Accelarate()
        {
            return CarEngine.Accelarate();
        }
       public string Rentme()
        {
            return Rent1.Rentme();
        }


    }
}
