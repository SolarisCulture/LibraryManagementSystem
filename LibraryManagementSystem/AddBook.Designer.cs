namespace LibraryManagementSystem
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.Label();
            this.bookAuthorName = new System.Windows.Forms.Label();
            this.bookPublication = new System.Windows.Forms.Label();
            this.bookPurchaseDate = new System.Windows.Forms.Label();
            this.bookPrise = new System.Windows.Forms.Label();
            this.bookQuantity = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtbookAuthorName = new System.Windows.Forms.TextBox();
            this.txtBookPublication = new System.Windows.Forms.TextBox();
            this.txtbookPrise = new System.Windows.Forms.TextBox();
            this.txtbookQuantity = new System.Windows.Forms.TextBox();
            this.txtPookPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-7, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 312);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-7, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 74);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtPookPurchaseDate);
            this.panel2.Controls.Add(this.txtbookQuantity);
            this.panel2.Controls.Add(this.txtbookPrise);
            this.panel2.Controls.Add(this.txtBookPublication);
            this.panel2.Controls.Add(this.txtbookAuthorName);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Controls.Add(this.bookQuantity);
            this.panel2.Controls.Add(this.bookPrise);
            this.panel2.Controls.Add(this.bookPurchaseDate);
            this.panel2.Controls.Add(this.bookPublication);
            this.panel2.Controls.Add(this.bookAuthorName);
            this.panel2.Controls.Add(this.bookName);
            this.panel2.Location = new System.Drawing.Point(180, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 312);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Book";
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.Location = new System.Drawing.Point(19, 35);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(92, 20);
            this.bookName.TabIndex = 0;
            this.bookName.Text = "Book Name";
            // 
            // bookAuthorName
            // 
            this.bookAuthorName.AutoSize = true;
            this.bookAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAuthorName.Location = new System.Drawing.Point(19, 77);
            this.bookAuthorName.Name = "bookAuthorName";
            this.bookAuthorName.Size = new System.Drawing.Size(144, 20);
            this.bookAuthorName.TabIndex = 1;
            this.bookAuthorName.Text = "Book Author Name";
            // 
            // bookPublication
            // 
            this.bookPublication.AutoSize = true;
            this.bookPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPublication.Location = new System.Drawing.Point(19, 119);
            this.bookPublication.Name = "bookPublication";
            this.bookPublication.Size = new System.Drawing.Size(127, 20);
            this.bookPublication.TabIndex = 2;
            this.bookPublication.Text = "Book Publication";
            // 
            // bookPurchaseDate
            // 
            this.bookPurchaseDate.AutoSize = true;
            this.bookPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPurchaseDate.Location = new System.Drawing.Point(19, 161);
            this.bookPurchaseDate.Name = "bookPurchaseDate";
            this.bookPurchaseDate.Size = new System.Drawing.Size(156, 20);
            this.bookPurchaseDate.TabIndex = 3;
            this.bookPurchaseDate.Text = "Book Purchase Date";
            // 
            // bookPrise
            // 
            this.bookPrise.AutoSize = true;
            this.bookPrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPrise.Location = new System.Drawing.Point(19, 203);
            this.bookPrise.Name = "bookPrise";
            this.bookPrise.Size = new System.Drawing.Size(85, 20);
            this.bookPrise.TabIndex = 4;
            this.bookPrise.Text = "Book Prise";
            // 
            // bookQuantity
            // 
            this.bookQuantity.AutoSize = true;
            this.bookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookQuantity.Location = new System.Drawing.Point(19, 245);
            this.bookQuantity.Name = "bookQuantity";
            this.bookQuantity.Size = new System.Drawing.Size(109, 20);
            this.bookQuantity.TabIndex = 5;
            this.bookQuantity.Text = "Book Quantity";
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(184, 30);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(209, 25);
            this.txtBookName.TabIndex = 6;
            // 
            // txtbookAuthorName
            // 
            this.txtbookAuthorName.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookAuthorName.Location = new System.Drawing.Point(184, 72);
            this.txtbookAuthorName.Name = "txtbookAuthorName";
            this.txtbookAuthorName.Size = new System.Drawing.Size(209, 25);
            this.txtbookAuthorName.TabIndex = 7;
            // 
            // txtBookPublication
            // 
            this.txtBookPublication.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPublication.Location = new System.Drawing.Point(184, 114);
            this.txtBookPublication.Name = "txtBookPublication";
            this.txtBookPublication.Size = new System.Drawing.Size(209, 25);
            this.txtBookPublication.TabIndex = 8;
            // 
            // txtbookPrise
            // 
            this.txtbookPrise.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookPrise.Location = new System.Drawing.Point(184, 198);
            this.txtbookPrise.Name = "txtbookPrise";
            this.txtbookPrise.Size = new System.Drawing.Size(209, 25);
            this.txtbookPrise.TabIndex = 9;
            // 
            // txtbookQuantity
            // 
            this.txtbookQuantity.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookQuantity.Location = new System.Drawing.Point(184, 240);
            this.txtbookQuantity.Name = "txtbookQuantity";
            this.txtbookQuantity.Size = new System.Drawing.Size(209, 25);
            this.txtbookQuantity.TabIndex = 10;
            // 
            // txtPookPurchaseDate
            // 
            this.txtPookPurchaseDate.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPookPurchaseDate.Location = new System.Drawing.Point(184, 156);
            this.txtPookPurchaseDate.Name = "txtPookPurchaseDate";
            this.txtPookPurchaseDate.Size = new System.Drawing.Size(209, 25);
            this.txtPookPurchaseDate.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(161, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 33);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(275, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 33);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbookQuantity;
        private System.Windows.Forms.TextBox txtbookPrise;
        private System.Windows.Forms.TextBox txtBookPublication;
        private System.Windows.Forms.TextBox txtbookAuthorName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label bookQuantity;
        private System.Windows.Forms.Label bookPrise;
        private System.Windows.Forms.Label bookPurchaseDate;
        private System.Windows.Forms.Label bookPublication;
        private System.Windows.Forms.Label bookAuthorName;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.DateTimePicker txtPookPurchaseDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}