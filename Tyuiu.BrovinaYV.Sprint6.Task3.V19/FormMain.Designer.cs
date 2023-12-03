
namespace Tyuiu.BrovinaYV.Sprint6.Task3.V19
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
            this.groupBoxTask_BYV = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_BYV = new System.Windows.Forms.TextBox();
            this.buttonDone_BYV = new System.Windows.Forms.Button();
            this.buttonHelp_BYV = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_BYV = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_BYV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_BYV
            // 
            this.groupBoxTask_BYV.Controls.Add(this.dataGridViewMatrix_BYV);
            this.groupBoxTask_BYV.Controls.Add(this.textBoxCondition_BYV);
            this.groupBoxTask_BYV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_BYV.Name = "groupBoxTask_BYV";
            this.groupBoxTask_BYV.Size = new System.Drawing.Size(572, 248);
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
            this.textBoxCondition_BYV.Size = new System.Drawing.Size(308, 128);
            this.textBoxCondition_BYV.TabIndex = 0;
            this.textBoxCondition_BYV.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в пятом столбце." +
    "\r\n \r\n   4  32 -20  27  21\r\n  17  15  -1  -2  -1\r\n  -3  18  12 -10  29\r\n   7 -15 " +
    "  2  -8  12\r\n -10  25   5  27  21";
            // 
            // buttonDone_BYV
            // 
            this.buttonDone_BYV.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonDone_BYV.Location = new System.Drawing.Point(635, 218);
            this.buttonDone_BYV.Name = "buttonDone_BYV";
            this.buttonDone_BYV.Size = new System.Drawing.Size(99, 36);
            this.buttonDone_BYV.TabIndex = 11;
            this.buttonDone_BYV.Text = "Выполнить";
            this.buttonDone_BYV.UseVisualStyleBackColor = false;
            this.buttonDone_BYV.Click += new System.EventHandler(this.buttonDone_BYV_Click);
            // 
            // buttonHelp_BYV
            // 
            this.buttonHelp_BYV.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonHelp_BYV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_BYV.Location = new System.Drawing.Point(590, 218);
            this.buttonHelp_BYV.Name = "buttonHelp_BYV";
            this.buttonHelp_BYV.Size = new System.Drawing.Size(39, 36);
            this.buttonHelp_BYV.TabIndex = 10;
            this.buttonHelp_BYV.Text = "?";
            this.buttonHelp_BYV.UseVisualStyleBackColor = false;
            this.buttonHelp_BYV.Click += new System.EventHandler(this.buttonHelp_BYV_Click);
            // 
            // dataGridViewMatrix_BYV
            // 
            this.dataGridViewMatrix_BYV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_BYV.Location = new System.Drawing.Point(320, 9);
            this.dataGridViewMatrix_BYV.Name = "dataGridViewMatrix_BYV";
            this.dataGridViewMatrix_BYV.ReadOnly = true;
            this.dataGridViewMatrix_BYV.RowHeadersVisible = false;
            this.dataGridViewMatrix_BYV.Size = new System.Drawing.Size(241, 233);
            this.dataGridViewMatrix_BYV.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 268);
            this.Controls.Add(this.buttonDone_BYV);
            this.Controls.Add(this.buttonHelp_BYV);
            this.Controls.Add(this.groupBoxTask_BYV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 19 | Бровина Ю. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_BYV.ResumeLayout(false);
            this.groupBoxTask_BYV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_BYV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_BYV;
        private System.Windows.Forms.TextBox textBoxCondition_BYV;
        private System.Windows.Forms.Button buttonDone_BYV;
        private System.Windows.Forms.Button buttonHelp_BYV;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_BYV;
    }
}

