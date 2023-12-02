using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BrovinaYV.Sprint6.Task2.V17.Lib;
namespace Tyuiu.BrovinaYV.Sprint6.Task2.V17
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

                
                int len = ds.GetMassFunction(startStep, endStep).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, endStep);

                this.chartFunction.Titles.Add("График функции f(x)");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";
                
                for(int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_BYV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы АСОиУБ-23-2 Бровина Юлия Викторовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonDone_BYV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_BYV.BackColor = Color.Red;
        }

        private void buttonDone_BYV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_BYV.BackColor = Color.Green;
        }

        private void buttonDone_BYV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_BYV.BackColor = Color.Blue;
        }
    }
}
