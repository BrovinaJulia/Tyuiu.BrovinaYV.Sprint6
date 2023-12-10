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
using Tyuiu.BrovinaYV.Sprint6.Task7.V27.Lib;

namespace Tyuiu.BrovinaYV.Sprint6.Task7.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_BYV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix_BYV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        
        static int rows;
        static int columns;
        static string openFile;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpenFile_BYV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BYV.ShowDialog();
            openFile = openFileDialogTask_BYV.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewInput_BYV.RowCount = rows;
            dataGridViewInput_BYV.ColumnCount = columns;
            dataGridViewOutput_BYV.RowCount = rows;
            dataGridViewOutput_BYV.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_BYV.Columns[i].Width = 50;
                dataGridViewOutput_BYV.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_BYV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_BYV.Enabled = true;

        }

        private void buttonDone_BYV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutput_BYV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_BYV.Enabled = true;
        }

        private void buttonSave_BYV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_BYV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_BYV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_BYV.ShowDialog();

            string path = saveFileDialogMatrix_BYV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_BYV.RowCount;
            int columns = dataGridViewOutput_BYV.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutput_BYV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutput_BYV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_BYV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BYV.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_BYV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BYV.ToolTipTitle = "Выполнить";

        }

        private void buttonSave_BYV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BYV.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_BYV_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void buttonHelp_BYV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BYV.ToolTipTitle = "Справка";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_BYV.RowCount = 50;
            dataGridViewOutput_BYV.RowCount = 50;

            dataGridViewInput_BYV.ColumnCount = 50;
            dataGridViewOutput_BYV.ColumnCount = 50;

           

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_BYV.Columns[i].Width = 25;
                dataGridViewOutput_BYV.Columns[i].Width = 25;
            }
        }
    }
}
