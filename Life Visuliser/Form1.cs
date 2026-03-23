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
using Newtonsoft.Json.Linq;

namespace Life_Visuliser
{

    public partial class Form1 : Form
    {

        public struct StatCounter
        {
            public int social;
            public int financial;
            public int mental;
            public int physical;
            public int purposeful;
        }
        StatCounter InitialStatCounter = new StatCounter();

        readonly string fileToStarterQuestions = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "StarterQ.txt");
        readonly List<string> questions = new List<string>();
        public Form1()
        {
            string pathToTheFileForBackendToRecive = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "backend reciving point.json");
            File.WriteAllText(pathToTheFileForBackendToRecive, " ");
            CallingPython(); //<-- should of created a file called 'frountend reciving point.json'

            string pathToTheFileForFrontendToRecive = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "frountend reciving point.json");
            JObject allDataInJson = JObject.Parse(pathToTheFileForFrontendToRecive);
            bool isStarter = allDataInJson.SelectToken("isStarter").Value<bool>();

            if (isStarter)
            {
                foreach (string s in File.ReadAllLines(fileToStarterQuestions))
                {
                    questions.Add(s);
                }
                Application.Run(new QuizForm("hello there.\nseeing as how you're new here lets get started\nwith a quiz to initulise your life\nvisulisation",questions));
            }
            else
            {
                InitialStatCounter = allDataInJson.SelectToken("GeneralStat").Value<StatCounter>();//<-- GeneralStat is the stat that represents the stats in the homescreen chart (can change depending on what backend names it)

                HomeScreenCht.Series.Clear();
                Series HomeScreenChtSeries = new Series();
                HomeScreenChtSeries.ChartArea = "HomeScreenChtArea";
                HomeScreenChtSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
                HomeScreenChtSeries.Legend = "HomeScreenChtLegend";
                HomeScreenChtSeries.Name = "HomeScreenChtSeries";

                HomeScreenChtSeries.Points.AddXY("Social",InitialStatCounter.social);
                HomeScreenChtSeries.Points.AddXY("Financial", InitialStatCounter.financial);
                HomeScreenChtSeries.Points.AddXY("Mental", InitialStatCounter.mental);
                HomeScreenChtSeries.Points.AddXY("Physical", InitialStatCounter.physical);
                HomeScreenChtSeries.Points.AddXY("Purposeful", InitialStatCounter.purposeful);
            }

            InitializeComponent();
        }

        /// <summary>
        /// when i call this function python will activate and send data to bin/debug/file.json
        /// </summary>
        public void CallingPython() 
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "python";
            psi.WorkingDirectory = "C:\\Users\\trevo\\OneDrive\\Documents\\C# thing\\a new personal winform folder\\Life Visuliser\\Life Visuliser";
            psi.Arguments = "python.py";
            Process process = Process.Start(psi);
            process.WaitForExit();
        }


    }
}


