namespace lab3
{
    partial class EditForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            textBoxProducer = new TextBox();
            SaveButton = new Button();
            TextBoxPrice = new MaskedTextBox();
            TextBoxYear = new MaskedTextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 2, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxName, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxDescription, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxProducer, 1, 3);
            tableLayoutPanel1.Controls.Add(SaveButton, 1, 6);
            tableLayoutPanel1.Controls.Add(TextBoxPrice, 1, 5);
            tableLayoutPanel1.Controls.Add(TextBoxYear, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(435, 744);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gainsboro;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 54);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gainsboro;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(378, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 54);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gainsboro;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(63, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 54);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Fill;
            textBoxName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.Location = new Point(63, 63);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(309, 64);
            textBoxName.TabIndex = 3;
            textBoxName.Text = "Название товара";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(63, 133);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(309, 104);
            textBoxDescription.TabIndex = 4;
            textBoxDescription.Text = "Описание товара описание товара описание товара";
            // 
            // textBoxProducer
            // 
            textBoxProducer.Dock = DockStyle.Bottom;
            textBoxProducer.Location = new Point(63, 243);
            textBoxProducer.Multiline = true;
            textBoxProducer.Name = "textBoxProducer";
            textBoxProducer.Size = new Size(309, 54);
            textBoxProducer.TabIndex = 5;
            textBoxProducer.Text = "Производитель";
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaveButton.BackColor = Color.DodgerBlue;
            SaveButton.BackgroundImageLayout = ImageLayout.Center;
            SaveButton.FlatStyle = FlatStyle.Popup;
            SaveButton.Font = new Font("Franklin Gothic Book", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveButton.ForeColor = SystemColors.ButtonHighlight;
            SaveButton.Location = new Point(63, 513);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(309, 54);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // TextBoxPrice
            // 
            TextBoxPrice.Dock = DockStyle.Bottom;
            TextBoxPrice.Location = new Point(63, 390);
            TextBoxPrice.Mask = "0000/00 $";
            TextBoxPrice.Name = "TextBoxPrice";
            TextBoxPrice.Size = new Size(309, 27);
            TextBoxPrice.TabIndex = 9;
            TextBoxPrice.Text = "199929";
            // 
            // TextBoxYear
            // 
            TextBoxYear.Dock = DockStyle.Bottom;
            TextBoxYear.Location = new Point(63, 330);
            TextBoxYear.Mask = "0000 г/";
            TextBoxYear.Name = "TextBoxYear";
            TextBoxYear.Size = new Size(309, 27);
            TextBoxYear.TabIndex = 10;
            TextBoxYear.Text = "2024";
            TextBoxYear.ValidatingType = typeof(DateTime);
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 744);
            Controls.Add(tableLayoutPanel1);
            Name = "EditForm";
            Text = "EditForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion




        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private TextBox textBoxProducer;
        private Button SaveButton;
        private MaskedTextBox TextBoxPrice;
        private MaskedTextBox TextBoxYear;
        private PictureBox pictureBox3;
    }
}
