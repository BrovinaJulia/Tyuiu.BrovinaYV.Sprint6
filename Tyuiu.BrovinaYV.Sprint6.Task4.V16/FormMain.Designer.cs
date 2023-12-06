
namespace Tyuiu.BrovinaYV.Sprint6.Task4.V16
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_BYV = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_BYV = new System.Windows.Forms.GroupBox();
            this.buttonHelp_BYV = new System.Windows.Forms.Button();
            this.textBoxStopStep_BYV = new System.Windows.Forms.TextBox();
            this.buttonSave_BYV = new System.Windows.Forms.Button();
            this.buttonDone_BYV = new System.Windows.Forms.Button();
            this.textBoxStartStep_BYV = new System.Windows.Forms.TextBox();
            this.chartFunction_BYV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxRes_BYV = new System.Windows.Forms.GroupBox();
            this.textBoxResult_BYV = new System.Windows.Forms.TextBox();
            this.labelCondition_BYV = new System.Windows.Forms.Label();
            this.labelStart_BYV = new System.Windows.Forms.Label();
            this.labelEnd_BYV = new System.Windows.Forms.Label();
            this.groupBoxTask_BYV.SuspendLayout();
            this.groupBoxInput_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BYV)).BeginInit();
            this.groupBoxRes_BYV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_BYV
            // 
            this.groupBoxTask_BYV.Controls.Add(this.labelCondition_BYV);
            this.groupBoxTask_BYV.Controls.Add(this.buttonHelp_BYV);
            this.groupBoxTask_BYV.Controls.Add(this.groupBoxInput_BYV);
            this.groupBoxTask_BYV.Controls.Add(this.buttonSave_BYV);
            this.groupBoxTask_BYV.Controls.Add(this.buttonDone_BYV);
            this.groupBoxTask_BYV.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask_BYV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxTask_BYV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_BYV.Name = "groupBoxTask_BYV";
            this.groupBoxTask_BYV.Size = new System.Drawing.Size(1014, 89);
            this.groupBoxTask_BYV.TabIndex = 4;
            this.groupBoxTask_BYV.TabStop = false;
            this.groupBoxTask_BYV.Text = "Условие";
            // 
            // groupBoxInput_BYV
            // 
            this.groupBoxInput_BYV.Controls.Add(this.labelEnd_BYV);
            this.groupBoxInput_BYV.Controls.Add(this.labelStart_BYV);
            this.groupBoxInput_BYV.Controls.Add(this.textBoxStopStep_BYV);
            this.groupBoxInput_BYV.Controls.Add(this.textBoxStartStep_BYV);
            this.groupBoxInput_BYV.Location = new System.Drawing.Point(406, 0);
            this.groupBoxInput_BYV.Name = "groupBoxInput_BYV";
            this.groupBoxInput_BYV.Size = new System.Drawing.Size(241, 95);
            this.groupBoxInput_BYV.TabIndex = 6;
            this.groupBoxInput_BYV.TabStop = false;
            this.groupBoxInput_BYV.Text = "Ввод данных";
            // 
            // buttonHelp_BYV
            // 
            this.buttonHelp_BYV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_BYV.BackColor = System.Drawing.Color.Beige;
            this.buttonHelp_BYV.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelp_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_BYV.Location = new System.Drawing.Point(916, 21);
            this.buttonHelp_BYV.Name = "buttonHelp_BYV";
            this.buttonHelp_BYV.Size = new System.Drawing.Size(92, 57);
            this.buttonHelp_BYV.TabIndex = 12;
            this.buttonHelp_BYV.Text = "Справка";
            this.buttonHelp_BYV.UseVisualStyleBackColor = false;
            this.buttonHelp_BYV.Click += new System.EventHandler(this.buttonHelp_BYV_Click);
            // 
            // textBoxStopStep_BYV
            // 
            this.textBoxStopStep_BYV.Location = new System.Drawing.Point(121, 38);
            this.textBoxStopStep_BYV.Name = "textBoxStopStep_BYV";
            this.textBoxStopStep_BYV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_BYV.TabIndex = 3;
            this.textBoxStopStep_BYV.Text = "5";
            // 
            // buttonSave_BYV
            // 
            this.buttonSave_BYV.BackColor = System.Drawing.Color.Yellow;
            this.buttonSave_BYV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSave_BYV.Location = new System.Drawing.Point(775, 19);
            this.buttonSave_BYV.Name = "buttonSave_BYV";
            this.buttonSave_BYV.Size = new System.Drawing.Size(94, 58);
            this.buttonSave_BYV.TabIndex = 11;
            this.buttonSave_BYV.Text = "Сохранить";
            this.buttonSave_BYV.UseVisualStyleBackColor = false;
            this.buttonSave_BYV.Click += new System.EventHandler(this.buttonSave_BYV_Click);
            // 
            // buttonDone_BYV
            // 
            this.buttonDone_BYV.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonDone_BYV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_BYV.Location = new System.Drawing.Point(653, 17);
            this.buttonDone_BYV.Name = "buttonDone_BYV";
            this.buttonDone_BYV.Size = new System.Drawing.Size(94, 58);
            this.buttonDone_BYV.TabIndex = 10;
            this.buttonDone_BYV.Text = "Выполнить";
            this.buttonDone_BYV.UseVisualStyleBackColor = false;
            this.buttonDone_BYV.Click += new System.EventHandler(this.buttonDone_BYV_Click);
            // 
            // textBoxStartStep_BYV
            // 
            this.textBoxStartStep_BYV.Location = new System.Drawing.Point(6, 38);
            this.textBoxStartStep_BYV.Name = "textBoxStartStep_BYV";
            this.textBoxStartStep_BYV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_BYV.TabIndex = 0;
            this.textBoxStartStep_BYV.Text = "-5";
            // 
            // chartFunction_BYV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_BYV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_BYV.Legends.Add(legend1);
            this.chartFunction_BYV.Location = new System.Drawing.Point(187, 19);
            this.chartFunction_BYV.Name = "chartFunction_BYV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_BYV.Series.Add(series1);
            this.chartFunction_BYV.Size = new System.Drawing.Size(815, 345);
            this.chartFunction_BYV.TabIndex = 5;
            title1.Name = "TitleChart";
            title1.Text = "График функции";
            this.chartFunction_BYV.Titles.Add(title1);
            // 
            // groupBoxRes_BYV
            // 
            this.groupBoxRes_BYV.Controls.Add(this.chartFunction_BYV);
            this.groupBoxRes_BYV.Controls.Add(this.textBoxResult_BYV);
            this.groupBoxRes_BYV.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxRes_BYV.Location = new System.Drawing.Point(0, 89);
            this.groupBoxRes_BYV.Name = "groupBoxRes_BYV";
            this.groupBoxRes_BYV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxRes_BYV.Size = new System.Drawing.Size(1014, 382);
            this.groupBoxRes_BYV.TabIndex = 13;
            this.groupBoxRes_BYV.TabStop = false;
            this.groupBoxRes_BYV.Text = "Вывод";
            // 
            // textBoxResult_BYV
            // 
            this.textBoxResult_BYV.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_BYV.Multiline = true;
            this.textBoxResult_BYV.Name = "textBoxResult_BYV";
            this.textBoxResult_BYV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_BYV.Size = new System.Drawing.Size(168, 345);
            this.textBoxResult_BYV.TabIndex = 0;
            // 
            // labelCondition_BYV
            // 
            this.labelCondition_BYV.AutoSize = true;
            this.labelCondition_BYV.Location = new System.Drawing.Point(6, 21);
            this.labelCondition_BYV.Name = "labelCondition_BYV";
            this.labelCondition_BYV.Size = new System.Drawing.Size(322, 39);
            this.labelCondition_BYV.TabIndex = 13;
            this.labelCondition_BYV.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и \r\nсохранить в файл OutPutFileTask4V16.txt по н" +
    "ажатию кнопки. \r\n";
            // 
            // labelStart_BYV
            // 
            this.labelStart_BYV.AutoSize = true;
            this.labelStart_BYV.Location = new System.Drawing.Point(6, 19);
            this.labelStart_BYV.Name = "labelStart_BYV";
            this.labelStart_BYV.Size = new System.Drawing.Size(64, 13);
            this.labelStart_BYV.TabIndex = 5;
            this.labelStart_BYV.Text = "Старт шага";
            // 
            // labelEnd_BYV
            // 
            this.labelEnd_BYV.AutoSize = true;
            this.labelEnd_BYV.Location = new System.Drawing.Point(118, 19);
            this.labelEnd_BYV.Name = "labelEnd_BYV";
            this.labelEnd_BYV.Size = new System.Drawing.Size(66, 13);
            this.labelEnd_BYV.TabIndex = 6;
            this.labelEnd_BYV.Text = "Конец шага";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 471);
            this.Controls.Add(this.groupBoxRes_BYV);
            this.Controls.Add(this.groupBoxTask_BYV);
            this.MinimumSize = new System.Drawing.Size(1030, 510);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 19 | Бровина Ю. В.";
            this.groupBoxTask_BYV.ResumeLayout(false);
            this.groupBoxTask_BYV.PerformLayout();
            this.groupBoxInput_BYV.ResumeLayout(false);
            this.groupBoxInput_BYV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_BYV)).EndInit();
            this.groupBoxRes_BYV.ResumeLayout(false);
            this.groupBoxRes_BYV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_BYV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BYV;
        private System.Windows.Forms.GroupBox groupBoxInput_BYV;
        private System.Windows.Forms.TextBox textBoxStopStep_BYV;
        private System.Windows.Forms.TextBox textBoxStartStep_BYV;
        private System.Windows.Forms.Button buttonDone_BYV;
        private System.Windows.Forms.Button buttonSave_BYV;
        private System.Windows.Forms.Button buttonHelp_BYV;
        private System.Windows.Forms.GroupBox groupBoxRes_BYV;
        private System.Windows.Forms.TextBox textBoxResult_BYV;
        private System.Windows.Forms.Label labelCondition_BYV;
        private System.Windows.Forms.Label labelEnd_BYV;
        private System.Windows.Forms.Label labelStart_BYV;
    }
}

