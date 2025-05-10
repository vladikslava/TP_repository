using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
