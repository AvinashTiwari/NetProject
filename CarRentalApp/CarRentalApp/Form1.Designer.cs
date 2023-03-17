namespace CarRentalApp
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
            label1 = new Label();
            tbCustomerName = new TextBox();
            label3 = new Label();
            dtRented = new DateTimePicker();
            dtReturned = new DateTimePicker();
            label2 = new Label();
            label4 = new Label();
            cbTypeOfCar = new ComboBox();
            label5 = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Matura MT Script Capitals", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(130, 9);
            label1.Name = "label1";
            label1.Size = new Size(453, 64);
            label1.TabIndex = 0;
            label1.Text = "Car Rental System";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(51, 120);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(176, 23);
            tbCustomerName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 97);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 3;
            label3.Text = "Customer Name";
            // 
            // dtRented
            // 
            dtRented.Location = new Point(51, 200);
            dtRented.Name = "dtRented";
            dtRented.Size = new Size(200, 23);
            dtRented.TabIndex = 4;
            // 
            // dtReturned
            // 
            dtReturned.Location = new Point(319, 200);
            dtReturned.Name = "dtReturned";
            dtReturned.Size = new Size(200, 23);
            dtReturned.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 178);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 6;
            label2.Text = "Date Rented";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(351, 178);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 7;
            label4.Text = "Date Returned";
            // 
            // cbTypeOfCar
            // 
            cbTypeOfCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeOfCar.FormattingEnabled = true;
            cbTypeOfCar.Items.AddRange(new object[] { "Honda", "Toyota", "Lada", "Buggy", "Maruti" });
            cbTypeOfCar.Location = new Point(51, 264);
            cbTypeOfCar.Margin = new Padding(3, 2, 3, 2);
            cbTypeOfCar.Name = "cbTypeOfCar";
            cbTypeOfCar.Size = new Size(200, 23);
            cbTypeOfCar.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(51, 243);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 9;
            label5.Text = "Type Of Car";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Matura MT Script Capitals", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.Location = new Point(330, 236);
            btnSubmit.Margin = new Padding(3, 2, 3, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(189, 58);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(label5);
            Controls.Add(cbTypeOfCar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dtReturned);
            Controls.Add(dtRented);
            Controls.Add(label3);
            Controls.Add(tbCustomerName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbCustomerName;
        private Label label3;
        private DateTimePicker dtRented;
        private DateTimePicker dtReturned;
        private Label label2;
        private Label label4;
        private ComboBox cbTypeOfCar;
        private Label label5;
        private Button btnSubmit;
    }
}