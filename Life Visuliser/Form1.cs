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

namespace Life_Visuliser
{
    public partial class Form1 : Form
    {
        const string fileToStarterQuestions = @"C:\Users\trevo\OneDrive\Documents\C# thing\a new personal winform folder\Life Visuliser\Life Visuliser\StarterQ.txt";
        List<string> questions = new List<string>();
        public Form1()
        {
            foreach(string s in File.ReadAllLines(fileToStarterQuestions))
            {
                questions.Add(s);
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

            if (!File.Exists(@"C:\Users\trevo\OneDrive\Documents\C# thing\a new personal winform folder\Life Visuliser\Life Visuliser\bin\Debug\Data.JSON"))
            {
                Application.Run(new QuizForm("as you are new we have prepared a quiz for you to start and see where you currently are.",questions)); //<--- this is a class that will get the innitial statistics to store into a json file
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


