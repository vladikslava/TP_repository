using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public interface IDataBaseController
    {
        public bool tryConnectDB();
        public bool checkProductID();
        public IDocumentToPrint fillDoc(int idNumber);
        public bool checkFillDock();
    }
}
