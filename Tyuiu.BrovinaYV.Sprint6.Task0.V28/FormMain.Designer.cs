
namespace Tyuiu.BrovinaYV.Sprint6.Task0.V28
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
            this.textBoxCondition_BYV = new System.Windows.Forms.TextBox();
            this.groupBoxInput_BYV = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_BYV = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_BYV = new System.Windows.Forms.PictureBox();
            this.textBoxX_BYV = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_BYV = new System.Windows.Forms.GroupBox();
            this.textBoxRes_BYV = new System.Windows.Forms.TextBox();
            this.textBoxResult_BYV = new System.Windows.Forms.TextBox();
            this.buttonDone_BYV = new System.Windows.Forms.Button();
            this.buttonHelp_BYV = new System.Windows.Forms.Button();
            this.groupBoxTask_BYV.SuspendLayout();
            this.groupBoxInput_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BYV)).BeginInit();
            this.groupBoxOutput_BYV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_BYV
            // 
            this.groupBoxTask_BYV.Controls.Add(this.pictureBoxFormula_BYV);
            this.groupBoxTask_BYV.Controls.Add(this.textBoxCondition_BYV);
            this.groupBoxTask_BYV.Location = new System.Drawing.Point(11, 19);
            this.groupBoxTask_BYV.Name = "groupBoxTask_BYV";
            this.groupBoxTask_BYV.Size = new System.Drawing.Size(472, 92);
            this.groupBoxTask_BYV.TabIndex = 0;
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
            this.textBoxCondition_BYV.Size = new System.Drawing.Size(207, 67);
            this.textBoxCondition_BYV.TabIndex = 0;
            this.textBoxCondition_BYV.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput_BYV
            // 
            this.groupBoxInput_BYV.Controls.Add(this.textBoxX_BYV);
            this.groupBoxInput_BYV.Controls.Add(this.textBoxVarX_BYV);
            this.groupBoxInput_BYV.Location = new System.Drawing.Point(11, 127);
            this.groupBoxInput_BYV.Name = "groupBoxInput_BYV";
            this.groupBoxInput_BYV.Size = new System.Drawing.Size(163, 97);
            this.groupBoxInput_BYV.TabIndex = 1;
            this.groupBoxInput_BYV.TabStop = false;
            this.groupBoxInput_BYV.Text = "Ввод данных";
            // 
            // textBoxVarX_BYV
            // 
            this.textBoxVarX_BYV.Location = new System.Drawing.Point(6, 46);
            this.textBoxVarX_BYV.Name = "textBoxVarX_BYV";
            this.textBoxVarX_BYV.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_BYV.TabIndex = 0;
            this.textBoxVarX_BYV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_BYV_KeyPress);
            // 
            // pictureBoxFormula_BYV
            // 
            this.pictureBoxFormula_BYV.Image = global::Tyuiu.BrovinaYV.Sprint6.Task0.V28.Properties.Resources.Task0V28;
            this.pictureBoxFormula_BYV.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_BYV.InitialImage")));
            this.pictureBoxFormula_BYV.Location = new System.Drawing.Point(219, 19);
            this.pictureBoxFormula_BYV.Name = "pictureBoxFormula_BYV";
            this.pictureBoxFormula_BYV.Size = new System.Drawing.Size(244, 39);
            this.pictureBoxFormula_BYV.TabIndex = 1;
            this.pictureBoxFormula_BYV.TabStop = false;
            // 
            // textBoxX_BYV
            // 
            this.textBoxX_BYV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxX_BYV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxX_BYV.Location = new System.Drawing.Point(6, 27);
            this.textBoxX_BYV.Name = "textBoxX_BYV";
            this.textBoxX_BYV.ReadOnly = true;
            this.textBoxX_BYV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxX_BYV.Size = new System.Drawing.Size(111, 13);
            this.textBoxX_BYV.TabIndex = 2;
            this.textBoxX_BYV.Text = "Переменная X:";
            // 
            // groupBoxOutput_BYV
            // 
            this.groupBoxOutput_BYV.Controls.Add(this.textBoxRes_BYV);
            this.groupBoxOutput_BYV.Controls.Add(this.textBoxResult_BYV);
            this.groupBoxOutput_BYV.Location = new System.Drawing.Point(188, 127);
            this.groupBoxOutput_BYV.Name = "groupBoxOutput_BYV";
            this.groupBoxOutput_BYV.Size = new System.Drawing.Size(163, 97);
            this.groupBoxOutput_BYV.TabIndex = 3;
            this.groupBoxOutput_BYV.TabStop = false;
            this.groupBoxOutput_BYV.Text = "Вывод данных";
            // 
            // textBoxRes_BYV
            // 
            this.textBoxRes_BYV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRes_BYV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxRes_BYV.Location = new System.Drawing.Point(6, 27);
            this.textBoxRes_BYV.Name = "textBoxRes_BYV";
            this.textBoxRes_BYV.ReadOnly = true;
            this.textBoxRes_BYV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxRes_BYV.Size = new System.Drawing.Size(100, 13);
            this.textBoxRes_BYV.TabIndex = 2;
            this.textBoxRes_BYV.Text = "Результат:";
            // 
            // textBoxResult_BYV
            // 
            this.textBoxResult_BYV.Location = new System.Drawing.Point(6, 46);
            this.textBoxResult_BYV.Name = "textBoxResult_BYV";
            this.textBoxResult_BYV.ReadOnly = true;
            this.textBoxResult_BYV.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_BYV.TabIndex = 0;
            // 
            // buttonDone_BYV
            // 
            this.buttonDone_BYV.Location = new System.Drawing.Point(357, 131);
            this.buttonDone_BYV.Name = "buttonDone_BYV";
            this.buttonDone_BYV.Size = new System.Drawing.Size(126, 36);
            this.buttonDone_BYV.TabIndex = 4;
            this.buttonDone_BYV.Text = "Выполнить";
            this.buttonDone_BYV.UseVisualStyleBackColor = true;
            this.buttonDone_BYV.Click += new System.EventHandler(this.buttonDone_BYV_Click);
            // 
            // buttonHelp_BYV
            // 
            this.buttonHelp_BYV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_BYV.Location = new System.Drawing.Point(401, 179);
            this.buttonHelp_BYV.Name = "buttonHelp_BYV";
            this.buttonHelp_BYV.Size = new System.Drawing.Size(43, 36);
            this.buttonHelp_BYV.TabIndex = 5;
            this.buttonHelp_BYV.Text = "?";
            this.buttonHelp_BYV.UseVisualStyleBackColor = true;
            this.buttonHelp_BYV.Click += new System.EventHandler(this.buttonHelp_BYV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 229);
            this.Controls.Add(this.buttonHelp_BYV);
            this.Controls.Add(this.buttonDone_BYV);
            this.Controls.Add(this.groupBoxOutput_BYV);
            this.Controls.Add(this.groupBoxInput_BYV);
            this.Controls.Add(this.groupBoxTask_BYV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 28 | Бровина Ю. В.";
            this.groupBoxTask_BYV.ResumeLayout(false);
            this.groupBoxTask_BYV.PerformLayout();
            this.groupBoxInput_BYV.ResumeLayout(false);
            this.groupBoxInput_BYV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BYV)).EndInit();
            this.groupBoxOutput_BYV.ResumeLayout(false);
            this.groupBoxOutput_BYV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_BYV;
        private System.Windows.Forms.PictureBox pictureBoxFormula_BYV;
        private System.Windows.Forms.TextBox textBoxCondition_BYV;
        private System.Windows.Forms.GroupBox groupBoxInput_BYV;
        private System.Windows.Forms.TextBox textBoxVarX_BYV;
        private System.Windows.Forms.TextBox textBoxX_BYV;
        private System.Windows.Forms.GroupBox groupBoxOutput_BYV;
        private System.Windows.Forms.TextBox textBoxRes_BYV;
        private System.Windows.Forms.TextBox textBoxResult_BYV;
        private System.Windows.Forms.Button buttonDone_BYV;
        private System.Windows.Forms.Button buttonHelp_BYV;
    }
}

