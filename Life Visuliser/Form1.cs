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

        readonly string fileToStarterQuestions = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "StarterQ.txt");
        readonly List<string> questions = new List<string>();
        public Form1()
        {
            callingPython();
            InitializeComponent();
            
        }

        /// <summary>
        /// when i call this function python will activate and send data to bin/debug/file.json
        /// </summary>
        public void callingPython() 
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


