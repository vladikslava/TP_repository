using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    //класс двойник сущности "Продукт", хранящий информацию о нем
    internal class Product
    {
        string name = "prod";
        string producer = "pro";
        string description = "description";
        int year = 2020;
        double price = 15;


        public Product(string name, string producer, string description, int year, double price)
        {
            this.name = name;
            this.producer = producer;
            this.description = description;
            this.year = year;
            this.price = price;
        }

        
    }
}
