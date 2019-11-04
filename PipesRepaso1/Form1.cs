using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Pipes;
using System.IO;
using System.Diagnostics;


namespace PipesRepaso1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process server = new Process();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName="~\\Server.exe";
            psi.UseShellExecute = false;
            server.StartInfo=psi;
            server.Start();

            Process client = new Process();
            ProcessStartInfo psi2 = new ProcessStartInfo();
            psi2.FileName = "~\\Cliente.exe";
            psi2.UseShellExecute = false;
            client.StartInfo = psi2;
            client.Start();
        }
    }
}
