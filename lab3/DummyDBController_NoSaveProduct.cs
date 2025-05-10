using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class DummyDBController_NoSaveProduct : IDataBaseController
    {
        public bool checkFillDock()
        {
            return false;
        }

        public bool checkProductID()
        {
            return true;
        }

        public IDocumentToPrint fillDoc(int idNumber)
        {
            return new DummyProductEntry()
            {
                name = "product",
                producer = "producer",
                description = "description",
                year = 2024,
                price = 1015.80
            };
        }

        public bool tryConnectDB()
        {
            return true;
        }
    }
}
