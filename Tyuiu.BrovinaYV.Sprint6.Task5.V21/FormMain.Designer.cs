
namespace Tyuiu.BrovinaYV.Sprint6.Task5.V21
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelUp_BYV = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxTask_BYV = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_BYV = new System.Windows.Forms.TextBox();
            this.buttonHelp_BYV = new System.Windows.Forms.Button();
            this.buttonOpenFile_BYV = new System.Windows.Forms.Button();
            this.buttonDone_BYV = new System.Windows.Forms.Button();
            this.groupBoxRes_BYV = new System.Windows.Forms.GroupBox();
            this.chartFunction_BYV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_BYV = new System.Windows.Forms.DataGridView();
            this.panelUp_BYV.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxTask_BYV.SuspendLayout();
            this.groupBoxRes_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BYV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BYV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_BYV
            // 
            this.panelUp_BYV.Controls.Add(this.buttonDone_BYV);
            this.panelUp_BYV.Controls.Add(this.buttonHelp_BYV);
            this.panelUp_BYV.Controls.Add(this.buttonOpenFile_BYV);
            this.panelUp_BYV.Controls.Add(this.groupBoxTask_BYV);
            this.panelUp_BYV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_BYV.Location = new System.Drawing.Point(0, 0);
            this.panelUp_BYV.Name = "panelUp_BYV";
            this.panelUp_BYV.Size = new System.Drawing.Size(930, 123);
            this.panelUp_BYV.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxRes_BYV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 457);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxTask_BYV
            // 
            this.groupBoxTask_BYV.Controls.Add(this.textBoxCondition_BYV);
            this.groupBoxTask_BYV.Location = new System.Drawing.Point(12, 3);
            this.groupBoxTask_BYV.Name = "groupBoxTask_BYV";
            this.groupBoxTask_BYV.Size = new System.Drawing.Size(491, 115);
            this.groupBoxTask_BYV.TabIndex = 3;
            this.groupBoxTask_BYV.TabStop = false;
            this.groupBoxTask_BYV.Text = "Условие";
            // 
            // textBoxCondition_BYV
            // 
            this.textBoxCondition_BYV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_BYV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxCondition_BYV.Location = new System.Drawing.Point(6, 19);
            this.textBoxCondition_BYV.Multiline = true;
            this.textBoxCondition_BYV.Name = "textBoxCondition_BYV";
            this.textBoxCondition_BYV.ReadOnly = true;
            this.textBoxCondition_BYV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxCondition_BYV.Size = new System.Drawing.Size(391, 67);
            this.textBoxCondition_BYV.TabIndex = 0;
            this.textBoxCondition_BYV.Text = "Прочитать данные из файла InPutFileTask5V21.txt. Вывести в dataGridView. \r\nДан сп" +
    "исок из 20 чисел. \r\nВывести все числа, кратные 3. \r\nПостроить диаграмму по этим " +
    "значениям.";
            // 
            // buttonHelp_BYV
            // 
            this.buttonHelp_BYV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_BYV.BackColor = System.Drawing.Color.Beige;
            this.buttonHelp_BYV.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelp_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_BYV.Location = new System.Drawing.Point(826, 22);
            this.buttonHelp_BYV.Name = "buttonHelp_BYV";
            this.buttonHelp_BYV.Size = new System.Drawing.Size(92, 57);
            this.buttonHelp_BYV.TabIndex = 15;
            this.buttonHelp_BYV.Text = "Справка";
            this.buttonHelp_BYV.UseVisualStyleBackColor = false;
            this.buttonHelp_BYV.Click += new System.EventHandler(this.buttonHelp_BYV_Click);
            // 
            // buttonOpenFile_BYV
            // 
            this.buttonOpenFile_BYV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile_BYV.BackColor = System.Drawing.Color.Yellow;
            this.buttonOpenFile_BYV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonOpenFile_BYV.Location = new System.Drawing.Point(717, 22);
            this.buttonOpenFile_BYV.Name = "buttonOpenFile_BYV";
            this.buttonOpenFile_BYV.Size = new System.Drawing.Size(94, 58);
            this.buttonOpenFile_BYV.TabIndex = 14;
            this.buttonOpenFile_BYV.Text = "Открыть";
            this.buttonOpenFile_BYV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_BYV.Click += new System.EventHandler(this.buttonOpenFile_BYV_Click);
            // 
            // buttonDone_BYV
            // 
            this.buttonDone_BYV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_BYV.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonDone_BYV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_BYV.Location = new System.Drawing.Point(603, 20);
            this.buttonDone_BYV.Name = "buttonDone_BYV";
            this.buttonDone_BYV.Size = new System.Drawing.Size(94, 58);
            this.buttonDone_BYV.TabIndex = 13;
            this.buttonDone_BYV.Text = "Выполнить";
            this.buttonDone_BYV.UseVisualStyleBackColor = false;
            this.buttonDone_BYV.Click += new System.EventHandler(this.buttonDone_BYV_Click);
            // 
            // groupBoxRes_BYV
            // 
            this.groupBoxRes_BYV.Controls.Add(this.dataGridViewResult_BYV);
            this.groupBoxRes_BYV.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxRes_BYV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRes_BYV.Name = "groupBoxRes_BYV";
            this.groupBoxRes_BYV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxRes_BYV.Size = new System.Drawing.Size(204, 457);
            this.groupBoxRes_BYV.TabIndex = 14;
            this.groupBoxRes_BYV.TabStop = false;
            this.groupBoxRes_BYV.Text = "Вывод";
            // 
            // chartFunction_BYV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_BYV.ChartAreas.Add(chartArea1);
            this.chartFunction_BYV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_BYV.Legends.Add(legend1);
            this.chartFunction_BYV.Location = new System.Drawing.Point(206, 123);
            this.chartFunction_BYV.Name = "chartFunction_BYV";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_BYV.Series.Add(series1);
            this.chartFunction_BYV.Size = new System.Drawing.Size(724, 457);
            this.chartFunction_BYV.TabIndex = 2;
            this.chartFunction_BYV.Text = "График";
            // 
            // dataGridViewResult_BYV
            // 
            this.dataGridViewResult_BYV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_BYV.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResult_BYV.Name = "dataGridViewResult_BYV";
            this.dataGridViewResult_BYV.RowHeadersVisible = false;
            this.dataGridViewResult_BYV.Size = new System.Drawing.Size(192, 432);
            this.dataGridViewResult_BYV.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 580);
            this.Controls.Add(this.chartFunction_BYV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUp_BYV);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 21 | Бровина Ю. В.";
            this.panelUp_BYV.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxTask_BYV.ResumeLayout(false);
            this.groupBoxTask_BYV.PerformLayout();
            this.groupBoxRes_BYV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BYV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BYV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_BYV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxTask_BYV;
        private System.Windows.Forms.TextBox textBoxCondition_BYV;
        private System.Windows.Forms.Button buttonHelp_BYV;
        private System.Windows.Forms.Button buttonOpenFile_BYV;
        private System.Windows.Forms.Button buttonDone_BYV;
        private System.Windows.Forms.GroupBox groupBoxRes_BYV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BYV;
        private System.Windows.Forms.DataGridView dataGridViewResult_BYV;
    }
}

