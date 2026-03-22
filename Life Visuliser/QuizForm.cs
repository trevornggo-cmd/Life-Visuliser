using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

        public struct StatCounter
        {
            public int social;
            public int financial;
            public int mental;
            public int physical;
            public int purposeful;
        }
        private StatCounter foolProveStatCountSystem = new StatCounter { social = 0, financial = 0, mental = 0, physical = 0, purposeful =  0};
        public QuizForm(string quizIntro, List<string> quizQuestions)
        {
            InitializeComponent();
            this.quizIntro = quizIntro;
            this.questions = quizQuestions;
            this.IntroLbl.Text = quizIntro;
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
            this.IntroLbl.Text = " ";
               
            // 
            // beginQuizBtn
            // 
            this.beginQuizBtn.Location = new System.Drawing.Point(233, 224);
            this.beginQuizBtn.Name = "beginQuizBtn";
            this.beginQuizBtn.Size = new System.Drawing.Size(75, 23);
            this.beginQuizBtn.TabIndex = 1;
            this.beginQuizBtn.Text = "Begin";
            this.beginQuizBtn.UseVisualStyleBackColor = true;
            this.beginQuizBtn.Click += new System.EventHandler(this.optionBtn_Click);
            // 
            // QuizForm
            // 
            this.ClientSize = new System.Drawing.Size(581, 438);
            this.Controls.Add(this.beginQuizBtn);
            this.Controls.Add(this.IntroLbl);
            this.Name = "QuizForm";
            this.ResumeLayout(false);

        }

        string[] currentQ;
        private void PresentQuestion(string question)
        {
            currentQ = question.Split('-');
            this.Controls.Clear();
            this.QuestionLbl = new System.Windows.Forms.Label();
            this.QuestionLbl.AutoSize = true;
            this.QuestionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLbl.Name = "QuestionLbl";
            this.QuestionLbl.Size = new System.Drawing.Size(1000, 55);
            this.QuestionLbl.TabIndex = 0;
            this.QuestionLbl.Text = currentQ[1] + "\n(1 being i completly disagree and 10 being i completely agree)";
            this.QuestionLbl.Location = new System.Drawing.Point(0, 152);

            for (int i = 0; i < 10; i++)
            {
                AllButtons[i] = new Button();
                AllButtons[i].Location = new System.Drawing.Point(17 + (55 * i), 329);
                AllButtons[i].Size = new System.Drawing.Size(49, 23);
                AllButtons[i].TabIndex = 6;
                AllButtons[i].Text = $"{i + 1}";
                AllButtons[i].UseVisualStyleBackColor = true;
                AllButtons[i].Click += new System.EventHandler(this.optionBtn_Click);
                this.Controls.Add(AllButtons[i]);
            }
            this.Controls.Add(QuestionLbl);
            
        }


        int counter = 0;
        private void optionBtn_Click(object sender, EventArgs e)
        {
            PresentQuestion(questions[counter]);
            Button b = (Button)sender;
            int agreeability;
            if(int.TryParse(b.Text, out agreeability))
            {
                counter++;
            }
            switch (currentQ[0])
            {
                case "financial":
                    foolProveStatCountSystem.financial += agreeability;
                    break;
                case "social":
                    foolProveStatCountSystem.social += agreeability;
                    break;
                case "mental":
                    foolProveStatCountSystem.mental += agreeability;
                    break;
                case "physical":
                    foolProveStatCountSystem.physical += agreeability;
                    break;
                case "purposeful":
                    foolProveStatCountSystem.purposeful += agreeability;
                    break;

            }
           
            if (!(counter < questions.Count))
            {
                this.Controls.Clear();
                Label OutroLbl = new System.Windows.Forms.Label();
                OutroLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                OutroLbl.Location = new System.Drawing.Point(54, 21);
                OutroLbl.Name = "OutroLbl";
                OutroLbl.Size = new System.Drawing.Size(451, 71);
                OutroLbl.TabIndex = 0;
                OutroLbl.Text = "Now that we have your score we are able to begin your life visulisation\n(press that cross button on the top right corner to continue)";
                this.Controls.Add(OutroLbl);
                JSONDumpingTheResults();

            }
        }

        private void JSONDumpingTheResults()
        {
            string jsonContents = JsonConvert.SerializeObject(foolProveStatCountSystem);
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "backend reciving point.json");
            File.WriteAllText(path, jsonContents);
        }
    }
}
