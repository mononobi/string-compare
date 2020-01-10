namespace StringCompareTest
{
    partial class TestForm
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblMinSimilarity = new System.Windows.Forms.Label();
            this.lblMaxTolerance = new System.Windows.Forms.Label();
            this.cntSimilarity = new System.Windows.Forms.NumericUpDown();
            this.cntTolerance = new System.Windows.Forms.NumericUpDown();
            this.lblSimilarity = new System.Windows.Forms.Label();
            this.lblTolerance = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.cntToleranceShort = new System.Windows.Forms.NumericUpDown();
            this.cntSimilarityShort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cntSimilarity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntToleranceShort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntSimilarityShort)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(46, 5);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(605, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(46, 30);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(605, 20);
            this.txt2.TabIndex = 1;
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(2, 8);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(40, 13);
            this.lblText1.TabIndex = 2;
            this.lblText1.Text = "Text 1:";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Location = new System.Drawing.Point(2, 33);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(40, 13);
            this.lblText2.TabIndex = 3;
            this.lblText2.Text = "Text 2:";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(577, 89);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblMinSimilarity
            // 
            this.lblMinSimilarity.AutoSize = true;
            this.lblMinSimilarity.Location = new System.Drawing.Point(2, 62);
            this.lblMinSimilarity.Name = "lblMinSimilarity";
            this.lblMinSimilarity.Size = new System.Drawing.Size(97, 13);
            this.lblMinSimilarity.TabIndex = 5;
            this.lblMinSimilarity.Text = "Min Similarity Long:";
            // 
            // lblMaxTolerance
            // 
            this.lblMaxTolerance.AutoSize = true;
            this.lblMaxTolerance.Location = new System.Drawing.Point(319, 62);
            this.lblMaxTolerance.Name = "lblMaxTolerance";
            this.lblMaxTolerance.Size = new System.Drawing.Size(108, 13);
            this.lblMaxTolerance.TabIndex = 6;
            this.lblMaxTolerance.Text = "Max Tolerance Long:";
            // 
            // cntSimilarity
            // 
            this.cntSimilarity.Location = new System.Drawing.Point(103, 60);
            this.cntSimilarity.Name = "cntSimilarity";
            this.cntSimilarity.Size = new System.Drawing.Size(48, 20);
            this.cntSimilarity.TabIndex = 7;
            this.cntSimilarity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cntSimilarity.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // cntTolerance
            // 
            this.cntTolerance.Location = new System.Drawing.Point(433, 60);
            this.cntTolerance.Name = "cntTolerance";
            this.cntTolerance.Size = new System.Drawing.Size(48, 20);
            this.cntTolerance.TabIndex = 8;
            this.cntTolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cntTolerance.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblSimilarity
            // 
            this.lblSimilarity.AutoSize = true;
            this.lblSimilarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSimilarity.Location = new System.Drawing.Point(9, 94);
            this.lblSimilarity.Name = "lblSimilarity";
            this.lblSimilarity.Size = new System.Drawing.Size(0, 13);
            this.lblSimilarity.TabIndex = 9;
            // 
            // lblTolerance
            // 
            this.lblTolerance.AutoSize = true;
            this.lblTolerance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTolerance.Location = new System.Drawing.Point(108, 94);
            this.lblTolerance.Name = "lblTolerance";
            this.lblTolerance.Size = new System.Drawing.Size(0, 13);
            this.lblTolerance.TabIndex = 10;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResult.Location = new System.Drawing.Point(215, 94);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 11;
            // 
            // cntToleranceShort
            // 
            this.cntToleranceShort.Location = new System.Drawing.Point(603, 60);
            this.cntToleranceShort.Name = "cntToleranceShort";
            this.cntToleranceShort.Size = new System.Drawing.Size(48, 20);
            this.cntToleranceShort.TabIndex = 15;
            this.cntToleranceShort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cntToleranceShort.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cntSimilarityShort
            // 
            this.cntSimilarityShort.Location = new System.Drawing.Point(265, 60);
            this.cntSimilarityShort.Name = "cntSimilarityShort";
            this.cntSimilarityShort.Size = new System.Drawing.Size(48, 20);
            this.cntSimilarityShort.TabIndex = 14;
            this.cntSimilarityShort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cntSimilarityShort.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Max Tolerance Short:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Min Similarity Short:";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 117);
            this.Controls.Add(this.cntToleranceShort);
            this.Controls.Add(this.cntSimilarityShort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTolerance);
            this.Controls.Add(this.lblSimilarity);
            this.Controls.Add(this.cntTolerance);
            this.Controls.Add(this.cntSimilarity);
            this.Controls.Add(this.lblMaxTolerance);
            this.Controls.Add(this.lblMinSimilarity);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StringCompare";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cntSimilarity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntToleranceShort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntSimilarityShort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblMinSimilarity;
        private System.Windows.Forms.Label lblMaxTolerance;
        private System.Windows.Forms.NumericUpDown cntSimilarity;
        private System.Windows.Forms.NumericUpDown cntTolerance;
        private System.Windows.Forms.Label lblSimilarity;
        private System.Windows.Forms.Label lblTolerance;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown cntToleranceShort;
        private System.Windows.Forms.NumericUpDown cntSimilarityShort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

