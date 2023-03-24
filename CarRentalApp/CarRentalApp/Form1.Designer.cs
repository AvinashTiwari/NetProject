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
            tbCost = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Matura MT Script Capitals", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(149, 12);
            label1.Name = "label1";
            label1.Size = new Size(559, 79);
            label1.TabIndex = 0;
            label1.Text = "Car Rental System";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(58, 160);
            tbCustomerName.Margin = new Padding(3, 4, 3, 4);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(201, 27);
            tbCustomerName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 129);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 3;
            label3.Text = "Customer Name";
            // 
            // dtRented
            // 
            dtRented.Location = new Point(58, 267);
            dtRented.Margin = new Padding(3, 4, 3, 4);
            dtRented.Name = "dtRented";
            dtRented.Size = new Size(228, 27);
            dtRented.TabIndex = 4;
            // 
            // dtReturned
            // 
            dtReturned.Location = new Point(365, 267);
            dtReturned.Margin = new Padding(3, 4, 3, 4);
            dtReturned.Name = "dtReturned";
            dtReturned.Size = new Size(228, 27);
            dtReturned.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(58, 237);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 6;
            label2.Text = "Date Rented";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(401, 237);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 7;
            label4.Text = "Date Returned";
            // 
            // cbTypeOfCar
            // 
            cbTypeOfCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeOfCar.FormattingEnabled = true;
            cbTypeOfCar.Items.AddRange(new object[] { "Honda", "Toyota", "Lada", "Buggy", "Maruti" });
            cbTypeOfCar.Location = new Point(58, 352);
            cbTypeOfCar.Name = "cbTypeOfCar";
            cbTypeOfCar.Size = new Size(228, 28);
            cbTypeOfCar.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(58, 324);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 9;
            label5.Text = "Type Of Car";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Matura MT Script Capitals", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.Location = new Point(377, 315);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(216, 77);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbCost
            // 
            tbCost.Location = new Point(434, 160);
            tbCost.Name = "tbCost";
            tbCost.Size = new Size(201, 27);
            tbCost.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(439, 129);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 12;
            label6.Text = "Cost";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label6);
            Controls.Add(tbCost);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox tbCost;
        private Label label6;
    }
}