
namespace Tyuiu.BrovinaYV.Sprint6.Task1.V14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_BYV = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_BYV = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_BYV = new System.Windows.Forms.TextBox();
            this.groupBoxInput_BYV = new System.Windows.Forms.GroupBox();
            this.textBoxStart_BYV = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_BYV = new System.Windows.Forms.TextBox();
            this.textBoxEnd_BYV = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_BYV = new System.Windows.Forms.TextBox();
            this.buttonHelp_BYV = new System.Windows.Forms.Button();
            this.buttonDone_BYV = new System.Windows.Forms.Button();
            this.groupBoxResult_BYV = new System.Windows.Forms.GroupBox();
            this.textBoxRes_BYV = new System.Windows.Forms.TextBox();
            this.textBoxResult_BYV = new System.Windows.Forms.TextBox();
            this.groupBoxTask_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BYV)).BeginInit();
            this.groupBoxInput_BYV.SuspendLayout();
            this.groupBoxResult_BYV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_BYV
            // 
            this.groupBoxTask_BYV.Controls.Add(this.pictureBoxFormula_BYV);
            this.groupBoxTask_BYV.Controls.Add(this.textBoxCondition_BYV);
            this.groupBoxTask_BYV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_BYV.Name = "groupBoxTask_BYV";
            this.groupBoxTask_BYV.Size = new System.Drawing.Size(541, 155);
            this.groupBoxTask_BYV.TabIndex = 1;
            this.groupBoxTask_BYV.TabStop = false;
            this.groupBoxTask_BYV.Text = "Условие";
            // 
            // pictureBoxFormula_BYV
            // 
            this.pictureBoxFormula_BYV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_BYV.Image")));
            this.pictureBoxFormula_BYV.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_BYV.InitialImage")));
            this.pictureBoxFormula_BYV.Location = new System.Drawing.Point(317, 19);
            this.pictureBoxFormula_BYV.Name = "pictureBoxFormula_BYV";
            this.pictureBoxFormula_BYV.Size = new System.Drawing.Size(211, 49);
            this.pictureBoxFormula_BYV.TabIndex = 1;
            this.pictureBoxFormula_BYV.TabStop = false;
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
            this.textBoxCondition_BYV.Size = new System.Drawing.Size(305, 67);
            this.textBoxCondition_BYV.TabIndex = 0;
            this.textBoxCondition_BYV.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в виде таб" +
    "лицы.\r\n";
            // 
            // groupBoxInput_BYV
            // 
            this.groupBoxInput_BYV.Controls.Add(this.textBoxEnd_BYV);
            this.groupBoxInput_BYV.Controls.Add(this.textBoxStopStep_BYV);
            this.groupBoxInput_BYV.Controls.Add(this.textBoxStart_BYV);
            this.groupBoxInput_BYV.Controls.Add(this.textBoxStartStep_BYV);
            this.groupBoxInput_BYV.Location = new System.Drawing.Point(12, 173);
            this.groupBoxInput_BYV.Name = "groupBoxInput_BYV";
            this.groupBoxInput_BYV.Size = new System.Drawing.Size(281, 66);
            this.groupBoxInput_BYV.TabIndex = 2;
            this.groupBoxInput_BYV.TabStop = false;
            this.groupBoxInput_BYV.Text = "Ввод данных";
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
            // buttonHelp_BYV
            // 
            this.buttonHelp_BYV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_BYV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_BYV.Location = new System.Drawing.Point(299, 177);
            this.buttonHelp_BYV.Name = "buttonHelp_BYV";
            this.buttonHelp_BYV.Size = new System.Drawing.Size(96, 62);
            this.buttonHelp_BYV.TabIndex = 7;
            this.buttonHelp_BYV.Text = "Справка";
            this.buttonHelp_BYV.UseVisualStyleBackColor = false;
            this.buttonHelp_BYV.Click += new System.EventHandler(this.buttonHelp_BYV_Click);
            // 
            // buttonDone_BYV
            // 
            this.buttonDone_BYV.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonDone_BYV.Location = new System.Drawing.Point(414, 177);
            this.buttonDone_BYV.Name = "buttonDone_BYV";
            this.buttonDone_BYV.Size = new System.Drawing.Size(126, 62);
            this.buttonDone_BYV.TabIndex = 6;
            this.buttonDone_BYV.Text = "Выполнить";
            this.buttonDone_BYV.UseVisualStyleBackColor = false;
            this.buttonDone_BYV.Click += new System.EventHandler(this.buttonDone_BYV_Click);
            // 
            // groupBoxResult_BYV
            // 
            this.groupBoxResult_BYV.Controls.Add(this.textBoxResult_BYV);
            this.groupBoxResult_BYV.Controls.Add(this.textBoxRes_BYV);
            this.groupBoxResult_BYV.Location = new System.Drawing.Point(559, 12);
            this.groupBoxResult_BYV.Name = "groupBoxResult_BYV";
            this.groupBoxResult_BYV.Size = new System.Drawing.Size(275, 338);
            this.groupBoxResult_BYV.TabIndex = 8;
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
            // textBoxResult_BYV
            // 
            this.textBoxResult_BYV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_BYV.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult_BYV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxResult_BYV.Location = new System.Drawing.Point(6, 38);
            this.textBoxResult_BYV.Multiline = true;
            this.textBoxResult_BYV.Name = "textBoxResult_BYV";
            this.textBoxResult_BYV.ReadOnly = true;
            this.textBoxResult_BYV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_BYV.Size = new System.Drawing.Size(263, 294);
            this.textBoxResult_BYV.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.groupBoxResult_BYV);
            this.Controls.Add(this.buttonHelp_BYV);
            this.Controls.Add(this.buttonDone_BYV);
            this.Controls.Add(this.groupBoxInput_BYV);
            this.Controls.Add(this.groupBoxTask_BYV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 14 | Бровина Ю. В.";
            this.groupBoxTask_BYV.ResumeLayout(false);
            this.groupBoxTask_BYV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BYV)).EndInit();
            this.groupBoxInput_BYV.ResumeLayout(false);
            this.groupBoxInput_BYV.PerformLayout();
            this.groupBoxResult_BYV.ResumeLayout(false);
            this.groupBoxResult_BYV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_BYV;
        private System.Windows.Forms.PictureBox pictureBoxFormula_BYV;
        private System.Windows.Forms.TextBox textBoxCondition_BYV;
        private System.Windows.Forms.GroupBox groupBoxInput_BYV;
        private System.Windows.Forms.TextBox textBoxEnd_BYV;
        private System.Windows.Forms.TextBox textBoxStopStep_BYV;
        private System.Windows.Forms.TextBox textBoxStart_BYV;
        private System.Windows.Forms.TextBox textBoxStartStep_BYV;
        private System.Windows.Forms.Button buttonHelp_BYV;
        private System.Windows.Forms.Button buttonDone_BYV;
        private System.Windows.Forms.GroupBox groupBoxResult_BYV;
        private System.Windows.Forms.TextBox textBoxResult_BYV;
        private System.Windows.Forms.TextBox textBoxRes_BYV;
    }
}

