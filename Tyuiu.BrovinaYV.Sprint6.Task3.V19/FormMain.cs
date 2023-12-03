using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BrovinaYV.Sprint6.Task3.V19.Lib;

namespace Tyuiu.BrovinaYV.Sprint6.Task3.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = {{ 4,  32, -20,  27,  21, },
                            { 17,  15,  -1,  -2,  -1, },
                            { -3,  18,  12, -10,  29, },
                            { 7, -15,   2,  -8,  12 },
                            { -10,  25,   5,  27,  21 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            
            dataGridViewMatrix_BYV.ColumnCount = columns;
            dataGridViewMatrix_BYV.RowCount = rows;
            
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_BYV.Columns[i].Width = 40;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_BYV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }



        }

        private void buttonDone_BYV_Click(object sender, EventArgs e)
        {
            int[,] matrixres = ds.Calculate(matrix);

            int rows = matrixres.GetUpperBound(0) + 1;
            int columns = matrixres.Length / rows;

            dataGridViewMatrix_BYV.ColumnCount = columns;
            dataGridViewMatrix_BYV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_BYV.Columns[i].Width = 40;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_BYV.Rows[i].Cells[j].Value = Convert.ToString(matrixres[i, j]);
                }
            }

        }

        private void buttonHelp_BYV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы АСОиУб-23-2 Бровина Юлия Викторовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
