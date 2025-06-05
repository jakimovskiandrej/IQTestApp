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
    public partial class Form1: Form
    {
        List<Question> Questions;
        private int score = 0;
        private int currentQuestionIndex = 0;

        public Form1()
        {
            InitializeComponent();
            Questions = new List<Question>();
            ToggleGroupBox(false);
            cbCategory.Items.Add("Деца");
            cbCategory.Items.Add("Тинејџери");
            cbCategory.Items.Add("Возрасни");
            lblScore.Visible = false;
            lblIntellectualAge.Visible = true;
            lblChronicalAge.Visible = true;
            gbCategory.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartTest()
        {
            string category = cbCategory.SelectedItem.ToString();
            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Изберете категорија");
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
            if(category.Equals("Тинејџери"))
            {
                LoadQuestionTeen();
            }
            if(category.Equals("Возрасни"))
            {
                LoadQuestionMature();
            }
            ToggleGroupBox(true);
            GetQuestionsByCategory(category);
            currentQuestionIndex = 0;
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
                new Question("Кој број недостасува: 2, 4, 6, ?, 10", new List<string>{ "7", "8", "9", "5" }, 1, null, "Деца"),
                new Question("Која фигура не припаѓа: Круг, Триаголник, Квадрат, Зајак", new List<string>{ "A", "B", "C", "D" }, new List<string>{ "Images/rabbit.png", "Images/circle.png", "Images/square.png", "Images/triangle.png" }, 0, null, "Деца"),
                new Question("Колку агли има квадрат?", new List<string>{ "3", "4", "5", "6" }, 1, null, "Деца"),
                new Question("Низата е: Црвено, Сино, Црвено, Сино, ...", new List<string>{ "Сино", "Жолто", "Црвено", "Зелено" }, 2, null, "Деца"),
                new Question("Ана има 2 јаболка, Петар 3. Колку имаат заедно?", new List<string>{ "4", "5", "6", "3" }, 1, null, "Деца"),
                new Question("Ако 5 + 2 = 7, тогаш 5 + ? = 10", new List<string>{ "3", "4", "5", "6" }, 2, null, "Деца"),
                new Question("Која од следните форми е круг?", new List<string>{ "Форма 1", "Форма 2", "Форма 3", "Форма 4" }, new List<string>{ "Images/square.png", "Images/circle.png", "Images/triangle.png", "Images/rhombus.png" }, 1, null, "Деца")
            };
        }

        private void LoadQuestionTeen()
        {
            Questions = new List<Question> {
                new Question("Кој број следува: 1, 4, 9, 16, ?", new List<string>{ "25", "20", "36", "30" }, 0, null, "Тинејџери"),
                new Question("Низата е: A, C, F, J, ?, со растечки разлики", new List<string>{ "M", "N", "O", "P" }, 1, null, "Тинејџери"),
                new Question("Кој предмет не припаѓа овде?", new List<string>{ "A", "B", "C", "D" }, new List<string>{ "Images/book.png", "Images/square.png", "Images/apple.png", "Images/notebook.jpg" }, 2, null, "Тинејџери"),
                new Question("Бројот 81 е квадрат од кој број?", new List<string>{ "7", "9", "8", "10" }, 1, null, "Тинејџери"),
                new Question("Ако 2 + 3 = 10 и 3 + 4 = 17, тогаш 4 + 5 = ?", new List<string>{ "19", "21", "24", "26" }, 2, null, "Тинејџери"),
                new Question("Која буква доаѓа по следниот образец: A, B, D, G, K, ?", new List<string>{ "L", "M", "P", "Q" }, 2, null, "Тинејџери"),
                new Question("Која од овие животни не лета?", new List<string>{ "A", "B", "C", "D" }, new List<string>{ "Images/eagle.png", "Images/butterfly.jpg", "Images/penguin.jpg", "Images/parrot.jpg" }, 2, null, "Тинејџери")
            };
        }

        private void LoadQuestionMature()
        {
            Questions = new List<Question> {
                new Question("Низата е: 2, 6, 12, 20, 30, ?", new List<string>{ "36", "38", "42", "44" }, 2, null, "Возрасни"),
                new Question("Ако 5 × 3 = 8, 6 × 2 = 10, тогаш 7 × 4 = ?", new List<string>{ "13", "15", "16", "18" }, 1, null, "Возрасни"),
                new Question("Пронајди што не припаѓа:", new List<string>{ "A", "B", "C", "D" }, new List<string>{ "Images/phone.png", "Images/tablet.png", "Images/laptop.jpg", "Images/toaster.jpg" }, 3, null, "Возрасни"),
                new Question("Која е следната буква во серијата: Z, X, U, Q, ?", new List<string>{ "N", "M", "K", "L" }, 0, null, "Возрасни"),
                new Question("Низата е: 3, 5, 9, 17, 33, ?", new List<string>{ "65", "63", "60", "67" }, 1, null, "Возрасни"),
                new Question("Пронајди логичка поврзаност: 2 → 4, 3 → 9, 4 → ?", new List<string>{ "12", "16", "18", "15" }, 1, null, "Возрасни"),
                new Question("Која од следниве храни не е овошје?", new List<string>{ "A", "B", "C", "D" }, new List<string>{ "Images/apple.png", "Images/banana.jpg", "Images/broccoli.png", "Images/orange.jpg" }, 2, null, "Возрасни")
            };
        }

        private void ShowQuestion()
        {
            if (Questions != null && Questions.Count > 0 && currentQuestionIndex < Questions.Count)
            {
                var question = Questions[currentQuestionIndex];
                lblQuestion.Text = question.Text;
                if (question.AnswerImagePaths != null && question.AnswerImagePaths.Count == question.Answers.Count)
                {
                    rbAnswer1.Text = question.Answers[0];
                    rbAnswer2.Text = question.Answers[1];
                    rbAnswer3.Text = question.Answers[2];
                    rbAnswer4.Text = question.Answers[3];
                    SetImage(pbAnswer1, question.AnswerImagePaths[0]);
                    SetImage(pbAnswer2, question.AnswerImagePaths[1]);
                    SetImage(pbAnswer3, question.AnswerImagePaths[2]);
                    SetImage(pbAnswer4, question.AnswerImagePaths[3]);
                    pbAnswer1.Visible = true;
                    pbAnswer2.Visible = true;
                    pbAnswer3.Visible = true;
                    pbAnswer4.Visible = true;
                }
                else
                {
                    pbAnswer1.Visible = false;
                    pbAnswer2.Visible = false;
                    pbAnswer3.Visible = false;
                    pbAnswer4.Visible = false;
                    rbAnswer1.Text = question.Answers[0];
                    rbAnswer2.Text = question.Answers[1];
                    rbAnswer3.Text = question.Answers[2];
                    rbAnswer4.Text = question.Answers[3];
                }
                rbAnswer1.Checked = false;
                rbAnswer2.Checked = false;
                rbAnswer3.Checked = false;
                rbAnswer4.Checked = false;
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

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnStartTest_Click(object sender, EventArgs e)
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
            if(selectedIndex == Questions[currentQuestionIndex].CorrectIndex)
            {
                score++;
            }
            currentQuestionIndex++;
            lblScore.Text = $"Моментален резултат: {score} / {Questions.Count}";
            if (currentQuestionIndex < Questions.Count)
            {
                ShowQuestion();
            }
            else
            {
                EndTest();
            }
        }

        private void EndTest()
        {
            bool isIntellectualAgeValid = int.TryParse(tbIntellectualAge.Text, out int intellectualAge);
            bool isChronologicalAgeValid = int.TryParse(tbChronicalAge.Text, out int chronologicalAge);

            if (!isIntellectualAgeValid || !isChronologicalAgeValid || intellectualAge <= 0 || intellectualAge > 100 ||
                chronologicalAge <= 0 || chronologicalAge > 100)
            {
                MessageBox.Show("Ве молиме внесете валидни години за интелектуална и хронолошка возраст (1-100).");
                return;
            }
            double iq = ((double)intellectualAge / chronologicalAge) * 100;
            MessageBox.Show($"Тестот е завршен!\n" + $"Точни одговори: {score} / {Questions.Count}\n" + $"Вашето IQ: {iq:F2}");
            Application.Restart();
        }
    }
}
