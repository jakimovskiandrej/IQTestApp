using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQTestApp
{
    public partial class Form1 : Form
    {
        List<Question> Questions;
        private int score = 0;
        private int currentQuestionIndex = 0;
        Timer Timer;
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
            Questions = new List<Question>();
            ToggleGroupBox(false);
            cbCategory.Items.Add("Деца");
            cbCategory.Items.Add("Тинејџери");
            cbCategory.Items.Add("Возрасни");
            Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Tick += timer1_Tick;
            UpdateTimer();
            lblIntellectualAge.Visible = true;
            lblChronicalAge.Visible = true;
            gbCategory.Visible = false;
            lblTime.Visible = false;
            lblCurrentQuestion.Visible = false;
        }
        private void StartTest()
        {
            if (string.IsNullOrWhiteSpace(cbCategory.Text) || cbCategory.Text == "Избери категорија")
            {
                MessageBox.Show("Ве молиме изберете соодветна категорија");
                return;
            }
            bool isChronAgeValid = int.TryParse(tbChronicalAge.Text, out int chronAge);
            if (!isChronAgeValid || chronAge <= 0 || chronAge > 100)
            {
                MessageBox.Show("Ве молиме внесете валидна хронолошка возраст.");
                return;
            }
            bool isIntelAgeValid = int.TryParse(tbIntellectualAge.Text, out int intelAge);
            if (!isIntelAgeValid || intelAge <= 0 || intelAge > 100)
            {
                MessageBox.Show("Ве молиме внесете валидна интелектуална возраст.");
                return;
            }
            string category = cbCategory.Text;
            if (category == "Деца" && chronAge > 12)
            {
                MessageBox.Show("За категоријата 'Деца' може да внесете возраст до 12 години.");
                return;
            }
            else if (category == "Тинејџери" && (chronAge < 13 || chronAge > 19))
            {
                MessageBox.Show("За категоријата 'Тинејџери' може да внесете возраст од 13 до 19 години.");
                return;
            }
            else if (category == "Возрасни" && chronAge < 20)
            {
                MessageBox.Show("За категоријата 'Возрасни' може да внесете возраст од 20 години и повеќе.");
                return;
            }
            gbCategory.Visible = true;
            lblIntellectualAge.Visible = false;
            lblChronicalAge.Visible = false;
            tbChronicalAge.Visible = false;
            tbIntellectualAge.Visible = false;
            cbCategory.Visible = false;
            gbCategory.Text = category;
            btnStartTest.Visible = false;
            if (category.Equals("Деца"))
            {
                LoadQuestionChildren();
            }
            else if (category.Equals("Тинејџери"))
            {
                LoadQuestionTeen();
            }
            else if (category.Equals("Возрасни"))
            {
                LoadQuestionMature();
            }
            timeLeft = 420;
            UpdateTimer();
            lblTime.Visible = true;
            Timer.Start();
            ToggleGroupBox(true);
            GetQuestionsByCategory(category);
            currentQuestionIndex = 0;
            lblCurrentQuestion.Text = $"Прашање: {currentQuestionIndex + 1}/7";
            lblCurrentQuestion.Visible = true;
            score = 0;
            ShowQuestion();
        }

        private List<Question> GetQuestionsByCategory(string category)
        {
            return Questions.Where(q => q.Category.Equals(category)).ToList();
        }

        private void LoadQuestionChildren()
        {
            Questions = new List<Question> {
                new Question("Кој е следниот број во секвенцата?","Images-Children/p1.png",new List<string>{"95","123","238","96"},null,0,"Деца"),
                new Question("Колку триаголници има на сликата?", "Images-Children/p2.png",new List<string>{"23", "22","21","20"},null,0,"Деца"),
                new Question("Изберете го точниот одговор", "Images-Children/p3.png",null,new List<string>{"Images-Children/p3-o1.png", "Images-Children/p3-o2.png", "Images-Children/p3-tocen.png","Images-Children/p3-o3.png"},2,"Деца"),
                new Question("Изберете го точниот одговор", "Images-Children/p4.png",null,new List<string>{"Images-Children/p4-o1.png", "Images-Children/p4-tocen.png", "Images-Children/p4-o2.png","Images-Children/p4-o3.png"},1,"Деца"),
                new Question("Изберете го точниот одговор", "Images-Children/p5.png",null,new List<string>{"Images-Children/p5-tocen.png", "Images-Children/p5-o1.png", "Images-Children/p5-o2.png","Images-Children/p5-o3.png"},0,"Деца"),
                new Question("Изберете го точниот одговор", "Images-Children/p6.png",new List<string>{"47","49","45","42"},null,1,"Деца"),
                new Question("Изберете го точниот одговор", "Images-Children/p7.png",new List<string>{"50","80","32","83"},null,1,"Деца"),
            };
        }

        private void LoadQuestionTeen()
        {
            Questions = new List<Question> {
                new Question("Изберете го точниот одговор","Images/p1.png",null,new List<string>{"Images/p1-o1.png","Images/p1-o2.png","Images/p1-tocen.png","Images/p1-o3.png"},2,"Тинејџери"),
                new Question("Изберете го точниот одговор","Images/p3.png",null,new List<string>{"Images/p3-tocen.png","Images/p3-o2.png","Images/p3-o1.png","Images/p3-o1.png"},0,"Тинејџери"),
                new Question("Изберете го точниот одговор","Images/p5.png",null,new List<string>{"Images/p5-o3.png","Images/p5-o1.png","Images/p5-o2.png","Images/p5-tocen.png"},3,"Тинејџери"),
                new Question("Изберете ја сликата која ќе се прикаже на огледалото","Images/p7.png",null,new List<string>{"Images/p7-o2.png","Images/p7-tocen.png","Images/p7-o1.png","Images/p7-o3.png"},1,"Тинејџери"),
                new Question("Изберете го точниот одговор","Images/p9.png",null,new List<string>{"Images/p9-o1.png","Images/p9-o2.png","Images/p9-tocen.png","Images/p9-o3.png"},2,"Тинејџери"),
                new Question("Изберете го точниот одговор","Images/p11.png",null,new List<string>{"Images/p11-tocen.png","Images/p11-o2.png","Images/p11-o1.png","Images/p11-o3.png"},0,"Тинејџери"),
                new Question("Изберете го точниот одговор","Images/p13.png",null,new List<string>{"Images/p13-tocen.png","Images/p13-o2.png","Images/p13-o3.png","Images/p13-o1.png"},0,"Тинејџери"),
            };
        }

        private void LoadQuestionMature()
        {
            Questions = new List<Question> {
                new Question("Изберете го точниот одговор","Images/p2.png",null,new List<string>{"Images/p2-o1.png","Images/p2-o2.png","Images/p2-tocen.png","Images/p2-o3.png"},2,"Возрасни"),
                new Question("Изберете го точниот одговор","Images/p4.png",null,new List<string>{"Images/p4-tocen.png","Images/p4-o2.png","Images/p4-o1.png","Images/p4-o1.png"},0,"Возрасни"),
                new Question("Изберете го точниот одговор","Images/p6.png",null,new List<string>{"Images/p6-o3.png","Images/p6-o1.png","Images/p6-o2.png","Images/p6-tocen.png"},3,"Возрасни"),
                new Question("Изберете го точниот одговор","Images/p8.png",null,new List<string>{"Images/p8-o2.png","Images/p8-tocen.png","Images/p8-o1.png","Images/p8-o3.png"},1,"Возрасни"),
                new Question("Изберете го точниот одговор","Images/p10.png",null,new List<string>{"Images/p10-o1.png","Images/p10-o2.png","Images/p10-tocen.png","Images/p10-o3.png"},2,"Возрасни"),
                new Question("Изберете го точниот одговор","Images/p12.png",null,new List<string>{"Images/p12-tocen.png","Images/p12-o2.png","Images/p12-o1.png","Images/p12-o3.png"},0,"Возрасни"),
                new Question("Изберете го точниот одговор","Images/p14.png",null,new List<string>{"Images/p14-tocen.png","Images/p14-o2.png","Images/p14-o3.png","Images/p14-o1.png"},0,"Возрасни"),
            };
        }

        private void ShowQuestion()
        {
            if (Questions != null && Questions.Count > 0 && currentQuestionIndex < Questions.Count)
            {
                var question = Questions[currentQuestionIndex];
                lblQuestion.Text = question.Text;
                SetImage(pbQuestionImage, question.QuestionImagePath);
                rbAnswer1.Visible = true;
                rbAnswer2.Visible = true;
                rbAnswer3.Visible = true;
                rbAnswer4.Visible = true;
                rbAnswer1.Checked = false;
                rbAnswer2.Checked = false;
                rbAnswer3.Checked = false;
                rbAnswer4.Checked = false;
                if (question.AnswerImagePaths != null)
                {
                    rbAnswer1.Text = "";
                    rbAnswer2.Text = "";
                    rbAnswer3.Text = "";
                    rbAnswer4.Text = "";
                    pbAnswer1.Visible = true;
                    pbAnswer2.Visible = true;
                    pbAnswer3.Visible = true;
                    pbAnswer4.Visible = true;
                    SetImage(pbAnswer1, question.AnswerImagePaths[0]);
                    SetImage(pbAnswer2, question.AnswerImagePaths[1]);
                    SetImage(pbAnswer3, question.AnswerImagePaths[2]);
                    SetImage(pbAnswer4, question.AnswerImagePaths[3]);
                }
                else
                {
                    rbAnswer1.Text = question.Answers[0];
                    rbAnswer2.Text = question.Answers[1];
                    rbAnswer3.Text = question.Answers[2];
                    rbAnswer4.Text = question.Answers[3];
                    pbAnswer1.Visible = false;
                    pbAnswer2.Visible = false;
                    pbAnswer3.Visible = false;
                    pbAnswer4.Visible = false;
                    pbAnswer1.Image = null;
                    pbAnswer2.Image = null;
                    pbAnswer3.Image = null;
                    pbAnswer4.Image = null;
                }
            }
        }

        private void SetImage(PictureBox pb, string imagePath)
        {
            string fullPath = Path.Combine(Application.StartupPath, imagePath);
            if (File.Exists(fullPath))
            {
                pb.Image = Image.FromFile(fullPath);
            }
            else
            {
                pb.Image = null;
            }
        }

        private void ToggleGroupBox(bool visible)
        {
            gbCategory.Visible = visible;
            btnNextQuestion.Visible = visible;
        }

        private void UpdateTimer()
        {
            lblTime.Visible = true;
            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;
            lblTime.Text = string.Format("Преостанато време: {0:D2}:{1:D2}", minutes, seconds);
            if (timeLeft <= 10)
            {
                lblTime.ForeColor = Color.Red;
            }
            else
            {
                lblTime.ForeColor = Color.Black;
            }
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            StartTest();
        }

        
        private void EndTest()
        {
            Timer.Stop();
            if (currentQuestionIndex >= Questions.Count)
            {
                double percentCorrect = (double)score / Questions.Count;
                int iq = (int)(percentCorrect * 50) + 75;
                if (iq > 145)
                {
                    iq = 145;
                }
                MessageBox.Show($"Тестот е завршен!\nВашиот IQ резултат е: {iq}");
                Application.Restart();
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft <= 0)
            {
                Timer.Stop();
                lblTime.Text = "Преостанато време: 00:00";
                DialogResult result = MessageBox.Show("Времето истече!\nДали сакате да започнете нов тест?", "Тестот заврши", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
                return;
            }
            timeLeft--;
            UpdateTimer();
        }

        private void btnStartTest_Click_1(object sender, EventArgs e)
        {
            StartTest();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            int selectedIndex = -1;
            if (rbAnswer1.Checked)
            {
                selectedIndex = 0;
            }
            else if (rbAnswer2.Checked)
            {
                selectedIndex = 1;
            }
            else if (rbAnswer3.Checked)
            {
                selectedIndex = 2;
            }
            else if (rbAnswer4.Checked)
            {
                selectedIndex = 3;
            }
            if (selectedIndex == -1)
            {
                MessageBox.Show("Ве молиме изберете одговор");
                return;
            }
            if (selectedIndex == Questions[currentQuestionIndex].CorrectIndex)
            {
                score++;
            }
            currentQuestionIndex++;
            if (currentQuestionIndex < Questions.Count)
            {
                ShowQuestion();
                lblCurrentQuestion.Text = $"Прашање: {currentQuestionIndex + 1}/7";
                lblCurrentQuestion.Visible = true;
            }
            else
            {
                EndTest();
            }
        }
    }
}
