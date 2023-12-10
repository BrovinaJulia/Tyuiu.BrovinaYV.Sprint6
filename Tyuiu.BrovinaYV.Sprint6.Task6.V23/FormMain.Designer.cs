
namespace Tyuiu.BrovinaYV.Sprint6.Task6.V23
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
            this.buttonDone_BYV = new System.Windows.Forms.Button();
            this.buttonHelp_BYV = new System.Windows.Forms.Button();
            this.buttonOpenFile_BYV = new System.Windows.Forms.Button();
            this.panelTopDown_BYV = new System.Windows.Forms.Panel();
            this.groupBoxTask_BYV = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_BYV = new System.Windows.Forms.TextBox();
            this.panelLeft_BYV = new System.Windows.Forms.Panel();
            this.groupBoxInput_BYV = new System.Windows.Forms.GroupBox();
            this.textBoxInput_BYV = new System.Windows.Forms.TextBox();
            this.panelRight_BYV = new System.Windows.Forms.Panel();
            this.splitter_BYV = new System.Windows.Forms.Splitter();
            this.groupBoxOutput_BYV = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_BYV = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_BYV = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_BYV = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_BYV.SuspendLayout();
            this.panelTopDown_BYV.SuspendLayout();
            this.groupBoxTask_BYV.SuspendLayout();
            this.panelLeft_BYV.SuspendLayout();
            this.groupBoxInput_BYV.SuspendLayout();
            this.panelRight_BYV.SuspendLayout();
            this.groupBoxOutput_BYV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_BYV
            // 
            this.panelTop_BYV.Controls.Add(this.buttonDone_BYV);
            this.panelTop_BYV.Controls.Add(this.buttonHelp_BYV);
            this.panelTop_BYV.Controls.Add(this.buttonOpenFile_BYV);
            this.panelTop_BYV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_BYV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_BYV.Name = "panelTop_BYV";
            this.panelTop_BYV.Size = new System.Drawing.Size(834, 80);
            this.panelTop_BYV.TabIndex = 0;
            // 
            // buttonDone_BYV
            // 
            this.buttonDone_BYV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_BYV.BackColor = System.Drawing.Color.Transparent;
            this.buttonDone_BYV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_BYV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_BYV.Image")));
            this.buttonDone_BYV.Location = new System.Drawing.Point(129, 9);
            this.buttonDone_BYV.Name = "buttonDone_BYV";
            this.buttonDone_BYV.Size = new System.Drawing.Size(97, 58);
            this.buttonDone_BYV.TabIndex = 16;
            this.toolTip_BYV.SetToolTip(this.buttonDone_BYV, "Производит поиск в файле вхождений в слово символа \"s\"\r\nи выводит все слова в стр" +
        "оку");
            this.buttonDone_BYV.UseVisualStyleBackColor = false;
            this.buttonDone_BYV.Click += new System.EventHandler(this.buttonDone_BYV_Click);
            // 
            // buttonHelp_BYV
            // 
            this.buttonHelp_BYV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_BYV.BackColor = System.Drawing.Color.Transparent;
            this.buttonHelp_BYV.Cursor = System.Windows.Forms.Cursors.Help;
            this.buttonHelp_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_BYV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_BYV.Image")));
            this.buttonHelp_BYV.Location = new System.Drawing.Point(730, 10);
            this.buttonHelp_BYV.Name = "buttonHelp_BYV";
            this.buttonHelp_BYV.Size = new System.Drawing.Size(92, 57);
            this.buttonHelp_BYV.TabIndex = 18;
            this.toolTip_BYV.SetToolTip(this.buttonHelp_BYV, "Сведения о программе");
            this.buttonHelp_BYV.UseVisualStyleBackColor = false;
            this.buttonHelp_BYV.Click += new System.EventHandler(this.buttonHelp_BYV_Click);
            // 
            // buttonOpenFile_BYV
            // 
            this.buttonOpenFile_BYV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile_BYV.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenFile_BYV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonOpenFile_BYV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_BYV.Image")));
            this.buttonOpenFile_BYV.Location = new System.Drawing.Point(29, 10);
            this.buttonOpenFile_BYV.Name = "buttonOpenFile_BYV";
            this.buttonOpenFile_BYV.Size = new System.Drawing.Size(94, 58);
            this.buttonOpenFile_BYV.TabIndex = 17;
            this.toolTip_BYV.SetToolTip(this.buttonOpenFile_BYV, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_BYV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_BYV.Click += new System.EventHandler(this.buttonOpenFile_BYV_Click);
            // 
            // panelTopDown_BYV
            // 
            this.panelTopDown_BYV.Controls.Add(this.groupBoxTask_BYV);
            this.panelTopDown_BYV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopDown_BYV.Location = new System.Drawing.Point(0, 80);
            this.panelTopDown_BYV.Name = "panelTopDown_BYV";
            this.panelTopDown_BYV.Size = new System.Drawing.Size(834, 83);
            this.panelTopDown_BYV.TabIndex = 1;
            // 
            // groupBoxTask_BYV
            // 
            this.groupBoxTask_BYV.Controls.Add(this.textBoxCondition_BYV);
            this.groupBoxTask_BYV.Location = new System.Drawing.Point(12, 6);
            this.groupBoxTask_BYV.Name = "groupBoxTask_BYV";
            this.groupBoxTask_BYV.Size = new System.Drawing.Size(777, 71);
            this.groupBoxTask_BYV.TabIndex = 4;
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
            this.textBoxCondition_BYV.Size = new System.Drawing.Size(765, 46);
            this.textBoxCondition_BYV.TabIndex = 0;
            this.textBoxCondition_BYV.Text = resources.GetString("textBoxCondition_BYV.Text");
            // 
            // panelLeft_BYV
            // 
            this.panelLeft_BYV.Controls.Add(this.groupBoxInput_BYV);
            this.panelLeft_BYV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_BYV.Location = new System.Drawing.Point(0, 163);
            this.panelLeft_BYV.Name = "panelLeft_BYV";
            this.panelLeft_BYV.Size = new System.Drawing.Size(401, 382);
            this.panelLeft_BYV.TabIndex = 2;
            // 
            // groupBoxInput_BYV
            // 
            this.groupBoxInput_BYV.Controls.Add(this.textBoxInput_BYV);
            this.groupBoxInput_BYV.Location = new System.Drawing.Point(12, 6);
            this.groupBoxInput_BYV.Name = "groupBoxInput_BYV";
            this.groupBoxInput_BYV.Size = new System.Drawing.Size(361, 364);
            this.groupBoxInput_BYV.TabIndex = 5;
            this.groupBoxInput_BYV.TabStop = false;
            this.groupBoxInput_BYV.Text = "Ввод";
            // 
            // textBoxInput_BYV
            // 
            this.textBoxInput_BYV.Location = new System.Drawing.Point(6, 19);
            this.textBoxInput_BYV.Multiline = true;
            this.textBoxInput_BYV.Name = "textBoxInput_BYV";
            this.textBoxInput_BYV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_BYV.Size = new System.Drawing.Size(354, 344);
            this.textBoxInput_BYV.TabIndex = 0;
            // 
            // panelRight_BYV
            // 
            this.panelRight_BYV.Controls.Add(this.splitter_BYV);
            this.panelRight_BYV.Controls.Add(this.groupBoxOutput_BYV);
            this.panelRight_BYV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_BYV.Location = new System.Drawing.Point(401, 163);
            this.panelRight_BYV.Name = "panelRight_BYV";
            this.panelRight_BYV.Size = new System.Drawing.Size(433, 382);
            this.panelRight_BYV.TabIndex = 3;
            // 
            // splitter_BYV
            // 
            this.splitter_BYV.Location = new System.Drawing.Point(0, 0);
            this.splitter_BYV.Name = "splitter_BYV";
            this.splitter_BYV.Size = new System.Drawing.Size(10, 382);
            this.splitter_BYV.TabIndex = 7;
            this.splitter_BYV.TabStop = false;
            // 
            // groupBoxOutput_BYV
            // 
            this.groupBoxOutput_BYV.Controls.Add(this.textBoxOutput_BYV);
            this.groupBoxOutput_BYV.Location = new System.Drawing.Point(14, 6);
            this.groupBoxOutput_BYV.Name = "groupBoxOutput_BYV";
            this.groupBoxOutput_BYV.Size = new System.Drawing.Size(416, 376);
            this.groupBoxOutput_BYV.TabIndex = 6;
            this.groupBoxOutput_BYV.TabStop = false;
            this.groupBoxOutput_BYV.Text = "Вывод";
            // 
            // textBoxOutput_BYV
            // 
            this.textBoxOutput_BYV.Location = new System.Drawing.Point(6, 43);
            this.textBoxOutput_BYV.Multiline = true;
            this.textBoxOutput_BYV.Name = "textBoxOutput_BYV";
            this.textBoxOutput_BYV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_BYV.Size = new System.Drawing.Size(382, 320);
            this.textBoxOutput_BYV.TabIndex = 1;
            // 
            // toolTip_BYV
            // 
            this.toolTip_BYV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_BYV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 545);
            this.Controls.Add(this.panelRight_BYV);
            this.Controls.Add(this.panelLeft_BYV);
            this.Controls.Add(this.panelTopDown_BYV);
            this.Controls.Add(this.panelTop_BYV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 23 | Бровина Ю. В.";
            this.panelTop_BYV.ResumeLayout(false);
            this.panelTopDown_BYV.ResumeLayout(false);
            this.groupBoxTask_BYV.ResumeLayout(false);
            this.groupBoxTask_BYV.PerformLayout();
            this.panelLeft_BYV.ResumeLayout(false);
            this.groupBoxInput_BYV.ResumeLayout(false);
            this.groupBoxInput_BYV.PerformLayout();
            this.panelRight_BYV.ResumeLayout(false);
            this.groupBoxOutput_BYV.ResumeLayout(false);
            this.groupBoxOutput_BYV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_BYV;
        private System.Windows.Forms.Panel panelTopDown_BYV;
        private System.Windows.Forms.Panel panelLeft_BYV;
        private System.Windows.Forms.Panel panelRight_BYV;
        private System.Windows.Forms.GroupBox groupBoxTask_BYV;
        private System.Windows.Forms.TextBox textBoxCondition_BYV;
        private System.Windows.Forms.GroupBox groupBoxInput_BYV;
        private System.Windows.Forms.TextBox textBoxInput_BYV;
        private System.Windows.Forms.GroupBox groupBoxOutput_BYV;
        private System.Windows.Forms.TextBox textBoxOutput_BYV;
        private System.Windows.Forms.Button buttonDone_BYV;
        private System.Windows.Forms.Button buttonHelp_BYV;
        private System.Windows.Forms.Button buttonOpenFile_BYV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_BYV;
        private System.Windows.Forms.ToolTip toolTip_BYV;
        private System.Windows.Forms.Splitter splitter_BYV;
    }
}

