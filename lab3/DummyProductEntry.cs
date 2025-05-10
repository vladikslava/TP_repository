using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class DummyProductEntry : IDocumentToPrint
    {
        public string name {  get; set; }
        public string description { get; set; }
        public string producer { get; set; }
        public int year {  get; set; }
        public double price {  get; set; }

    }
}
