namespace EFTraining2.Forms
{
    partial class SearchUserForm
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
            button1 = new Button();
            textBoxSearch = new TextBox();
            labelFullName = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(63, 114);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(49, 45);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(150, 31);
            textBoxSearch.TabIndex = 1;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(291, 48);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(0, 25);
            labelFullName.TabIndex = 2;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(291, 93);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(0, 25);
            labelPhone.TabIndex = 2;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(291, 142);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(0, 25);
            labelEmail.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 245);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 2;
            // 
            // SearchUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 523);
            Controls.Add(label5);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelFullName);
            Controls.Add(textBoxSearch);
            Controls.Add(button1);
            Name = "SearchUserForm";
            Text = "SearchUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxSearch;
        private Label labelFullName;
        private Label labelPhone;
        private Label labelEmail;
        private Label label5;
    }
}