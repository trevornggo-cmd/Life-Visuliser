using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;

namespace Life_Visuliser
{
    struct statsIndex
    {
        public int social;
        public int financial;
        public int mental;
        public int physical;
        public int purposeful;
    }
    public partial class Form1 : Form
    {
        statsIndex foolProveIndexSystem = new statsIndex { social = 0, financial = 1, mental = 2, physical = 3, purposeful = 4 };
        string fileToStarterQuestions = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "StarterQ.txt");
        List<string> questions = new List<string>();
        public Form1()
        {
            if (File.Exists(fileToStarterQuestions))
            {
                foreach (string s in File.ReadAllLines(fileToStarterQuestions))
                {
                    questions.Add(s);
                }
            }
            else
            {
                Directory.CreateDirectory(fileToStarterQuestions);
            }
            InitializeComponent();
            {
                //vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
                /*  ProcessStartInfo psi = new ProcessStartInfo();
                  psi.FileName = "python";
                  psi.WorkingDirectory = "C:\\Users\\trevo\\OneDrive\\Documents\\C# thing\\a new personal winform folder\\Life Visuliser\\Life Visuliser";
                  psi.Arguments = "python.py";

                  Process process = Process.Start(psi);
                  process.WaitForExit();*/
                //^^^^^^This is the call for the python script to run^^^^^^^
            }

            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "Data.JSON")))
            {
                Application.Run(new QuizForm("as you are new we have prepared a quiz for you to start and see where you currently are.", questions)); //<--- this is a class that will get the innitial statistics to store into a json file
            }
            else
            {

            }

        }

        private void AccessToJson()
        {
            throw new NotImplementedException();
        }


    }


}


