
namespace Tyuiu.BrovinaYV.Sprint6.Task7.V27
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_BYV = new System.Windows.Forms.Panel();
            this.buttonOpenFile_BYV = new System.Windows.Forms.Button();
            this.buttonDone_BYV = new System.Windows.Forms.Button();
            this.buttonSave_BYV = new System.Windows.Forms.Button();
            this.buttonHelp_BYV = new System.Windows.Forms.Button();
            this.panelTopDown_BYV = new System.Windows.Forms.Panel();
            this.groupBoxTask_BYV = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_BYV = new System.Windows.Forms.TextBox();
            this.panelFill_BYV = new System.Windows.Forms.Panel();
            this.splitContainer_BYV = new System.Windows.Forms.SplitContainer();
            this.groupBoxInput_BYV = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_BYV = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput_BYV = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutput_BYV = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_BYV = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_BYV = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_BYV = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_BYV.SuspendLayout();
            this.panelTopDown_BYV.SuspendLayout();
            this.groupBoxTask_BYV.SuspendLayout();
            this.panelFill_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_BYV)).BeginInit();
            this.splitContainer_BYV.Panel1.SuspendLayout();
            this.splitContainer_BYV.Panel2.SuspendLayout();
            this.splitContainer_BYV.SuspendLayout();
            this.groupBoxInput_BYV.SuspendLayout();
            this.groupBoxOutPut_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_BYV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_BYV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_BYV
            // 
            this.panelTop_BYV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTop_BYV.Controls.Add(this.buttonHelp_BYV);
            this.panelTop_BYV.Controls.Add(this.buttonSave_BYV);
            this.panelTop_BYV.Controls.Add(this.buttonDone_BYV);
            this.panelTop_BYV.Controls.Add(this.buttonOpenFile_BYV);
            this.panelTop_BYV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_BYV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_BYV.Name = "panelTop_BYV";
            this.panelTop_BYV.Size = new System.Drawing.Size(927, 75);
            this.panelTop_BYV.TabIndex = 0;
            // 
            // buttonOpenFile_BYV
            // 
            this.buttonOpenFile_BYV.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenFile_BYV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_BYV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonOpenFile_BYV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_BYV.Image")));
            this.buttonOpenFile_BYV.Location = new System.Drawing.Point(13, 7);
            this.buttonOpenFile_BYV.Name = "buttonOpenFile_BYV";
            this.buttonOpenFile_BYV.Size = new System.Drawing.Size(94, 58);
            this.buttonOpenFile_BYV.TabIndex = 18;
            this.toolTipButton_BYV.SetToolTip(this.buttonOpenFile_BYV, "Выберите нужный файл для обработки");
            this.buttonOpenFile_BYV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_BYV.Click += new System.EventHandler(this.buttonOpenFile_BYV_Click);
            this.buttonOpenFile_BYV.MouseEnter += new System.EventHandler(this.buttonOpenFile_BYV_MouseEnter);
            // 
            // buttonDone_BYV
            // 
            this.buttonDone_BYV.BackColor = System.Drawing.Color.Transparent;
            this.buttonDone_BYV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_BYV.Enabled = false;
            this.buttonDone_BYV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_BYV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_BYV.Image")));
            this.buttonDone_BYV.Location = new System.Drawing.Point(113, 7);
            this.buttonDone_BYV.Name = "buttonDone_BYV";
            this.buttonDone_BYV.Size = new System.Drawing.Size(97, 58);
            this.buttonDone_BYV.TabIndex = 19;
            this.toolTipButton_BYV.SetToolTip(this.buttonDone_BYV, "Производит поиск отрицательных чисел в пятой строке и\r\nзаменяет их на -1.");
            this.buttonDone_BYV.UseVisualStyleBackColor = false;
            this.buttonDone_BYV.Click += new System.EventHandler(this.buttonDone_BYV_Click);
            this.buttonDone_BYV.MouseEnter += new System.EventHandler(this.buttonDone_BYV_MouseEnter);
            // 
            // buttonSave_BYV
            // 
            this.buttonSave_BYV.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave_BYV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_BYV.Enabled = false;
            this.buttonSave_BYV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_BYV.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_BYV.Image")));
            this.buttonSave_BYV.Location = new System.Drawing.Point(216, 7);
            this.buttonSave_BYV.Name = "buttonSave_BYV";
            this.buttonSave_BYV.Size = new System.Drawing.Size(97, 58);
            this.buttonSave_BYV.TabIndex = 20;
            this.toolTipButton_BYV.SetToolTip(this.buttonSave_BYV, "Сохранение файла на указанную директорию.");
            this.buttonSave_BYV.UseVisualStyleBackColor = false;
            this.buttonSave_BYV.Click += new System.EventHandler(this.buttonSave_BYV_Click);
            this.buttonSave_BYV.MouseEnter += new System.EventHandler(this.buttonSave_BYV_MouseEnter);
            // 
            // buttonHelp_BYV
            // 
            this.buttonHelp_BYV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_BYV.BackColor = System.Drawing.Color.Transparent;
            this.buttonHelp_BYV.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelp_BYV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_BYV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_BYV.Image")));
            this.buttonHelp_BYV.Location = new System.Drawing.Point(819, 9);
            this.buttonHelp_BYV.Name = "buttonHelp_BYV";
            this.buttonHelp_BYV.Size = new System.Drawing.Size(92, 57);
            this.buttonHelp_BYV.TabIndex = 21;
            this.toolTipButton_BYV.SetToolTip(this.buttonHelp_BYV, "Узнать, кто автор программы.");
            this.buttonHelp_BYV.UseVisualStyleBackColor = false;
            this.buttonHelp_BYV.Click += new System.EventHandler(this.buttonHelp_BYV_Click);
            this.buttonHelp_BYV.MouseEnter += new System.EventHandler(this.buttonHelp_BYV_MouseEnter);
            // 
            // panelTopDown_BYV
            // 
            this.panelTopDown_BYV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTopDown_BYV.Controls.Add(this.groupBoxTask_BYV);
            this.panelTopDown_BYV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopDown_BYV.Location = new System.Drawing.Point(0, 75);
            this.panelTopDown_BYV.Name = "panelTopDown_BYV";
            this.panelTopDown_BYV.Size = new System.Drawing.Size(927, 70);
            this.panelTopDown_BYV.TabIndex = 1;
            // 
            // groupBoxTask_BYV
            // 
            this.groupBoxTask_BYV.Controls.Add(this.textBoxCondition_BYV);
            this.groupBoxTask_BYV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_BYV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_BYV.Name = "groupBoxTask_BYV";
            this.groupBoxTask_BYV.Size = new System.Drawing.Size(923, 66);
            this.groupBoxTask_BYV.TabIndex = 5;
            this.groupBoxTask_BYV.TabStop = false;
            this.groupBoxTask_BYV.Text = "Условие";
            // 
            // textBoxCondition_BYV
            // 
            this.textBoxCondition_BYV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_BYV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCondition_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxCondition_BYV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxCondition_BYV.Location = new System.Drawing.Point(3, 16);
            this.textBoxCondition_BYV.Multiline = true;
            this.textBoxCondition_BYV.Name = "textBoxCondition_BYV";
            this.textBoxCondition_BYV.ReadOnly = true;
            this.textBoxCondition_BYV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxCondition_BYV.Size = new System.Drawing.Size(917, 47);
            this.textBoxCondition_BYV.TabIndex = 0;
            this.textBoxCondition_BYV.Text = resources.GetString("textBoxCondition_BYV.Text");
            // 
            // panelFill_BYV
            // 
            this.panelFill_BYV.Controls.Add(this.splitContainer_BYV);
            this.panelFill_BYV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_BYV.Location = new System.Drawing.Point(0, 145);
            this.panelFill_BYV.Name = "panelFill_BYV";
            this.panelFill_BYV.Size = new System.Drawing.Size(927, 305);
            this.panelFill_BYV.TabIndex = 2;
            // 
            // splitContainer_BYV
            // 
            this.splitContainer_BYV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_BYV.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_BYV.Name = "splitContainer_BYV";
            // 
            // splitContainer_BYV.Panel1
            // 
            this.splitContainer_BYV.Panel1.Controls.Add(this.groupBoxInput_BYV);
            // 
            // splitContainer_BYV.Panel2
            // 
            this.splitContainer_BYV.Panel2.Controls.Add(this.groupBoxOutPut_BYV);
            this.splitContainer_BYV.Size = new System.Drawing.Size(927, 305);
            this.splitContainer_BYV.SplitterDistance = 444;
            this.splitContainer_BYV.TabIndex = 0;
            // 
            // groupBoxInput_BYV
            // 
            this.groupBoxInput_BYV.Controls.Add(this.dataGridViewInput_BYV);
            this.groupBoxInput_BYV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_BYV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_BYV.Name = "groupBoxInput_BYV";
            this.groupBoxInput_BYV.Size = new System.Drawing.Size(444, 305);
            this.groupBoxInput_BYV.TabIndex = 6;
            this.groupBoxInput_BYV.TabStop = false;
            this.groupBoxInput_BYV.Text = "Ввод";
            // 
            // groupBoxOutPut_BYV
            // 
            this.groupBoxOutPut_BYV.Controls.Add(this.dataGridViewOutput_BYV);
            this.groupBoxOutPut_BYV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_BYV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_BYV.Name = "groupBoxOutPut_BYV";
            this.groupBoxOutPut_BYV.Size = new System.Drawing.Size(479, 305);
            this.groupBoxOutPut_BYV.TabIndex = 7;
            this.groupBoxOutPut_BYV.TabStop = false;
            this.groupBoxOutPut_BYV.Text = "Вывод";
            // 
            // dataGridViewInput_BYV
            // 
            this.dataGridViewInput_BYV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_BYV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput_BYV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInput_BYV.Name = "dataGridViewInput_BYV";
            this.dataGridViewInput_BYV.Size = new System.Drawing.Size(438, 286);
            this.dataGridViewInput_BYV.TabIndex = 0;
            // 
            // dataGridViewOutput_BYV
            // 
            this.dataGridViewOutput_BYV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_BYV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutput_BYV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutput_BYV.Name = "dataGridViewOutput_BYV";
            this.dataGridViewOutput_BYV.Size = new System.Drawing.Size(473, 286);
            this.dataGridViewOutput_BYV.TabIndex = 1;
            // 
            // openFileDialogTask_BYV
            // 
            this.openFileDialogTask_BYV.FileName = "openFileDialog1";
            // 
            // toolTipButton_BYV
            // 
            this.toolTipButton_BYV.IsBalloon = true;
            this.toolTipButton_BYV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.panelFill_BYV);
            this.Controls.Add(this.panelTopDown_BYV);
            this.Controls.Add(this.panelTop_BYV);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 27 | Бровина Ю. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_BYV.ResumeLayout(false);
            this.panelTopDown_BYV.ResumeLayout(false);
            this.groupBoxTask_BYV.ResumeLayout(false);
            this.groupBoxTask_BYV.PerformLayout();
            this.panelFill_BYV.ResumeLayout(false);
            this.splitContainer_BYV.Panel1.ResumeLayout(false);
            this.splitContainer_BYV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_BYV)).EndInit();
            this.splitContainer_BYV.ResumeLayout(false);
            this.groupBoxInput_BYV.ResumeLayout(false);
            this.groupBoxOutPut_BYV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_BYV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_BYV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_BYV;
        private System.Windows.Forms.Button buttonOpenFile_BYV;
        private System.Windows.Forms.Button buttonDone_BYV;
        private System.Windows.Forms.Button buttonSave_BYV;
        private System.Windows.Forms.Button buttonHelp_BYV;
        private System.Windows.Forms.Panel panelTopDown_BYV;
        private System.Windows.Forms.GroupBox groupBoxTask_BYV;
        private System.Windows.Forms.TextBox textBoxCondition_BYV;
        private System.Windows.Forms.Panel panelFill_BYV;
        private System.Windows.Forms.SplitContainer splitContainer_BYV;
        private System.Windows.Forms.GroupBox groupBoxInput_BYV;
        private System.Windows.Forms.DataGridView dataGridViewInput_BYV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_BYV;
        private System.Windows.Forms.DataGridView dataGridViewOutput_BYV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_BYV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_BYV;
        private System.Windows.Forms.ToolTip toolTipButton_BYV;
    }
}

