namespace MyGameStore.Forms
{
    partial class updateClientForm
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
            SignUpButton = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            textBoxBirth = new System.Windows.Forms.MaskedTextBox();
            textBoxPhone = new System.Windows.Forms.MaskedTextBox();
            textBoxAddress = new System.Windows.Forms.TextBox();
            textBoxPassword = new System.Windows.Forms.TextBox();
            textBoxLogin = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new System.Drawing.Point(287, 140);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new System.Drawing.Size(75, 23);
            SignUpButton.TabIndex = 35;
            SignUpButton.Text = "Обновить";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(276, 62);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(65, 15);
            label6.TabIndex = 34;
            label6.Text = "BIRTHDATE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(276, 4);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 15);
            label5.TabIndex = 33;
            label5.Text = "PHONE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 123);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 15);
            label3.TabIndex = 32;
            label3.Text = "ADDRESS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 15);
            label2.TabIndex = 31;
            label2.Text = "PASSWORD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 30;
            label1.Text = "LOGIN:";
            // 
            // textBoxBirth
            // 
            textBoxBirth.Location = new System.Drawing.Point(276, 80);
            textBoxBirth.Mask = "00/00/0000";
            textBoxBirth.Name = "textBoxBirth";
            textBoxBirth.Size = new System.Drawing.Size(100, 23);
            textBoxBirth.TabIndex = 29;
            textBoxBirth.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new System.Drawing.Point(276, 22);
            textBoxPhone.Mask = "(999) 000-0000";
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new System.Drawing.Size(100, 23);
            textBoxPhone.TabIndex = 28;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new System.Drawing.Point(12, 141);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new System.Drawing.Size(100, 23);
            textBoxAddress.TabIndex = 27;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new System.Drawing.Point(12, 80);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new System.Drawing.Size(100, 23);
            textBoxPassword.TabIndex = 26;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new System.Drawing.Point(12, 22);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new System.Drawing.Size(100, 23);
            textBoxLogin.TabIndex = 25;
            // 
            // updateClientForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(390, 177);
            Controls.Add(SignUpButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxBirth);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Name = "updateClientForm";
            Text = "updateClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox textBoxBirth;
        public System.Windows.Forms.MaskedTextBox textBoxPhone;
        public System.Windows.Forms.TextBox textBoxAddress;
        public System.Windows.Forms.TextBox textBoxPassword;
        public System.Windows.Forms.TextBox textBoxLogin;
    }
}