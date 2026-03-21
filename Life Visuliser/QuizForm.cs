using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_Visuliser
{
    internal class QuizForm : Form
    {
        private Button[] AllButtons = new Button[10];
        private Label IntroLbl;
        private Button beginQuizBtn;
        private Label QuestionLbl;
        private List<string> questions = new List<string>();
        private string quizIntro = " ";


        public QuizForm(string quizIntro, List<string> quizQuestions)
        {
            InitializeComponent();
            this.quizIntro = quizIntro;
            this.questions = quizQuestions;
        }
        private void InitializeComponent()
        {
            this.IntroLbl = new System.Windows.Forms.Label();
            this.beginQuizBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IntroLbl
            // 
            this.IntroLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroLbl.Location = new System.Drawing.Point(54, 21);
            this.IntroLbl.Name = "IntroLbl";
            this.IntroLbl.Size = new System.Drawing.Size(451, 71);
            this.IntroLbl.TabIndex = 0;
            this.IntroLbl.Text = quizIntro;
               
            // 
            // beginQuizBtn
            // 
            this.beginQuizBtn.Location = new System.Drawing.Point(233, 224);
            this.beginQuizBtn.Name = "beginQuizBtn";
            this.beginQuizBtn.Size = new System.Drawing.Size(75, 23);
            this.beginQuizBtn.TabIndex = 1;
            this.beginQuizBtn.Text = "Begin";
            this.beginQuizBtn.UseVisualStyleBackColor = true;
            this.beginQuizBtn.Click += new System.EventHandler(this.beginQuizBtn_Click);
            // 
            // QuizForm
            // 
            this.ClientSize = new System.Drawing.Size(581, 438);
            this.Controls.Add(this.beginQuizBtn);
            this.Controls.Add(this.IntroLbl);
            this.Name = "QuizForm";
            this.ResumeLayout(false);

        }

        private void PresentQuestion(string question)
        {
            this.Controls.Clear();
            this.QuestionLbl = new System.Windows.Forms.Label();
            this.QuestionLbl.AutoSize = true;
            this.QuestionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLbl.Location = new System.Drawing.Point(195, 52);
            this.QuestionLbl.Name = "QuestionLbl";
            this.QuestionLbl.Size = new System.Drawing.Size(158, 55);
            this.QuestionLbl.TabIndex = 0;
            this.QuestionLbl.Text = question + "(1 being i completly disagree and 10 being i completely agree)";

            for (int i = 0; i < 10; i++)
            {
                AllButtons[i] = new Button();
                AllButtons[i].Location = new System.Drawing.Point(17 + (55 * i), 329);
                AllButtons[i].Size = new System.Drawing.Size(49, 23);
                AllButtons[i].TabIndex = 6;
                AllButtons[i].Text = $"{i + 1}";
                AllButtons[i].UseVisualStyleBackColor = true;
                this.Controls.Add(AllButtons[i]);
            }
            this.Controls.Add(QuestionLbl);
        }

        private void beginQuizBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < questions.Count; i++)
            {
                PresentQuestion(questions[i]);
            }
        }


    }
}
