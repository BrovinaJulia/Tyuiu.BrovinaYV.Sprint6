using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BrovinaYV.Sprint6.Task1.V14.Lib;

namespace Tyuiu.BrovinaYV.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService(); 
        private void buttonDone_BYV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BYV.Text);
                int endStep = Convert.ToInt32(textBoxStopStep_BYV.Text);

                string strLine;
                int len = ds.GetMassFunction(startStep, endStep).Length;
                double[]valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, endStep);
                textBoxResult_BYV.Text = "";
                textBoxResult_BYV.AppendText("+----------+----------+"+Environment.NewLine);
                textBoxResult_BYV.AppendText("|    X     +   f(x)   |"+Environment.NewLine);
                textBoxResult_BYV.AppendText("+----------+----------+"+Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1,5:f2}    |", startStep, valueArray[i]);
                    textBoxResult_BYV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_BYV.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_BYV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы АСОиУБ-23-2 Бровина Юлия Викторовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
