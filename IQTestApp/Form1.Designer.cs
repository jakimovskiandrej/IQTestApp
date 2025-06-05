namespace IQTestApp
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
            this.components = new System.ComponentModel.Container();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.pbAnswer4 = new System.Windows.Forms.PictureBox();
            this.pbAnswer3 = new System.Windows.Forms.PictureBox();
            this.pbAnswer2 = new System.Windows.Forms.PictureBox();
            this.pbAnswer1 = new System.Windows.Forms.PictureBox();
            this.rbAnswer4 = new System.Windows.Forms.RadioButton();
            this.rbAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbAnswer1 = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbIntellectualAge = new System.Windows.Forms.TextBox();
            this.lblIntellectualAge = new System.Windows.Forms.Label();
            this.lblChronicalAge = new System.Windows.Forms.Label();
            this.tbChronicalAge = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(13, 12);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbCategory.Size = new System.Drawing.Size(216, 24);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.Text = "Избери категорија";
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(809, 16);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(110, 23);
            this.btnStartTest.TabIndex = 1;
            this.btnStartTest.Text = "Започни тест";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.pbAnswer4);
            this.gbCategory.Controls.Add(this.pbAnswer3);
            this.gbCategory.Controls.Add(this.pbAnswer2);
            this.gbCategory.Controls.Add(this.pbAnswer1);
            this.gbCategory.Controls.Add(this.rbAnswer4);
            this.gbCategory.Controls.Add(this.rbAnswer3);
            this.gbCategory.Controls.Add(this.rbAnswer2);
            this.gbCategory.Controls.Add(this.rbAnswer1);
            this.gbCategory.Controls.Add(this.lblQuestion);
            this.gbCategory.Controls.Add(this.label1);
            this.gbCategory.Location = new System.Drawing.Point(12, 45);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(907, 593);
            this.gbCategory.TabIndex = 2;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "gbCategory";
            // 
            // pbAnswer4
            // 
            this.pbAnswer4.Location = new System.Drawing.Point(106, 474);
            this.pbAnswer4.Name = "pbAnswer4";
            this.pbAnswer4.Size = new System.Drawing.Size(216, 102);
            this.pbAnswer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnswer4.TabIndex = 9;
            this.pbAnswer4.TabStop = false;
            // 
            // pbAnswer3
            // 
            this.pbAnswer3.Location = new System.Drawing.Point(106, 344);
            this.pbAnswer3.Name = "pbAnswer3";
            this.pbAnswer3.Size = new System.Drawing.Size(216, 107);
            this.pbAnswer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnswer3.TabIndex = 8;
            this.pbAnswer3.TabStop = false;
            // 
            // pbAnswer2
            // 
            this.pbAnswer2.Location = new System.Drawing.Point(106, 215);
            this.pbAnswer2.Name = "pbAnswer2";
            this.pbAnswer2.Size = new System.Drawing.Size(216, 100);
            this.pbAnswer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnswer2.TabIndex = 7;
            this.pbAnswer2.TabStop = false;
            // 
            // pbAnswer1
            // 
            this.pbAnswer1.Location = new System.Drawing.Point(106, 92);
            this.pbAnswer1.Name = "pbAnswer1";
            this.pbAnswer1.Size = new System.Drawing.Size(216, 105);
            this.pbAnswer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnswer1.TabIndex = 6;
            this.pbAnswer1.TabStop = false;
            // 
            // rbAnswer4
            // 
            this.rbAnswer4.AutoSize = true;
            this.rbAnswer4.Location = new System.Drawing.Point(6, 474);
            this.rbAnswer4.Name = "rbAnswer4";
            this.rbAnswer4.Size = new System.Drawing.Size(94, 20);
            this.rbAnswer4.TabIndex = 5;
            this.rbAnswer4.TabStop = true;
            this.rbAnswer4.Text = "Одговор 4";
            this.rbAnswer4.UseVisualStyleBackColor = true;
            // 
            // rbAnswer3
            // 
            this.rbAnswer3.AutoSize = true;
            this.rbAnswer3.Location = new System.Drawing.Point(6, 344);
            this.rbAnswer3.Name = "rbAnswer3";
            this.rbAnswer3.Size = new System.Drawing.Size(94, 20);
            this.rbAnswer3.TabIndex = 4;
            this.rbAnswer3.TabStop = true;
            this.rbAnswer3.Text = "Одговор 3";
            this.rbAnswer3.UseVisualStyleBackColor = true;
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.AutoSize = true;
            this.rbAnswer2.Location = new System.Drawing.Point(6, 215);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(94, 20);
            this.rbAnswer2.TabIndex = 3;
            this.rbAnswer2.TabStop = true;
            this.rbAnswer2.Text = "Одговор 2";
            this.rbAnswer2.UseVisualStyleBackColor = true;
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.AutoSize = true;
            this.rbAnswer1.Location = new System.Drawing.Point(6, 92);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(94, 20);
            this.rbAnswer1.TabIndex = 2;
            this.rbAnswer1.TabStop = true;
            this.rbAnswer1.Text = "Одговор 1";
            this.rbAnswer1.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(86, 33);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(69, 16);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Прашање";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прашање:";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(12, 649);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(148, 23);
            this.btnNextQuestion.TabIndex = 3;
            this.btnNextQuestion.Text = "Следно прашање >>";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(346, 404);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 16);
            this.lblScore.TabIndex = 4;
            // 
            // tbIntellectualAge
            // 
            this.tbIntellectualAge.Location = new System.Drawing.Point(423, 17);
            this.tbIntellectualAge.Name = "tbIntellectualAge";
            this.tbIntellectualAge.Size = new System.Drawing.Size(100, 22);
            this.tbIntellectualAge.TabIndex = 5;
            // 
            // lblIntellectualAge
            // 
            this.lblIntellectualAge.AutoSize = true;
            this.lblIntellectualAge.Location = new System.Drawing.Point(250, 18);
            this.lblIntellectualAge.Name = "lblIntellectualAge";
            this.lblIntellectualAge.Size = new System.Drawing.Size(167, 16);
            this.lblIntellectualAge.TabIndex = 6;
            this.lblIntellectualAge.Text = "Интелектуална возраст";
            // 
            // lblChronicalAge
            // 
            this.lblChronicalAge.AutoSize = true;
            this.lblChronicalAge.Location = new System.Drawing.Point(540, 18);
            this.lblChronicalAge.Name = "lblChronicalAge";
            this.lblChronicalAge.Size = new System.Drawing.Size(144, 16);
            this.lblChronicalAge.TabIndex = 7;
            this.lblChronicalAge.Text = "Хронолошка возраст";
            // 
            // tbChronicalAge
            // 
            this.tbChronicalAge.Location = new System.Drawing.Point(690, 17);
            this.tbChronicalAge.Name = "tbChronicalAge";
            this.tbChronicalAge.Size = new System.Drawing.Size(100, 22);
            this.tbChronicalAge.TabIndex = 8;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 684);
            this.Controls.Add(this.tbChronicalAge);
            this.Controls.Add(this.lblChronicalAge);
            this.Controls.Add(this.lblIntellectualAge);
            this.Controls.Add(this.tbIntellectualAge);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.cbCategory);
            this.Name = "Form1";
            this.Text = "IQTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.RadioButton rbAnswer3;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.RadioButton rbAnswer1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.RadioButton rbAnswer4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbAnswer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbIntellectualAge;
        private System.Windows.Forms.Label lblIntellectualAge;
        private System.Windows.Forms.Label lblChronicalAge;
        private System.Windows.Forms.TextBox tbChronicalAge;
        private System.Windows.Forms.PictureBox pbAnswer4;
        private System.Windows.Forms.PictureBox pbAnswer3;
        private System.Windows.Forms.PictureBox pbAnswer2;
        private System.Windows.Forms.ImageList imageList1;
    }
}

