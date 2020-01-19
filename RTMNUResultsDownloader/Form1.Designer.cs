namespace RTMNUResultsDownloader
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
            this.cbxFaculty = new System.Windows.Forms.ComboBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxExam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtBxMin = new System.Windows.Forms.NumericUpDown();
            this.txtBxMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxMax)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxFaculty
            // 
            this.cbxFaculty.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFaculty.FormattingEnabled = true;
            this.cbxFaculty.Location = new System.Drawing.Point(280, 102);
            this.cbxFaculty.Name = "cbxFaculty";
            this.cbxFaculty.Size = new System.Drawing.Size(311, 35);
            this.cbxFaculty.TabIndex = 0;
            this.cbxFaculty.SelectedIndexChanged += new System.EventHandler(this.cbxFaculty_SelectedIndexChanged);
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.Location = new System.Drawing.Point(27, 99);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Padding = new System.Windows.Forms.Padding(5);
            this.lblFaculty.Size = new System.Drawing.Size(204, 38);
            this.lblFaculty.TabIndex = 1;
            this.lblFaculty.Text = "Select Faculty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 166);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(165, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Exam";
            // 
            // cbxExam
            // 
            this.cbxExam.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxExam.FormattingEnabled = true;
            this.cbxExam.Location = new System.Drawing.Point(280, 169);
            this.cbxExam.Name = "cbxExam";
            this.cbxExam.Size = new System.Drawing.Size(311, 35);
            this.cbxExam.TabIndex = 2;
            this.cbxExam.SelectedIndexChanged += new System.EventHandler(this.cbxExam_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 224);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(178, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Range";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Consolas", 13.8F);
            this.btnStart.Location = new System.Drawing.Point(385, 295);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 38);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 13.8F);
            this.btnCancel.Location = new System.Drawing.Point(504, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 38);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 368);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(621, 315);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // txtBxMin
            // 
            this.txtBxMin.Font = new System.Drawing.Font("Consolas", 13.8F);
            this.txtBxMin.Location = new System.Drawing.Point(280, 228);
            this.txtBxMin.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtBxMin.Name = "txtBxMin";
            this.txtBxMin.Size = new System.Drawing.Size(120, 34);
            this.txtBxMin.TabIndex = 10;
            // 
            // txtBxMax
            // 
            this.txtBxMax.Font = new System.Drawing.Font("Consolas", 13.8F);
            this.txtBxMax.Location = new System.Drawing.Point(419, 228);
            this.txtBxMax.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtBxMax.Name = "txtBxMax";
            this.txtBxMax.Size = new System.Drawing.Size(120, 34);
            this.txtBxMax.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 695);
            this.Controls.Add(this.txtBxMax);
            this.Controls.Add(this.txtBxMin);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxExam);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.cbxFaculty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFaculty;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxExam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown txtBxMin;
        private System.Windows.Forms.NumericUpDown txtBxMax;
    }
}

