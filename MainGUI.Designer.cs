namespace LibraryManagementSystem
{
    partial class MainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            groupBox1 = new GroupBox();
            buttonDeleteBook = new Button();
            buttonSearch = new Button();
            buttonClear = new Button();
            textBoxBookGenre = new TextBox();
            textBoxISBN = new TextBox();
            textBoxAuthorSurname = new TextBox();
            textBoxAuthorName = new TextBox();
            textBoxBookName = new TextBox();
            buttonAddNewBook = new Button();
            buttonUpdateBook = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labelBookId = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonLendBook = new Button();
            dateTimePickerLendingDate = new DateTimePicker();
            label9 = new Label();
            textBoxBarrower = new TextBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            buttonTakeBook = new Button();
            buttonCalculateFee = new Button();
            label12 = new Label();
            labelFee = new Label();
            label11 = new Label();
            groupBox4 = new GroupBox();
            dataGridViewBookList = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonDeleteBook);
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(textBoxBookGenre);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(textBoxAuthorSurname);
            groupBox1.Controls.Add(textBoxAuthorName);
            groupBox1.Controls.Add(textBoxBookName);
            groupBox1.Controls.Add(buttonAddNewBook);
            groupBox1.Controls.Add(buttonUpdateBook);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelBookId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 377);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Registration and Update";
            // 
            // buttonDeleteBook
            // 
            buttonDeleteBook.BackColor = Color.IndianRed;
            buttonDeleteBook.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteBook.Location = new Point(13, 323);
            buttonDeleteBook.Name = "buttonDeleteBook";
            buttonDeleteBook.Size = new Size(134, 48);
            buttonDeleteBook.TabIndex = 16;
            buttonDeleteBook.Text = "Delete the Book ";
            buttonDeleteBook.UseVisualStyleBackColor = false;
            buttonDeleteBook.Click += buttonDeleteBook_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Yellow;
            buttonSearch.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(340, 269);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(134, 48);
            buttonSearch.TabIndex = 15;
            buttonSearch.Text = "Search Book";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.IndianRed;
            buttonClear.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(340, 323);
            buttonClear.Name = "buttonClear";
            buttonClear.RightToLeft = RightToLeft.Yes;
            buttonClear.Size = new Size(134, 48);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // textBoxBookGenre
            // 
            textBoxBookGenre.Location = new Point(171, 218);
            textBoxBookGenre.Name = "textBoxBookGenre";
            textBoxBookGenre.Size = new Size(303, 23);
            textBoxBookGenre.TabIndex = 13;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(171, 182);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(303, 23);
            textBoxISBN.TabIndex = 12;
            // 
            // textBoxAuthorSurname
            // 
            textBoxAuthorSurname.Location = new Point(171, 143);
            textBoxAuthorSurname.Name = "textBoxAuthorSurname";
            textBoxAuthorSurname.Size = new Size(303, 23);
            textBoxAuthorSurname.TabIndex = 11;
            // 
            // textBoxAuthorName
            // 
            textBoxAuthorName.Location = new Point(171, 105);
            textBoxAuthorName.Name = "textBoxAuthorName";
            textBoxAuthorName.Size = new Size(303, 23);
            textBoxAuthorName.TabIndex = 10;
            // 
            // textBoxBookName
            // 
            textBoxBookName.Location = new Point(171, 67);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new Size(303, 23);
            textBoxBookName.TabIndex = 9;
            // 
            // buttonAddNewBook
            // 
            buttonAddNewBook.BackColor = Color.LimeGreen;
            buttonAddNewBook.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddNewBook.Location = new Point(171, 323);
            buttonAddNewBook.Name = "buttonAddNewBook";
            buttonAddNewBook.Size = new Size(134, 48);
            buttonAddNewBook.TabIndex = 8;
            buttonAddNewBook.Text = "Add New Book";
            buttonAddNewBook.UseVisualStyleBackColor = false;
            buttonAddNewBook.Click += buttonAddNewBook_Click;
            // 
            // buttonUpdateBook
            // 
            buttonUpdateBook.BackColor = Color.SandyBrown;
            buttonUpdateBook.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdateBook.Location = new Point(13, 269);
            buttonUpdateBook.Name = "buttonUpdateBook";
            buttonUpdateBook.Size = new Size(134, 48);
            buttonUpdateBook.TabIndex = 7;
            buttonUpdateBook.Text = "Update the Book ";
            buttonUpdateBook.UseVisualStyleBackColor = false;
            buttonUpdateBook.Click += buttonUpdateBook_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label7.Location = new Point(13, 218);
            label7.Name = "label7";
            label7.Size = new Size(120, 22);
            label7.TabIndex = 6;
            label7.Text = "Book Genre :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label6.Location = new Point(13, 183);
            label6.Name = "label6";
            label6.Size = new Size(65, 22);
            label6.TabIndex = 5;
            label6.Text = "ISBN :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label5.Location = new Point(13, 143);
            label5.Name = "label5";
            label5.Size = new Size(155, 22);
            label5.TabIndex = 4;
            label5.Text = "Author Surname :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label4.Location = new Point(13, 105);
            label4.Name = "label4";
            label4.Size = new Size(130, 22);
            label4.TabIndex = 3;
            label4.Text = "Author Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label3.Location = new Point(13, 67);
            label3.Name = "label3";
            label3.Size = new Size(117, 22);
            label3.TabIndex = 2;
            label3.Text = "Book Name :";
            // 
            // labelBookId
            // 
            labelBookId.AutoSize = true;
            labelBookId.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            labelBookId.Location = new Point(171, 36);
            labelBookId.Name = "labelBookId";
            labelBookId.Size = new Size(16, 22);
            labelBookId.TabIndex = 1;
            labelBookId.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label1.Location = new Point(13, 36);
            label1.Name = "label1";
            label1.Size = new Size(90, 22);
            label1.TabIndex = 0;
            label1.Text = "Book ID :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonLendBook);
            groupBox2.Controls.Add(dateTimePickerLendingDate);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBoxBarrower);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(505, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 377);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Book Lend";
            // 
            // buttonLendBook
            // 
            buttonLendBook.BackColor = Color.SandyBrown;
            buttonLendBook.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLendBook.Location = new Point(68, 323);
            buttonLendBook.Name = "buttonLendBook";
            buttonLendBook.Size = new Size(134, 48);
            buttonLendBook.TabIndex = 13;
            buttonLendBook.Text = "Lend the Book";
            buttonLendBook.UseVisualStyleBackColor = false;
            buttonLendBook.Click += buttonLendBook_Click;
            // 
            // dateTimePickerLendingDate
            // 
            dateTimePickerLendingDate.CustomFormat = "d MMMM yyyy";
            dateTimePickerLendingDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerLendingDate.Location = new Point(107, 85);
            dateTimePickerLendingDate.Name = "dateTimePickerLendingDate";
            dateTimePickerLendingDate.Size = new Size(133, 23);
            dateTimePickerLendingDate.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label9.Location = new Point(6, 86);
            label9.Name = "label9";
            label9.Size = new Size(59, 22);
            label9.TabIndex = 11;
            label9.Text = "Date :";
            // 
            // textBoxBarrower
            // 
            textBoxBarrower.Location = new Point(107, 40);
            textBoxBarrower.Name = "textBoxBarrower";
            textBoxBarrower.Size = new Size(133, 23);
            textBoxBarrower.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label8.Location = new Point(6, 38);
            label8.Name = "label8";
            label8.Size = new Size(105, 22);
            label8.TabIndex = 1;
            label8.Text = "Barrower : ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonTakeBook);
            groupBox3.Controls.Add(buttonCalculateFee);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(labelFee);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(772, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 377);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Book Taking Back";
            // 
            // buttonTakeBook
            // 
            buttonTakeBook.BackColor = Color.LimeGreen;
            buttonTakeBook.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTakeBook.Location = new Point(64, 323);
            buttonTakeBook.Name = "buttonTakeBook";
            buttonTakeBook.Size = new Size(134, 48);
            buttonTakeBook.TabIndex = 10;
            buttonTakeBook.Text = "Take the Book";
            buttonTakeBook.UseVisualStyleBackColor = false;
            buttonTakeBook.Click += buttonTakeBook_Click;
            // 
            // buttonCalculateFee
            // 
            buttonCalculateFee.BackColor = Color.IndianRed;
            buttonCalculateFee.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCalculateFee.Location = new Point(64, 243);
            buttonCalculateFee.Name = "buttonCalculateFee";
            buttonCalculateFee.Size = new Size(134, 48);
            buttonCalculateFee.TabIndex = 9;
            buttonCalculateFee.Text = "Calculate Delay Fee";
            buttonCalculateFee.UseVisualStyleBackColor = false;
            buttonCalculateFee.Click += buttonCalculateFee_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label12.Location = new Point(174, 41);
            label12.Name = "label12";
            label12.Size = new Size(48, 22);
            label12.TabIndex = 4;
            label12.Text = "USD";
            // 
            // labelFee
            // 
            labelFee.AutoSize = true;
            labelFee.BackColor = SystemColors.ButtonFace;
            labelFee.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            labelFee.ForeColor = Color.IndianRed;
            labelFee.Location = new Point(148, 41);
            labelFee.Name = "labelFee";
            labelFee.Size = new Size(20, 22);
            labelFee.TabIndex = 3;
            labelFee.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label11.Location = new Point(6, 41);
            label11.Name = "label11";
            label11.Size = new Size(136, 22);
            label11.TabIndex = 2;
            label11.Text = "Price of Delay :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewBookList);
            groupBox4.Location = new Point(12, 416);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1006, 175);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Book List";
            // 
            // dataGridViewBookList
            // 
            dataGridViewBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookList.Dock = DockStyle.Fill;
            dataGridViewBookList.Location = new Point(3, 19);
            dataGridViewBookList.Name = "dataGridViewBookList";
            dataGridViewBookList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewBookList.Size = new Size(1000, 153);
            dataGridViewBookList.TabIndex = 0;
            dataGridViewBookList.CellClick += dataGridViewBookList_CellClick;
            // 
            // MainGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 603);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainGUI";
            Text = "Library Management System";
            FormClosed += MainGUI_FormClosed;
            Load += MainGUI_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelBookId;
        private Label label1;
        private Label label7;
        private Label label6;
        private Button buttonAddNewBook;
        private Button buttonUpdateBook;
        private TextBox textBoxBookName;
        private TextBox textBoxBookGenre;
        private TextBox textBoxISBN;
        private TextBox textBoxAuthorSurname;
        private TextBox textBoxAuthorName;
        private Label label9;
        private TextBox textBoxBarrower;
        private Label label8;
        private Button buttonLendBook;
        private DateTimePicker dateTimePickerLendingDate;
        private Label label12;
        private Label labelFee;
        private Label label11;
        private Button buttonTakeBook;
        private Button buttonCalculateFee;
        private DataGridView dataGridViewBookList;
        private Button buttonSearch;
        private Button buttonClear;
        private Button buttonDeleteBook;
    }
}