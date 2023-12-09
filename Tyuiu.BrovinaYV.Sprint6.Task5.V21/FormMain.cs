using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BrovinaYV.Sprint6.Task5.V21.Lib;

namespace Tyuiu.BrovinaYV.Sprint6.Task5.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\broth\source\repos\Tyuiu.BrovinaYV.Sprint6\Tyuiu.BrovinaYV.Sprint6.Task5.V21\bin\Debug\InPutFileTask5V21.txt";
        private void buttonDone_BYV_Click(object sender, EventArgs e)
        {
            dataGridViewResult_BYV.ColumnCount = 2;
            dataGridViewResult_BYV.Columns[0].Width = 20;
            dataGridViewResult_BYV.Columns[1].Width = 50;
            this.chartFunction_BYV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_BYV.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_BYV.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_BYV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_BYV.Series[0].Points.AddXY(i, numsMass[i]);
            }


        }

        private void buttonHelp_BYV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы АСОиУБ-23-2 Бровина Юлия Викторовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_BYV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
