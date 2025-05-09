using lab3;
using System;
using NUnit.Framework;

namespace UnitTestProject
{
    public class Tests
    {
        /// <summary>
        /// ���������� ������ ��� ������.
        /// � ������� �������� ���������� ������ � ������.
        /// </summary>

        [Test]
        public void T_001_SaveInformationProduct_BaseFlow()
        {
            string name = "Product";
            string producer = "Producer";
            string description = "description of product description of product description of product description of product description of product description of product description of product";
            string year = "2024";
            string price = "1999.29";

            bool expectedReturnValue = true;

            bool actualReturnValue = false;

            Assert.DoesNotThrow(() =>
            {
                actualReturnValue = EditForm.CheckSaveInformationProduct(name, producer, description, year, price);
            });
            Assert.AreEqual(expectedReturnValue, actualReturnValue);
        }

        [Test]
        public void T_002_SaveInformationProduct_EmptyName()
        {
            string name = "";
            string producer = "Producer";
            string description = "description of product description of product description of product description of product description of product description of product description of product";
            string year = "2024";
            string price = "1999.29";

            string expectedReturnValue = ExceptionStrings.EmptyName;

            Exception? exception = Assert.Throws<Exception>(() =>
            {
                EditForm.CheckSaveInformationProduct(name, producer, description, year, price);
            });
            Assert.IsNotNull(exception);
            Assert.AreEqual(expectedReturnValue, exception.Message);
        }
    
    
    [Test]
        public void T_003_SaveInformationProduct_EmptyProducer()
        {
            string name = "Product";
            string producer = "";
            string description = "description of product description of product description of product description of product description of product description of product description of product";
            string year = "2024";
            string price = "1999.29";

            string expectedReturnValue = ExceptionStrings.EmptyProducer;

            Exception? exception = Assert.Throws<Exception>(() =>
            {
                EditForm.CheckSaveInformationProduct(name, producer, description, year, price);
            });
            Assert.IsNotNull(exception);
            Assert.AreEqual(expectedReturnValue, exception.Message);
        }

        [Test]
        public void T_004_SaveInformationProduct_EmptyDescription()
        {
            string name = "Product";
            string producer = "Producer";
            string description = "";
            string year = "2024";
            string price = "1999.29";

            string expectedReturnValue = ExceptionStrings.EmptyDescription;

            Exception? exception = Assert.Throws<Exception>(() =>
            {
                EditForm.CheckSaveInformationProduct(name, producer, description, year, price);
            });
            Assert.IsNotNull(exception);
            Assert.AreEqual(expectedReturnValue, exception.Message);
        }

        [Test]
        public void T_005_SaveInformationProduct_EmptyYear()
        {
            string name = "Product";
            string producer = "Producer";
            string description = "description of product description of product description of product description of product description of product description of product description of product";
            string year = "";
            string price = "1999.29";

            string expectedReturnValue = ExceptionStrings.EmptyYear;

            Exception? exception = Assert.Throws<Exception>(() =>
            {
                EditForm.CheckSaveInformationProduct(name, producer, description, year, price);
            });
            Assert.IsNotNull(exception);
            Assert.AreEqual(expectedReturnValue, exception.Message);
        }

        [Test]
        public void T_006_SaveInformationProduct_EmptyPrice()
        {
            string name = "Product";
            string producer = "Producer";
            string description = "description of product description of product description of product description of product description of product description of product description of product";
            string year = "2024";
            string price = "";

            string expectedReturnValue = ExceptionStrings.EmptyPrice;

            Exception? exception = Assert.Throws<Exception>(() =>
            {
                EditForm.CheckSaveInformationProduct(name, producer, description, year, price);
            });
            Assert.IsNotNull(exception);
            Assert.AreEqual(expectedReturnValue, exception.Message);
        }


        [Test]
        public void T_007_SaveInformationProduct_NotYear()
        {
            string name = "Product";
            string producer = "Producer";
            string description = "description of product description of product description of product description of product description of product description of product description of product";
            string year = "202@";
            string price = "1999.29";

            string expectedReturnValue = ExceptionStrings.NotYear;

            Exception? exception = Assert.Throws<Exception>(() =>
            {
                EditForm.CheckSaveInformationProduct(name, producer, description, year, price);
            });

            Assert.IsNotNull(exception);
            Assert.AreEqual(expectedReturnValue, exception.Message);
        }

        [Test]
        public void T_008_SaveInformationProduct_NotPrice()
        {
            string name = "Product";
            string producer = "Producer";
            string description = "description of product description of product description of product description of product description of product description of product description of product";
            string year = "2024";
            string price = "19�9.29";

            string expectedReturnValue = ExceptionStrings.NotPrice;

            Exception? exception = Assert.Throws<Exception>(() =>
            {
                EditForm.CheckSaveInformationProduct(name, producer, description, year, price);
            });

            Assert.IsNotNull(exception);
            Assert.AreEqual(expectedReturnValue, exception.Message);
        }

        [Test]
        public void T_009_SaveInformationProduct_WrongYear()
        {
            string name = "Product";
            string producer = "Producer";
            string description = "description of product description of product description of product description of product description of product description of product description of product";
            string year = "2056";
            string price = "1999.29";

            string expectedReturnValue = ExceptionStrings.WrongYear;

            Exception? exception = Assert.Throws<Exception>(() =>
            {
                EditForm.CheckSaveInformationProduct(name, producer, description, year, price);
            });

            Assert.IsNotNull(exception);
            Assert.AreEqual(expectedReturnValue, exception.Message);
        }

        [Test]
        public void T_010_SaveInformationProduct_FullDescription()
        {
            string name = "Product";
            string producer = "Producer";
            string description = "description of product description of product description of product " +
                "description of product description of product description of product description of product " +
                "description of product description of product description of product description of product " +
                "description of product description of product description of product description of product " +
                "description of product description of product description of product";
            string year = "2056";
            string price = "1999.29";

            string expectedReturnValue = ExceptionStrings.FullDescription;

            Exception? exception = Assert.Throws<Exception>(() =>
            {
                EditForm.CheckSaveInformationProduct(name, producer, description, year, price);
            });

            Assert.IsNotNull(exception);
            Assert.AreEqual(expectedReturnValue, exception.Message);
        }

        [Test]
        public void TEST_011_OnMakeDockClick_BasicFlow()
        {
            string name = "Product";
            string producer = "Producer";
            string description = "description of product description of product description of product description of product description of product description of product description of product";
            string year = "2024";
            string price = "1999.29";

            EditForm editForm = new EditForm();
            editForm.controller = new DummyDBController_BasicFlow();
            IDocumentToPrint documentToPrint = null;

            Assert.DoesNotThrow(() =>
            {
                documentToPrint = editForm.OnMakeDockClick(name, producer, description, year, price);
            });
            Assert.IsNotNull (documentToPrint);
            Assert.AreEqual(documentToPrint.name, name);
            Assert.AreEqual (documentToPrint.description, description);
            Assert.AreEqual (documentToPrint.producer, producer);

        }

        [Test]
        public void TEST_012_OnMakeDockClick_NoConnectionDB()
        {
            string name = "Product";
            string producer = "Producer";
            string description = "description of product description of product description of product description of product description of product description of product description of product";
            string year = "2024";
            string price = "1999.29";

            string expectedExceptionMessage = ExceptionStrings.NoConnectionDB;

            EditForm editForm = new EditForm();
            editForm.controller = new DummyDBController_NoConnection();
            

            Exception?exception = Assert.Throws<Exception>(() =>
            {
                editForm.OnMakeDockClick(name,producer, description, year, price);
            });
            Assert.IsNotNull(exception);
            Assert.AreEqual(expectedExceptionMessage, exception.Message);

        }

        [Test]
        public void TEST_013_OnMakeDockClick_NoIDProduct()
        {
            string name = "Product";
            string producer = "Producer";
            string description = "description of product description of product description of product description of product description of product description of product description of product";
            string year = "2024";
            string price = "1999.29";

            string expectedExceptionMessage = ExceptionStrings.NoIDProduct;

            EditForm editForm = new EditForm();
            editForm.controller = new DummyDBController_NoProductID();


            Exception? exception = Assert.Throws<Exception>(() =>
            {
                editForm.OnMakeDockClick(name, producer, description, year, price);
            });
            Assert.IsNotNull(exception);
            Assert.AreEqual(expectedExceptionMessage, exception.Message);

        }

        [Test]
        public void TEST_014_OnMakeDockClick_NoSaveProduct()
        {
            string name = "Product";
            string producer = "Producer";
            string description = "description of product description of product description of product description of product description of product description of product description of product";
            string year = "2024";
            string price = "1999.29";

            string expectedExceptionMessage = ExceptionStrings.NoSaveProduct;

            EditForm editForm = new EditForm();
            editForm.controller = new DummyDBController_NoSaveProduct();


            Exception? exception = Assert.Throws<Exception>(() =>
            {
                editForm.OnMakeDockClick(name, producer, description, year, price);
            });
            Assert.IsNotNull(exception);
            Assert.AreEqual(expectedExceptionMessage, exception.Message);

        }

    }
}