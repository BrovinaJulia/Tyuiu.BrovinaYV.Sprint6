using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.BrovinaYV.Sprint6.Task6.V23.Lib;

namespace Tyuiu.BrovinaYV.Sprint6.Task6.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonDone_BYV.Enabled = false;
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_BYV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BYV.ShowDialog();
            openFilePath = openFileDialogTask_BYV.FileName;
            textBoxInput_BYV.Text = File.ReadAllText(openFilePath);
            groupBoxOutput_BYV.Text = groupBoxOutput_BYV.Text + " " + openFileDialogTask_BYV.FileName;
            buttonDone_BYV.Enabled = true;
        }

        private void buttonDone_BYV_Click(object sender, EventArgs e)
        {
            
            textBoxOutput_BYV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_BYV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
