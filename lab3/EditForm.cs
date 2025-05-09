using Microsoft.VisualBasic.Logging;
using System.CodeDom;
using System.Diagnostics;

namespace lab3
{

    public static class ExceptionStrings
    {
        public const string EmptyName = "Поле имени не может быть пустым";
        public const string EmptyProducer = "Поле производителя не может быть пустым";
        public const string EmptyDescription = "Поле описания не может быть пустым";
        public const string EmptyYear = "Поле года не может быть пустым";
        public const string EmptyPrice = "Поле цены не может быть пустым";
        public const string NotYear = "Поле года содержит недопустимые символы";
        public const string NotPrice = "Поле цены содержит недопустимые символы";
        public const string WrongYear = "Поле года некорректно";
        public const string FullDescription = "Описание больше 250 символов";
    }
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

        public static bool SaveInformationProduct(string name, string producer, string description, string year, string price)
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
            
            var product = new Product(name, producer, description, newYear, newPrice);
            MessageBox.Show("Сохранение прошло успешно!");
            return true;
        }


    }
}
