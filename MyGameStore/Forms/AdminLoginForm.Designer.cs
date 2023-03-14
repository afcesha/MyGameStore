namespace MyGameStore.Forms
{
    partial class AdminLoginForm
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
            AdminLoginButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            textBoxPasswordAdm = new System.Windows.Forms.TextBox();
            textBoxLoginAdm = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // AdminLoginButton
            // 
            AdminLoginButton.Location = new System.Drawing.Point(329, 273);
            AdminLoginButton.Name = "AdminLoginButton";
            AdminLoginButton.Size = new System.Drawing.Size(134, 29);
            AdminLoginButton.TabIndex = 9;
            AdminLoginButton.Text = "Welcome, Admin";
            AdminLoginButton.UseVisualStyleBackColor = true;
            AdminLoginButton.Click += AdminLoginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(350, 196);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 15);
            label2.TabIndex = 8;
            label2.Text = "PASSWORD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(350, 145);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 7;
            label1.Text = "LOGIN:";
            // 
            // textBoxPasswordAdm
            // 
            textBoxPasswordAdm.Location = new System.Drawing.Point(350, 214);
            textBoxPasswordAdm.Name = "textBoxPasswordAdm";
            textBoxPasswordAdm.Size = new System.Drawing.Size(100, 23);
            textBoxPasswordAdm.TabIndex = 6;
            // 
            // textBoxLoginAdm
            // 
            textBoxLoginAdm.Location = new System.Drawing.Point(350, 163);
            textBoxLoginAdm.Name = "textBoxLoginAdm";
            textBoxLoginAdm.Size = new System.Drawing.Size(100, 23);
            textBoxLoginAdm.TabIndex = 5;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(AdminLoginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPasswordAdm);
            Controls.Add(textBoxLoginAdm);
            Name = "AdminLoginForm";
            Text = "AdminLoginForm";
            Load += AdminLoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button AdminLoginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPasswordAdm;
        private System.Windows.Forms.TextBox textBoxLoginAdm;
    }
}