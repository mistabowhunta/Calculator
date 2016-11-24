namespace Calculator
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
            this.rtbTop = new System.Windows.Forms.RichTextBox();
            this.rtbRight = new System.Windows.Forms.RichTextBox();
            this.rtbLeft = new System.Windows.Forms.RichTextBox();
            this.rtbBottom = new System.Windows.Forms.RichTextBox();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnMemory = new System.Windows.Forms.Button();
            this.btnClearRecent = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbTop
            // 
            this.rtbTop.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTop.ForeColor = System.Drawing.Color.Blue;
            this.rtbTop.Location = new System.Drawing.Point(12, 12);
            this.rtbTop.Name = "rtbTop";
            this.rtbTop.ReadOnly = true;
            this.rtbTop.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbTop.Size = new System.Drawing.Size(337, 57);
            this.rtbTop.TabIndex = 3;
            this.rtbTop.Text = "";
            // 
            // rtbRight
            // 
            this.rtbRight.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRight.ForeColor = System.Drawing.Color.Blue;
            this.rtbRight.Location = new System.Drawing.Point(307, 76);
            this.rtbRight.Name = "rtbRight";
            this.rtbRight.ReadOnly = true;
            this.rtbRight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbRight.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbRight.Size = new System.Drawing.Size(42, 298);
            this.rtbRight.TabIndex = 4;
            this.rtbRight.Text = "";
            // 
            // rtbLeft
            // 
            this.rtbLeft.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLeft.ForeColor = System.Drawing.Color.Blue;
            this.rtbLeft.Location = new System.Drawing.Point(12, 75);
            this.rtbLeft.Name = "rtbLeft";
            this.rtbLeft.ReadOnly = true;
            this.rtbLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbLeft.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbLeft.Size = new System.Drawing.Size(42, 298);
            this.rtbLeft.TabIndex = 5;
            this.rtbLeft.Text = "";
            // 
            // rtbBottom
            // 
            this.rtbBottom.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbBottom.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBottom.ForeColor = System.Drawing.Color.Blue;
            this.rtbBottom.Location = new System.Drawing.Point(12, 380);
            this.rtbBottom.Name = "rtbBottom";
            this.rtbBottom.ReadOnly = true;
            this.rtbBottom.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbBottom.Size = new System.Drawing.Size(337, 49);
            this.rtbBottom.TabIndex = 6;
            this.rtbBottom.Text = "";
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFive.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(121, 215);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(55, 49);
            this.btnFive.TabIndex = 7;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNegative.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegative.Location = new System.Drawing.Point(243, 75);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(55, 37);
            this.btnNegative.TabIndex = 8;
            this.btnNegative.Text = "+/-";
            this.btnNegative.UseVisualStyleBackColor = false;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFour.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(60, 215);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(55, 49);
            this.btnFour.TabIndex = 9;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(243, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 97);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriod.Location = new System.Drawing.Point(182, 325);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(55, 49);
            this.btnPeriod.TabIndex = 11;
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = false;
            this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZero.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(60, 325);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(116, 49);
            this.btnZero.TabIndex = 12;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEquals.Font = new System.Drawing.Font("Modern No. 20", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(243, 264);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(55, 111);
            this.btnEquals.TabIndex = 13;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOne.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(60, 270);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(55, 49);
            this.btnOne.TabIndex = 14;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTwo.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(121, 270);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(55, 49);
            this.btnTwo.TabIndex = 15;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThree.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(182, 270);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(55, 49);
            this.btnThree.TabIndex = 16;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSix.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(182, 215);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(55, 49);
            this.btnSix.TabIndex = 17;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeven.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(60, 161);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(55, 49);
            this.btnSeven.TabIndex = 18;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEight.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(121, 161);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(55, 49);
            this.btnEight.TabIndex = 19;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNine.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(182, 161);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(55, 49);
            this.btnNine.TabIndex = 20;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnMemory
            // 
            this.btnMemory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMemory.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemory.Location = new System.Drawing.Point(182, 75);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(55, 37);
            this.btnMemory.TabIndex = 21;
            this.btnMemory.Text = "Mem";
            this.btnMemory.UseVisualStyleBackColor = false;
            this.btnMemory.Click += new System.EventHandler(this.btnMemory_Click);
            // 
            // btnClearRecent
            // 
            this.btnClearRecent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearRecent.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRecent.Location = new System.Drawing.Point(121, 75);
            this.btnClearRecent.Name = "btnClearRecent";
            this.btnClearRecent.Size = new System.Drawing.Size(55, 37);
            this.btnClearRecent.TabIndex = 22;
            this.btnClearRecent.Text = "CE";
            this.btnClearRecent.UseVisualStyleBackColor = false;
            this.btnClearRecent.Click += new System.EventHandler(this.btnClearRecent_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearAll.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(60, 75);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(55, 37);
            this.btnClearAll.TabIndex = 23;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(60, 118);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 37);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "<<<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDivide.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(121, 118);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(55, 37);
            this.btnDivide.TabIndex = 25;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMultiply.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMultiply.Location = new System.Drawing.Point(182, 118);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(55, 37);
            this.btnMultiply.TabIndex = 26;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubtract.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubtract.Location = new System.Drawing.Point(243, 118);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(55, 37);
            this.btnSubtract.TabIndex = 27;
            this.btnSubtract.Text = "-";
            this.btnSubtract.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(361, 441);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClearRecent);
            this.Controls.Add(this.btnMemory);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnPeriod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.rtbBottom);
            this.Controls.Add(this.rtbLeft);
            this.Controls.Add(this.rtbRight);
            this.Controls.Add(this.rtbTop);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbTop;
        private System.Windows.Forms.RichTextBox rtbRight;
        private System.Windows.Forms.RichTextBox rtbLeft;
        private System.Windows.Forms.RichTextBox rtbBottom;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Button btnClearRecent;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
    }
}

