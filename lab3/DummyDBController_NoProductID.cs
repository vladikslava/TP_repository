using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class DummyDBController_NoProductID : IDataBaseController
    {
        public bool checkFillDock()
        {
            return false;
        }

        public bool checkProductID()
        {
            return false;
        }

        public IDocumentToPrint fillDoc(int idNumber)
        {
            throw new NotImplementedException();
        }

        public bool tryConnectDB()
        {
            return true;
        }
    }
}
