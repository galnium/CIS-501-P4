namespace CIS_501_P4_Server
{
    partial class Form1
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
            this.uxItemList = new System.Windows.Forms.ListBox();
            this.uxClientList = new System.Windows.Forms.ListBox();
            this.uxAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxItemList
            // 
            this.uxItemList.FormattingEnabled = true;
            this.uxItemList.Location = new System.Drawing.Point(12, 12);
            this.uxItemList.Name = "uxItemList";
            this.uxItemList.Size = new System.Drawing.Size(207, 342);
            this.uxItemList.TabIndex = 0;
            // 
            // uxClientList
            // 
            this.uxClientList.FormattingEnabled = true;
            this.uxClientList.Location = new System.Drawing.Point(225, 12);
            this.uxClientList.Name = "uxClientList";
            this.uxClientList.Size = new System.Drawing.Size(207, 342);
            this.uxClientList.TabIndex = 1;
            // 
            // uxAddProduct
            // 
            this.uxAddProduct.Location = new System.Drawing.Point(12, 360);
            this.uxAddProduct.Name = "uxAddProduct";
            this.uxAddProduct.Size = new System.Drawing.Size(420, 52);
            this.uxAddProduct.TabIndex = 2;
            this.uxAddProduct.Text = "Add Product";
            this.uxAddProduct.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 423);
            this.Controls.Add(this.uxAddProduct);
            this.Controls.Add(this.uxClientList);
            this.Controls.Add(this.uxItemList);
            this.Name = "Form1";
            this.Text = "Server Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxItemList;
        private System.Windows.Forms.ListBox uxClientList;
        private System.Windows.Forms.Button uxAddProduct;
    }
}

