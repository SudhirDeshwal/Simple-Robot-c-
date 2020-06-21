namespace Week_5_Lab
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
            this.listviewHistory = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGoOne = new System.Windows.Forms.Button();
            this.btnGoTen = new System.Windows.Forms.Button();
            this.btnWestLeft = new System.Windows.Forms.Button();
            this.btnEastRight = new System.Windows.Forms.Button();
            this.btnSouthDown = new System.Windows.Forms.Button();
            this.btnNorthTop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listviewHistory
            // 
            this.listviewHistory.HideSelection = false;
            this.listviewHistory.Location = new System.Drawing.Point(843, 12);
            this.listviewHistory.Name = "listviewHistory";
            this.listviewHistory.Size = new System.Drawing.Size(164, 500);
            this.listviewHistory.TabIndex = 0;
            this.listviewHistory.UseCompatibleStateImageBehavior = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(893, 543);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGoOne
            // 
            this.btnGoOne.Location = new System.Drawing.Point(143, 512);
            this.btnGoOne.Name = "btnGoOne";
            this.btnGoOne.Size = new System.Drawing.Size(75, 23);
            this.btnGoOne.TabIndex = 2;
            this.btnGoOne.Text = "Go 1";
            this.btnGoOne.UseVisualStyleBackColor = true;
            // 
            // btnGoTen
            // 
            this.btnGoTen.Location = new System.Drawing.Point(492, 512);
            this.btnGoTen.Name = "btnGoTen";
            this.btnGoTen.Size = new System.Drawing.Size(75, 23);
            this.btnGoTen.TabIndex = 3;
            this.btnGoTen.Text = "Go 10";
            this.btnGoTen.UseVisualStyleBackColor = true;
            // 
            // btnWestLeft
            // 
            this.btnWestLeft.Location = new System.Drawing.Point(264, 514);
            this.btnWestLeft.Name = "btnWestLeft";
            this.btnWestLeft.Size = new System.Drawing.Size(75, 23);
            this.btnWestLeft.TabIndex = 4;
            this.btnWestLeft.Text = "West";
            this.btnWestLeft.UseVisualStyleBackColor = true;
            // 
            // btnEastRight
            // 
            this.btnEastRight.Location = new System.Drawing.Point(380, 512);
            this.btnEastRight.Name = "btnEastRight";
            this.btnEastRight.Size = new System.Drawing.Size(75, 23);
            this.btnEastRight.TabIndex = 5;
            this.btnEastRight.Text = "East";
            this.btnEastRight.UseVisualStyleBackColor = true;
            // 
            // btnSouthDown
            // 
            this.btnSouthDown.Location = new System.Drawing.Point(318, 543);
            this.btnSouthDown.Name = "btnSouthDown";
            this.btnSouthDown.Size = new System.Drawing.Size(75, 23);
            this.btnSouthDown.TabIndex = 6;
            this.btnSouthDown.Text = "South";
            this.btnSouthDown.UseVisualStyleBackColor = true;
            // 
            // btnNorthTop
            // 
            this.btnNorthTop.Location = new System.Drawing.Point(318, 473);
            this.btnNorthTop.Name = "btnNorthTop";
            this.btnNorthTop.Size = new System.Drawing.Size(75, 23);
            this.btnNorthTop.TabIndex = 7;
            this.btnNorthTop.Text = "North";
            this.btnNorthTop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 599);
            this.Controls.Add(this.btnNorthTop);
            this.Controls.Add(this.btnSouthDown);
            this.Controls.Add(this.btnEastRight);
            this.Controls.Add(this.btnWestLeft);
            this.Controls.Add(this.btnGoTen);
            this.Controls.Add(this.btnGoOne);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listviewHistory);
            this.Name = "Form1";
            this.Text = "Simple Robot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewHistory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGoOne;
        private System.Windows.Forms.Button btnGoTen;
        private System.Windows.Forms.Button btnWestLeft;
        private System.Windows.Forms.Button btnEastRight;
        private System.Windows.Forms.Button btnSouthDown;
        private System.Windows.Forms.Button btnNorthTop;
    }
}

