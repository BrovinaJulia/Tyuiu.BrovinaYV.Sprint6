
namespace Tyuiu.BrovinaYV.Sprint6.Task2.V17
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_BYV = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_BYV = new System.Windows.Forms.TextBox();
            this.groupBoxInput_BYV = new System.Windows.Forms.GroupBox();
            this.textBoxEnd_BYV = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_BYV = new System.Windows.Forms.TextBox();
            this.textBoxStart_BYV = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_BYV = new System.Windows.Forms.TextBox();
            this.buttonHelp_BYV = new System.Windows.Forms.Button();
            this.buttonDone_BYV = new System.Windows.Forms.Button();
            this.groupBoxResult_BYV = new System.Windows.Forms.GroupBox();
            this.textBoxRes_BYV = new System.Windows.Forms.TextBox();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_BYV.SuspendLayout();
            this.groupBoxInput_BYV.SuspendLayout();
            this.groupBoxResult_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_BYV
            // 
            this.groupBoxTask_BYV.Controls.Add(this.textBoxCondition_BYV);
            this.groupBoxTask_BYV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_BYV.Name = "groupBoxTask_BYV";
            this.groupBoxTask_BYV.Size = new System.Drawing.Size(470, 206);
            this.groupBoxTask_BYV.TabIndex = 2;
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
            this.textBoxCondition_BYV.Size = new System.Drawing.Size(359, 67);
            this.textBoxCondition_BYV.TabIndex = 0;
            this.textBoxCondition_BYV.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в DataGrid" +
    "View и построить график функции.\r\n";
            // 
            // groupBoxInput_BYV
            // 
            this.groupBoxInput_BYV.Controls.Add(this.textBoxEnd_BYV);
            this.groupBoxInput_BYV.Controls.Add(this.textBoxStopStep_BYV);
            this.groupBoxInput_BYV.Controls.Add(this.textBoxStart_BYV);
            this.groupBoxInput_BYV.Controls.Add(this.textBoxStartStep_BYV);
            this.groupBoxInput_BYV.Location = new System.Drawing.Point(12, 224);
            this.groupBoxInput_BYV.Name = "groupBoxInput_BYV";
            this.groupBoxInput_BYV.Size = new System.Drawing.Size(237, 66);
            this.groupBoxInput_BYV.TabIndex = 3;
            this.groupBoxInput_BYV.TabStop = false;
            this.groupBoxInput_BYV.Text = "Ввод данных";
            // 
            // textBoxEnd_BYV
            // 
            this.textBoxEnd_BYV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEnd_BYV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxEnd_BYV.Location = new System.Drawing.Point(121, 19);
            this.textBoxEnd_BYV.Name = "textBoxEnd_BYV";
            this.textBoxEnd_BYV.ReadOnly = true;
            this.textBoxEnd_BYV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxEnd_BYV.Size = new System.Drawing.Size(111, 13);
            this.textBoxEnd_BYV.TabIndex = 4;
            this.textBoxEnd_BYV.Text = "Конец шага";
            // 
            // textBoxStopStep_BYV
            // 
            this.textBoxStopStep_BYV.Location = new System.Drawing.Point(121, 38);
            this.textBoxStopStep_BYV.Name = "textBoxStopStep_BYV";
            this.textBoxStopStep_BYV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_BYV.TabIndex = 3;
            this.textBoxStopStep_BYV.Text = "5";
            // 
            // textBoxStart_BYV
            // 
            this.textBoxStart_BYV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStart_BYV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxStart_BYV.Location = new System.Drawing.Point(6, 19);
            this.textBoxStart_BYV.Name = "textBoxStart_BYV";
            this.textBoxStart_BYV.ReadOnly = true;
            this.textBoxStart_BYV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxStart_BYV.Size = new System.Drawing.Size(111, 13);
            this.textBoxStart_BYV.TabIndex = 2;
            this.textBoxStart_BYV.Text = "Старт шага";
            // 
            // textBoxStartStep_BYV
            // 
            this.textBoxStartStep_BYV.Location = new System.Drawing.Point(6, 38);
            this.textBoxStartStep_BYV.Name = "textBoxStartStep_BYV";
            this.textBoxStartStep_BYV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_BYV.TabIndex = 0;
            this.textBoxStartStep_BYV.Text = "-5";
            // 
            // buttonHelp_BYV
            // 
            this.buttonHelp_BYV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_BYV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_BYV.Location = new System.Drawing.Point(270, 228);
            this.buttonHelp_BYV.Name = "buttonHelp_BYV";
            this.buttonHelp_BYV.Size = new System.Drawing.Size(66, 62);
            this.buttonHelp_BYV.TabIndex = 8;
            this.buttonHelp_BYV.Text = "Справка";
            this.buttonHelp_BYV.UseVisualStyleBackColor = false;
            this.buttonHelp_BYV.Click += new System.EventHandler(this.buttonHelp_BYV_Click);
            // 
            // buttonDone_BYV
            // 
            this.buttonDone_BYV.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonDone_BYV.Location = new System.Drawing.Point(356, 228);
            this.buttonDone_BYV.Name = "buttonDone_BYV";
            this.buttonDone_BYV.Size = new System.Drawing.Size(126, 62);
            this.buttonDone_BYV.TabIndex = 9;
            this.buttonDone_BYV.Text = "Выполнить";
            this.buttonDone_BYV.UseVisualStyleBackColor = false;
            this.buttonDone_BYV.Click += new System.EventHandler(this.buttonDone_BYV_Click);
            this.buttonDone_BYV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_BYV_MouseDown);
            this.buttonDone_BYV.MouseEnter += new System.EventHandler(this.buttonDone_BYV_MouseEnter);
            this.buttonDone_BYV.MouseLeave += new System.EventHandler(this.buttonDone_BYV_MouseLeave);
            // 
            // groupBoxResult_BYV
            // 
            this.groupBoxResult_BYV.Controls.Add(this.chartFunction);
            this.groupBoxResult_BYV.Controls.Add(this.dataGridViewFunction);
            this.groupBoxResult_BYV.Controls.Add(this.textBoxRes_BYV);
            this.groupBoxResult_BYV.Location = new System.Drawing.Point(488, 12);
            this.groupBoxResult_BYV.Name = "groupBoxResult_BYV";
            this.groupBoxResult_BYV.Size = new System.Drawing.Size(671, 287);
            this.groupBoxResult_BYV.TabIndex = 10;
            this.groupBoxResult_BYV.TabStop = false;
            this.groupBoxResult_BYV.Text = "Вывод данных";
            // 
            // textBoxRes_BYV
            // 
            this.textBoxRes_BYV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRes_BYV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxRes_BYV.Location = new System.Drawing.Point(6, 19);
            this.textBoxRes_BYV.Name = "textBoxRes_BYV";
            this.textBoxRes_BYV.ReadOnly = true;
            this.textBoxRes_BYV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxRes_BYV.Size = new System.Drawing.Size(117, 13);
            this.textBoxRes_BYV.TabIndex = 0;
            this.textBoxRes_BYV.Text = "Результат\r\n\r\n";
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Function});
            this.dataGridViewFunction.Location = new System.Drawing.Point(7, 39);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.Size = new System.Drawing.Size(145, 239);
            this.dataGridViewFunction.TabIndex = 1;
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction.Legends.Add(legend2);
            this.chartFunction.Location = new System.Drawing.Point(158, 39);
            this.chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction.Series.Add(series2);
            this.chartFunction.Size = new System.Drawing.Size(473, 242);
            this.chartFunction.TabIndex = 2;
            this.chartFunction.Text = "График функции";
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Function
            // 
            this.Function.HeaderText = "F(x)";
            this.Function.Name = "Function";
            this.Function.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 318);
            this.Controls.Add(this.groupBoxResult_BYV);
            this.Controls.Add(this.buttonDone_BYV);
            this.Controls.Add(this.buttonHelp_BYV);
            this.Controls.Add(this.groupBoxInput_BYV);
            this.Controls.Add(this.groupBoxTask_BYV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 17 | Бровина Ю. В.";
            this.groupBoxTask_BYV.ResumeLayout(false);
            this.groupBoxTask_BYV.PerformLayout();
            this.groupBoxInput_BYV.ResumeLayout(false);
            this.groupBoxInput_BYV.PerformLayout();
            this.groupBoxResult_BYV.ResumeLayout(false);
            this.groupBoxResult_BYV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_BYV;
        private System.Windows.Forms.TextBox textBoxCondition_BYV;
        private System.Windows.Forms.GroupBox groupBoxInput_BYV;
        private System.Windows.Forms.TextBox textBoxEnd_BYV;
        private System.Windows.Forms.TextBox textBoxStopStep_BYV;
        private System.Windows.Forms.TextBox textBoxStart_BYV;
        private System.Windows.Forms.TextBox textBoxStartStep_BYV;
        private System.Windows.Forms.Button buttonHelp_BYV;
        private System.Windows.Forms.Button buttonDone_BYV;
        private System.Windows.Forms.GroupBox groupBoxResult_BYV;
        private System.Windows.Forms.TextBox textBoxRes_BYV;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Function;
    }
}

