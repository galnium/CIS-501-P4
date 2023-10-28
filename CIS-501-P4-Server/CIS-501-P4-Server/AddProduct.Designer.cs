namespace CIS_501_P4_Server
{
    partial class AddProduct
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
            this.uxProductList = new System.Windows.Forms.ListBox();
            this.uxAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxProductList
            // 
            this.uxProductList.FormattingEnabled = true;
            this.uxProductList.Location = new System.Drawing.Point(12, 12);
            this.uxProductList.Name = "uxProductList";
            this.uxProductList.Size = new System.Drawing.Size(196, 238);
            this.uxProductList.TabIndex = 0;
            // 
            // uxAdd
            // 
            this.uxAdd.Location = new System.Drawing.Point(12, 256);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(196, 44);
            this.uxAdd.TabIndex = 1;
            this.uxAdd.Text = "Add Item";
            this.uxAdd.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 309);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxProductList);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxProductList;
        private System.Windows.Forms.Button uxAdd;
    }
}