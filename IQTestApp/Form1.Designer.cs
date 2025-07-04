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
            this.lblIntellectualAge = new System.Windows.Forms.Label();
            this.tbIntellectualAge = new System.Windows.Forms.TextBox();
            this.lblChronicalAge = new System.Windows.Forms.Label();
            this.tbChronicalAge = new System.Windows.Forms.TextBox();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pbQuestionImage = new System.Windows.Forms.PictureBox();
            this.rbAnswer1 = new System.Windows.Forms.RadioButton();
            this.lblCurrentQuestion = new System.Windows.Forms.Label();
            this.rbAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbAnswer4 = new System.Windows.Forms.RadioButton();
            this.pbAnswer1 = new System.Windows.Forms.PictureBox();
            this.pbAnswer2 = new System.Windows.Forms.PictureBox();
            this.pbAnswer3 = new System.Windows.Forms.PictureBox();
            this.pbAnswer4 = new System.Windows.Forms.PictureBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer4)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(13, 13);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(205, 24);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lblIntellectualAge
            // 
            this.lblIntellectualAge.AutoSize = true;
            this.lblIntellectualAge.Location = new System.Drawing.Point(244, 16);
            this.lblIntellectualAge.Name = "lblIntellectualAge";
            this.lblIntellectualAge.Size = new System.Drawing.Size(167, 16);
            this.lblIntellectualAge.TabIndex = 1;
            this.lblIntellectualAge.Text = "Интелектуална возраст";
            // 
            // tbIntellectualAge
            // 
            this.tbIntellectualAge.Location = new System.Drawing.Point(417, 15);
            this.tbIntellectualAge.Name = "tbIntellectualAge";
            this.tbIntellectualAge.Size = new System.Drawing.Size(71, 22);
            this.tbIntellectualAge.TabIndex = 2;
            // 
            // lblChronicalAge
            // 
            this.lblChronicalAge.AutoSize = true;
            this.lblChronicalAge.Location = new System.Drawing.Point(244, 44);
            this.lblChronicalAge.Name = "lblChronicalAge";
            this.lblChronicalAge.Size = new System.Drawing.Size(144, 16);
            this.lblChronicalAge.TabIndex = 3;
            this.lblChronicalAge.Text = "Хронолошка возраст";
            // 
            // tbChronicalAge
            // 
            this.tbChronicalAge.Location = new System.Drawing.Point(417, 44);
            this.tbChronicalAge.Name = "tbChronicalAge";
            this.tbChronicalAge.Size = new System.Drawing.Size(71, 22);
            this.tbChronicalAge.TabIndex = 4;
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(522, 26);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(153, 25);
            this.btnStartTest.TabIndex = 5;
            this.btnStartTest.Text = "Започни тест";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click_1);
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
            this.gbCategory.Controls.Add(this.lblCurrentQuestion);
            this.gbCategory.Controls.Add(this.rbAnswer1);
            this.gbCategory.Controls.Add(this.pbQuestionImage);
            this.gbCategory.Controls.Add(this.lblQuestion);
            this.gbCategory.Location = new System.Drawing.Point(13, 72);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(986, 488);
            this.gbCategory.TabIndex = 6;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "groupBox1";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(148, 38);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(44, 16);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label1";
            // 
            // pbQuestionImage
            // 
            this.pbQuestionImage.Location = new System.Drawing.Point(151, 62);
            this.pbQuestionImage.Name = "pbQuestionImage";
            this.pbQuestionImage.Size = new System.Drawing.Size(395, 139);
            this.pbQuestionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestionImage.TabIndex = 1;
            this.pbQuestionImage.TabStop = false;
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.AutoSize = true;
            this.rbAnswer1.Location = new System.Drawing.Point(110, 230);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(37, 20);
            this.rbAnswer1.TabIndex = 2;
            this.rbAnswer1.TabStop = true;
            this.rbAnswer1.Text = "A";
            this.rbAnswer1.UseVisualStyleBackColor = true;
            // 
            // lblCurrentQuestion
            // 
            this.lblCurrentQuestion.AutoSize = true;
            this.lblCurrentQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQuestion.Location = new System.Drawing.Point(833, 38);
            this.lblCurrentQuestion.Name = "lblCurrentQuestion";
            this.lblCurrentQuestion.Size = new System.Drawing.Size(58, 22);
            this.lblCurrentQuestion.TabIndex = 3;
            this.lblCurrentQuestion.Text = "label2";
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.AutoSize = true;
            this.rbAnswer2.Location = new System.Drawing.Point(110, 389);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(37, 20);
            this.rbAnswer2.TabIndex = 4;
            this.rbAnswer2.TabStop = true;
            this.rbAnswer2.Text = "B";
            this.rbAnswer2.UseVisualStyleBackColor = true;
            // 
            // rbAnswer3
            // 
            this.rbAnswer3.AutoSize = true;
            this.rbAnswer3.Location = new System.Drawing.Point(497, 230);
            this.rbAnswer3.Name = "rbAnswer3";
            this.rbAnswer3.Size = new System.Drawing.Size(37, 20);
            this.rbAnswer3.TabIndex = 5;
            this.rbAnswer3.TabStop = true;
            this.rbAnswer3.Text = "C";
            this.rbAnswer3.UseVisualStyleBackColor = true;
            // 
            // rbAnswer4
            // 
            this.rbAnswer4.AutoSize = true;
            this.rbAnswer4.Location = new System.Drawing.Point(496, 389);
            this.rbAnswer4.Name = "rbAnswer4";
            this.rbAnswer4.Size = new System.Drawing.Size(38, 20);
            this.rbAnswer4.TabIndex = 6;
            this.rbAnswer4.TabStop = true;
            this.rbAnswer4.Text = "D";
            this.rbAnswer4.UseVisualStyleBackColor = true;
            // 
            // pbAnswer1
            // 
            this.pbAnswer1.Location = new System.Drawing.Point(151, 230);
            this.pbAnswer1.Name = "pbAnswer1";
            this.pbAnswer1.Size = new System.Drawing.Size(197, 85);
            this.pbAnswer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnswer1.TabIndex = 7;
            this.pbAnswer1.TabStop = false;
            // 
            // pbAnswer2
            // 
            this.pbAnswer2.Location = new System.Drawing.Point(151, 380);
            this.pbAnswer2.Name = "pbAnswer2";
            this.pbAnswer2.Size = new System.Drawing.Size(197, 81);
            this.pbAnswer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnswer2.TabIndex = 8;
            this.pbAnswer2.TabStop = false;
            // 
            // pbAnswer3
            // 
            this.pbAnswer3.Location = new System.Drawing.Point(540, 230);
            this.pbAnswer3.Name = "pbAnswer3";
            this.pbAnswer3.Size = new System.Drawing.Size(188, 85);
            this.pbAnswer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnswer3.TabIndex = 9;
            this.pbAnswer3.TabStop = false;
            // 
            // pbAnswer4
            // 
            this.pbAnswer4.Location = new System.Drawing.Point(540, 380);
            this.pbAnswer4.Name = "pbAnswer4";
            this.pbAnswer4.Size = new System.Drawing.Size(188, 81);
            this.pbAnswer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnswer4.TabIndex = 10;
            this.pbAnswer4.TabStop = false;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(12, 566);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(147, 23);
            this.btnNextQuestion.TabIndex = 7;
            this.btnNextQuestion.Text = "Следно прашање";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(802, 566);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(44, 16);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 594);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.tbChronicalAge);
            this.Controls.Add(this.lblChronicalAge);
            this.Controls.Add(this.tbIntellectualAge);
            this.Controls.Add(this.lblIntellectualAge);
            this.Controls.Add(this.cbCategory);
            this.Name = "Form1";
            this.Text = "IQTest";
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnswer4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblIntellectualAge;
        private System.Windows.Forms.TextBox tbIntellectualAge;
        private System.Windows.Forms.Label lblChronicalAge;
        private System.Windows.Forms.TextBox tbChronicalAge;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.RadioButton rbAnswer1;
        private System.Windows.Forms.PictureBox pbQuestionImage;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbAnswer4;
        private System.Windows.Forms.RadioButton rbAnswer3;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.Label lblCurrentQuestion;
        private System.Windows.Forms.PictureBox pbAnswer4;
        private System.Windows.Forms.PictureBox pbAnswer3;
        private System.Windows.Forms.PictureBox pbAnswer2;
        private System.Windows.Forms.PictureBox pbAnswer1;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}

