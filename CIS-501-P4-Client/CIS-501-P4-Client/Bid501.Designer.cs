namespace CIS_501_P4_Client
{
    partial class Bid501
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
            this.uxProductLabel = new System.Windows.Forms.Label();
            this.uxSelectedProductName = new System.Windows.Forms.Label();
            this.uxSelectedProductTime = new System.Windows.Forms.Label();
            this.uxStatusLabel = new System.Windows.Forms.Label();
            this.uxBidInput = new System.Windows.Forms.TextBox();
            this.uxSelectedMinBid = new System.Windows.Forms.Label();
            this.uxPlaceBid = new System.Windows.Forms.Button();
            this.uxItemList = new System.Windows.Forms.ListBox();
            this.uxNumOfBids = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxProductLabel
            // 
            this.uxProductLabel.Location = new System.Drawing.Point(205, 1);
            this.uxProductLabel.Name = "uxProductLabel";
            this.uxProductLabel.Size = new System.Drawing.Size(175, 21);
            this.uxProductLabel.TabIndex = 0;
            this.uxProductLabel.Text = "Products";
            this.uxProductLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxSelectedProductName
            // 
            this.uxSelectedProductName.Location = new System.Drawing.Point(12, 25);
            this.uxSelectedProductName.Name = "uxSelectedProductName";
            this.uxSelectedProductName.Size = new System.Drawing.Size(187, 16);
            this.uxSelectedProductName.TabIndex = 1;
            this.uxSelectedProductName.Text = "Temp Product Name";
            // 
            // uxSelectedProductTime
            // 
            this.uxSelectedProductTime.Location = new System.Drawing.Point(12, 53);
            this.uxSelectedProductTime.Name = "uxSelectedProductTime";
            this.uxSelectedProductTime.Size = new System.Drawing.Size(187, 16);
            this.uxSelectedProductTime.TabIndex = 2;
            this.uxSelectedProductTime.Text = "0 d, 0 hr, 0 min left";
            // 
            // uxStatusLabel
            // 
            this.uxStatusLabel.Location = new System.Drawing.Point(12, 78);
            this.uxStatusLabel.Name = "uxStatusLabel";
            this.uxStatusLabel.Size = new System.Drawing.Size(42, 16);
            this.uxStatusLabel.TabIndex = 3;
            this.uxStatusLabel.Text = "Status:";
            // 
            // uxBidInput
            // 
            this.uxBidInput.Location = new System.Drawing.Point(15, 137);
            this.uxBidInput.Name = "uxBidInput";
            this.uxBidInput.Size = new System.Drawing.Size(106, 20);
            this.uxBidInput.TabIndex = 4;
            // 
            // uxSelectedMinBid
            // 
            this.uxSelectedMinBid.Location = new System.Drawing.Point(12, 107);
            this.uxSelectedMinBid.Name = "uxSelectedMinBid";
            this.uxSelectedMinBid.Size = new System.Drawing.Size(184, 16);
            this.uxSelectedMinBid.TabIndex = 5;
            this.uxSelectedMinBid.Text = "Min Bid: $0.00";
            // 
            // uxPlaceBid
            // 
            this.uxPlaceBid.Location = new System.Drawing.Point(12, 173);
            this.uxPlaceBid.Name = "uxPlaceBid";
            this.uxPlaceBid.Size = new System.Drawing.Size(184, 38);
            this.uxPlaceBid.TabIndex = 6;
            this.uxPlaceBid.Text = "Place Bid";
            this.uxPlaceBid.UseVisualStyleBackColor = true;
            // 
            // uxItemList
            // 
            this.uxItemList.FormattingEnabled = true;
            this.uxItemList.Location = new System.Drawing.Point(205, 25);
            this.uxItemList.Name = "uxItemList";
            this.uxItemList.Size = new System.Drawing.Size(175, 186);
            this.uxItemList.TabIndex = 7;
            // 
            // uxNumOfBids
            // 
            this.uxNumOfBids.Location = new System.Drawing.Point(127, 140);
            this.uxNumOfBids.Name = "uxNumOfBids";
            this.uxNumOfBids.Size = new System.Drawing.Size(72, 16);
            this.uxNumOfBids.TabIndex = 8;
            this.uxNumOfBids.Text = "(0 Bids)";
            // 
            // Bid501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 224);
            this.Controls.Add(this.uxNumOfBids);
            this.Controls.Add(this.uxItemList);
            this.Controls.Add(this.uxPlaceBid);
            this.Controls.Add(this.uxSelectedMinBid);
            this.Controls.Add(this.uxBidInput);
            this.Controls.Add(this.uxStatusLabel);
            this.Controls.Add(this.uxSelectedProductTime);
            this.Controls.Add(this.uxSelectedProductName);
            this.Controls.Add(this.uxProductLabel);
            this.Name = "Bid501";
            this.Text = "Bid501";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxProductLabel;
        private System.Windows.Forms.Label uxSelectedProductName;
        private System.Windows.Forms.Label uxSelectedProductTime;
        private System.Windows.Forms.Label uxStatusLabel;
        private System.Windows.Forms.TextBox uxBidInput;
        private System.Windows.Forms.Label uxSelectedMinBid;
        private System.Windows.Forms.Button uxPlaceBid;
        private System.Windows.Forms.ListBox uxItemList;
        private System.Windows.Forms.Label uxNumOfBids;
    }
}