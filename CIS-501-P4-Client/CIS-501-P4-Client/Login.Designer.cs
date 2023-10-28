namespace CIS_501_P4_Client
{
    partial class Login
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
            this.uxUserBox = new System.Windows.Forms.TextBox();
            this.uxPassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxUserBox
            // 
            this.uxUserBox.Location = new System.Drawing.Point(81, 9);
            this.uxUserBox.Name = "uxUserBox";
            this.uxUserBox.Size = new System.Drawing.Size(145, 20);
            this.uxUserBox.TabIndex = 0;
            // 
            // uxPassBox
            // 
            this.uxPassBox.Location = new System.Drawing.Point(81, 42);
            this.uxPassBox.Name = "uxPassBox";
            this.uxPassBox.PasswordChar = '*';
            this.uxPassBox.Size = new System.Drawing.Size(145, 20);
            this.uxPassBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // uxStatus
            // 
            this.uxStatus.Location = new System.Drawing.Point(12, 65);
            this.uxStatus.Name = "uxStatus";
            this.uxStatus.Size = new System.Drawing.Size(214, 22);
            this.uxStatus.TabIndex = 3;
            this.uxStatus.Text = "Temp Status";
            this.uxStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // uxLoginButton
            // 
            this.uxLoginButton.Location = new System.Drawing.Point(15, 90);
            this.uxLoginButton.Name = "uxLoginButton";
            this.uxLoginButton.Size = new System.Drawing.Size(211, 33);
            this.uxLoginButton.TabIndex = 5;
            this.uxLoginButton.Text = "Login";
            this.uxLoginButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 135);
            this.Controls.Add(this.uxLoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPassBox);
            this.Controls.Add(this.uxUserBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxUserBox;
        private System.Windows.Forms.TextBox uxPassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uxLoginButton;
    }
}

