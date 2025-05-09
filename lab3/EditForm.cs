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
            SaveInformationProduct(textBoxName.Text, textBoxProducer.Text, textBoxDescription.Text, TextBoxYear.Text, TextBoxPrice.Text);
        }

        public void SaveInformationProduct(string name, string producer, string description, string year, string price)
        {
            year = year.Replace(" г.", "").Trim();
            price = price.Replace(" ₽", "").Trim();

            var newYear = Int32.Parse(year);
            var newPrice = double.Parse(price, System.Globalization.CultureInfo.InvariantCulture);

            product = new Product(name, producer, description, newYear, newPrice);
            Debug.WriteLine(product);
            MessageBox.Show("Сохранение прошло успешно!");
        }

    }
}
