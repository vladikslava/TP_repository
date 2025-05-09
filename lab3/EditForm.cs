using System.Diagnostics;

namespace lab3
{
    public partial class EditForm : Form
    {

        Product product;
        public EditForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string year = TextBoxYear.Text.Replace(" г.", "").Trim();
            string price = TextBoxPrice.Text.Replace(" ₽", "").Trim();

            var newYear = Int32.Parse(year);
            var newPrice = double.Parse(price, System.Globalization.CultureInfo.InvariantCulture);
            SaveInformationProduct(textBoxName.Text, textBoxProducer.Text, textBoxDescription.Text, newYear, newPrice);
        }

        public static bool SaveInformationProduct(string name, string producer, string description, int year, double price)
        {
            var product = new Product(name, producer, description, year, price);
            MessageBox.Show("Сохранение прошло успешно!");
            return true;
        }


    }
}
