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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listviewHistory = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGoOne = new System.Windows.Forms.Button();
            this.btnGoTen = new System.Windows.Forms.Button();
            this.btnWestLeft = new System.Windows.Forms.Button();
            this.btnEastRight = new System.Windows.Forms.Button();
            this.btnSouthDown = new System.Windows.Forms.Button();
            this.btnNorthTop = new System.Windows.Forms.Button();
            this.pictPointer = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictPointer)).BeginInit();
            this.SuspendLayout();
            // 
            // listviewHistory
            // 
            this.listviewHistory.HideSelection = false;
            this.listviewHistory.Location = new System.Drawing.Point(744, 12);
            this.listviewHistory.Name = "listviewHistory";
            this.listviewHistory.Size = new System.Drawing.Size(263, 500);
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
            this.btnGoOne.Location = new System.Drawing.Point(95, 535);
            this.btnGoOne.Name = "btnGoOne";
            this.btnGoOne.Size = new System.Drawing.Size(75, 23);
            this.btnGoOne.TabIndex = 2;
            this.btnGoOne.Text = "Go 1";
            this.btnGoOne.UseVisualStyleBackColor = true;
            this.btnGoOne.Click += new System.EventHandler(this.btnGoOne_Click);
            // 
            // btnGoTen
            // 
            this.btnGoTen.Location = new System.Drawing.Point(546, 535);
            this.btnGoTen.Name = "btnGoTen";
            this.btnGoTen.Size = new System.Drawing.Size(75, 23);
            this.btnGoTen.TabIndex = 3;
            this.btnGoTen.Text = "Go 10";
            this.btnGoTen.UseVisualStyleBackColor = true;
            this.btnGoTen.Click += new System.EventHandler(this.btnGoTen_Click);
            // 
            // btnWestLeft
            // 
            this.btnWestLeft.Location = new System.Drawing.Point(262, 535);
            this.btnWestLeft.Name = "btnWestLeft";
            this.btnWestLeft.Size = new System.Drawing.Size(75, 23);
            this.btnWestLeft.TabIndex = 4;
            this.btnWestLeft.Text = "West";
            this.btnWestLeft.UseVisualStyleBackColor = true;
            this.btnWestLeft.Click += new System.EventHandler(this.btnWestLeft_Click);
            // 
            // btnEastRight
            // 
            this.btnEastRight.Location = new System.Drawing.Point(380, 535);
            this.btnEastRight.Name = "btnEastRight";
            this.btnEastRight.Size = new System.Drawing.Size(75, 23);
            this.btnEastRight.TabIndex = 5;
            this.btnEastRight.Text = "East";
            this.btnEastRight.UseVisualStyleBackColor = true;
            this.btnEastRight.Click += new System.EventHandler(this.btnEastRight_Click);
            // 
            // btnSouthDown
            // 
            this.btnSouthDown.Location = new System.Drawing.Point(318, 564);
            this.btnSouthDown.Name = "btnSouthDown";
            this.btnSouthDown.Size = new System.Drawing.Size(75, 23);
            this.btnSouthDown.TabIndex = 6;
            this.btnSouthDown.Text = "South";
            this.btnSouthDown.UseVisualStyleBackColor = true;
            this.btnSouthDown.Click += new System.EventHandler(this.btnSouthDown_Click);
            // 
            // btnNorthTop
            // 
            this.btnNorthTop.Location = new System.Drawing.Point(318, 506);
            this.btnNorthTop.Name = "btnNorthTop";
            this.btnNorthTop.Size = new System.Drawing.Size(75, 23);
            this.btnNorthTop.TabIndex = 7;
            this.btnNorthTop.Text = "North";
            this.btnNorthTop.UseVisualStyleBackColor = true;
            this.btnNorthTop.Click += new System.EventHandler(this.btnNorthTop_Click);
            // 
            // pictPointer
            // 
            this.pictPointer.Image = ((System.Drawing.Image)(resources.GetObject("pictPointer.Image")));
            this.pictPointer.Location = new System.Drawing.Point(318, 263);
            this.pictPointer.Name = "pictPointer";
            this.pictPointer.Size = new System.Drawing.Size(100, 50);
            this.pictPointer.TabIndex = 9;
            this.pictPointer.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "labelX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "hi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictPointer);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictPointer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox pictPointer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

