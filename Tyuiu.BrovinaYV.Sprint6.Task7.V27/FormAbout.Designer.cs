
namespace Tyuiu.BrovinaYV.Sprint6.Task7.V27
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.label_BYV = new System.Windows.Forms.Label();
            this.pictureBoxAvatar_BYV = new System.Windows.Forms.PictureBox();
            this.buttonClose_BYV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_BYV)).BeginInit();
            this.SuspendLayout();
            // 
            // label_BYV
            // 
            this.label_BYV.AutoSize = true;
            this.label_BYV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_BYV.Location = new System.Drawing.Point(247, 12);
            this.label_BYV.Name = "label_BYV";
            this.label_BYV.Size = new System.Drawing.Size(364, 153);
            this.label_BYV.TabIndex = 1;
            this.label_BYV.Text = resources.GetString("label_BYV.Text");
            // 
            // pictureBoxAvatar_BYV
            // 
            this.pictureBoxAvatar_BYV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_BYV.Image")));
            this.pictureBoxAvatar_BYV.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_BYV.Name = "pictureBoxAvatar_BYV";
            this.pictureBoxAvatar_BYV.Size = new System.Drawing.Size(229, 226);
            this.pictureBoxAvatar_BYV.TabIndex = 2;
            this.pictureBoxAvatar_BYV.TabStop = false;
            // 
            // buttonClose_BYV
            // 
            this.buttonClose_BYV.Location = new System.Drawing.Point(507, 210);
            this.buttonClose_BYV.Name = "buttonClose_BYV";
            this.buttonClose_BYV.Size = new System.Drawing.Size(104, 28);
            this.buttonClose_BYV.TabIndex = 3;
            this.buttonClose_BYV.Text = "OK";
            this.buttonClose_BYV.UseVisualStyleBackColor = true;
            this.buttonClose_BYV.Click += new System.EventHandler(this.buttonClose_BYV_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 247);
            this.Controls.Add(this.buttonClose_BYV);
            this.Controls.Add(this.pictureBoxAvatar_BYV);
            this.Controls.Add(this.label_BYV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_BYV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_BYV;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_BYV;
        private System.Windows.Forms.Button buttonClose_BYV;
    }
}