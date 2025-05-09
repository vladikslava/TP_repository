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

            var newYear = Int32.Parse(year);
            var newPrice = double.Parse(price, System.Globalization.CultureInfo.InvariantCulture);

            var product = new Product(name, producer, description, newYear, newPrice);
            MessageBox.Show("Сохранение прошло успешно!");
            return true;
        }


    }
}
