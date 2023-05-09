namespace EFTraining2
{
    partial class NewUserForm
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
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            buttonRegister = new Button();
            labelFirstName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelCity = new Label();
            cmbCities = new ComboBox();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(665, 93);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(150, 31);
            textBoxFirstName.TabIndex = 10;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(665, 150);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(150, 31);
            textBoxLastName.TabIndex = 11;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(665, 211);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(150, 31);
            textBoxPhone.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(998, 96);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(150, 31);
            textBoxEmail.TabIndex = 13;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(998, 158);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(150, 31);
            textBoxPassword.TabIndex = 14;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(704, 272);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(225, 34);
            buttonRegister.TabIndex = 1;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click_1;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(530, 99);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(97, 25);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(530, 156);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 2;
            label1.Text = "LastName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(530, 211);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 2;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(863, 99);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(863, 161);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(863, 211);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(42, 25);
            labelCity.TabIndex = 2;
            labelCity.Text = "City";
            // 
            // cmbCities
            // 
            cmbCities.FormattingEnabled = true;
            cmbCities.Location = new Point(998, 221);
            cmbCities.Name = "cmbCities";
            cmbCities.Size = new Size(150, 33);
            cmbCities.TabIndex = 15;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.human;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1199, 717);
            Controls.Add(cmbCities);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelCity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelFirstName);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Name = "NewUserForm";
            Text = "New User Form";
            Load += NewUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button buttonRegister;
        private Label labelFirstName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelCity;
        private ComboBox cmbCities;
    }
}