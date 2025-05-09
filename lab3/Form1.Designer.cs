namespace lab3
{
    partial class Form1
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SaveButton = new Button();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(pictureBox2, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 3);
            tableLayoutPanel1.Controls.Add(SaveButton, 1, 6);
            tableLayoutPanel1.Controls.Add(maskedTextBox1, 1, 5);
            tableLayoutPanel1.Controls.Add(maskedTextBox2, 1, 4);
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
            // label1
            // 
            label1.BackColor = Color.Gainsboro;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 60);
            label1.TabIndex = 1;
            label1.Text = "Назад";
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
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(63, 63);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 64);
            textBox1.TabIndex = 3;
            textBox1.Text = "Название товара";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(63, 133);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 104);
            textBox2.TabIndex = 4;
            textBox2.Text = "Описание товара описание товара описание товара";
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Bottom;
            textBox3.Location = new Point(63, 243);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(309, 54);
            textBox3.TabIndex = 5;
            textBox3.Text = "Производитель";
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
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Dock = DockStyle.Bottom;
            maskedTextBox1.Location = new Point(63, 390);
            maskedTextBox1.Mask = "0000.00 $";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(309, 27);
            maskedTextBox1.TabIndex = 9;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Dock = DockStyle.Bottom;
            maskedTextBox2.Location = new Point(63, 330);
            maskedTextBox2.Mask = "0000 г/";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(309, 27);
            maskedTextBox2.TabIndex = 10;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 744);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "EditForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button SaveButton;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
    }
}
