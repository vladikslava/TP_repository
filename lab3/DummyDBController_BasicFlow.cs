using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class DummyDBController_BasicFlow : IDataBaseController
    {
        public bool checkFillDock()
        {
            return true;
        }

        public bool checkProductID()
        {
            return true;
        }

        public IDocumentToPrint fillDoc(int idNumber)
        {
            return new DummyProductEntry()
            {
                name = "Product",
                producer = "Producer",
                description = "description of product description of product description of product description of product description of product description of product description of product",
                year = 2024,
                price = 1999.29
            };
        }

        public bool tryConnectDB()
        {
            return true;
        }
    }
}
