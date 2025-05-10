using Microsoft.VisualBasic.Logging;
using System.CodeDom;
using System.Diagnostics;

namespace lab3
{

    public partial class EditForm : Form
    {

        Product product;
        public IDataBaseController controller = null;
        public int id = 2012;

        public EditForm()
        {
            InitializeComponent();
        }

        public IDocumentToPrint OnMakeDockClick(string name, string producer, string description, string year, string price)
        {
            if (CheckSaveInformationProduct(name, producer, description, year, price))
            {
                if (controller.tryConnectDB())
                {
                    if (controller.checkProductID())
                    {
                        IDocumentToPrint documentToPrint = controller.fillDoc(id);
                        if (controller.checkFillDock())
                        {
                            return documentToPrint;
                        }
                        else
                        {
                            throw new Exception(ExceptionStrings.NoSaveProduct);
                        }
                    }
                    else
                    {
                        throw new Exception(ExceptionStrings.NoIDProduct);
                    }
                }
                else
                {
                    throw new Exception(ExceptionStrings.NoConnectionDB);
                }
            }

            return null;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CheckSaveInformationProduct(textBoxName.Text, textBoxProducer.Text, textBoxDescription.Text, TextBoxYear.Text, TextBoxPrice.Text);
        }

        public static bool CheckSaveInformationProduct(string name, string producer, string description, string year, string price)
        {
            year = year.Replace(" г.", "").Trim();
            price = price.Replace(" ₽", "").Trim();

            if (year == null || year.Length == 0)
            {
                throw new Exception(ExceptionStrings.EmptyYear);
            }
            if (price == null || price.Length == 0)
            {
                throw new Exception(ExceptionStrings.EmptyPrice);
            }

            if (!int.TryParse(year, out int intValue))
            {
                throw new Exception(ExceptionStrings.NotYear);
            }
            if(!double.TryParse(price, System.Globalization.CultureInfo.InvariantCulture, out double doubleValue))
            {
                throw new Exception(ExceptionStrings.NotPrice);
            }

            var newYear = Int32.Parse(year);
            var newPrice = double.Parse(price, System.Globalization.CultureInfo.InvariantCulture);

            if (name == null || name.Length == 0)
            {
                throw new Exception(ExceptionStrings.EmptyName);
            }
            if (producer == null || producer.Length == 0)
            {
                throw new Exception(ExceptionStrings.EmptyProducer);
            }
            if (description == null || description.Length == 0)
            {
                throw new Exception(ExceptionStrings.EmptyDescription);
            }
            
            if (description.Length > 250)
            {
                throw new Exception(ExceptionStrings.FullDescription);
            }
            if (newYear < 2000 || newYear > 2025)
            {
                throw new Exception(ExceptionStrings.WrongYear);
            }
            
            MessageBox.Show("Сохранение прошло успешно!");
            return true;
        }


    }
}
