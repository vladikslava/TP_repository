using lab3;
using System;
using NUnit.Framework;

namespace UnitTestProject
{
    public class Tests
    {
        /// <summary>
        /// Корректные данные для метода.
        /// В функцию переданы корректные данные о товаре.
        /// </summary>

        [Test]
        public void T_001_SaveInformationProduct_BaseFlow()
        {
            string name = "Product";
            string producer = "Producer";
            string description = "description of product description of product description of product description of product description of product description of product description of product";
            int year = 2024;
            double price = 1999.29;

            bool expectedReturnValue = true;

            bool actualReturnValue = false;

            Assert.DoesNotThrow(() =>
            {
                actualReturnValue = EditForm.SaveInformationProduct(name, producer, description, year, price);
            });
            Assert.AreEqual(expectedReturnValue, actualReturnValue);
        }

    }
}