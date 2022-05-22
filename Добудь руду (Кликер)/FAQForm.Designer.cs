
namespace Развиваемся
{
    partial class FAQForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAQForm));
            this.CloseButt = new System.Windows.Forms.Button();
            this.FAQLabel = new System.Windows.Forms.Label();
            this.PassFAQLabel = new System.Windows.Forms.Label();
            this.ActFAQLabel = new System.Windows.Forms.Label();
            this.ActPictureBox = new System.Windows.Forms.PictureBox();
            this.PassPictureBox = new System.Windows.Forms.PictureBox();
            this.PozitiveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ActPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButt
            // 
            this.CloseButt.Location = new System.Drawing.Point(296, 157);
            this.CloseButt.Name = "CloseButt";
            this.CloseButt.Size = new System.Drawing.Size(82, 31);
            this.CloseButt.TabIndex = 0;
            this.CloseButt.Text = "Закрыть";
            this.CloseButt.UseVisualStyleBackColor = true;
            this.CloseButt.Click += new System.EventHandler(this.CloseButt_Click);
            // 
            // FAQLabel
            // 
            this.FAQLabel.AutoSize = true;
            this.FAQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.FAQLabel.Location = new System.Drawing.Point(118, 9);
            this.FAQLabel.Name = "FAQLabel";
            this.FAQLabel.Size = new System.Drawing.Size(149, 29);
            this.FAQLabel.TabIndex = 1;
            this.FAQLabel.Text = "Пояснения:";
            // 
            // PassFAQLabel
            // 
            this.PassFAQLabel.AutoSize = true;
            this.PassFAQLabel.Location = new System.Drawing.Point(50, 60);
            this.PassFAQLabel.Name = "PassFAQLabel";
            this.PassFAQLabel.Size = new System.Drawing.Size(297, 13);
            this.PassFAQLabel.TabIndex = 3;
            this.PassFAQLabel.Text = "- Пассивный заработок. Каждую секунду обновляет счет";
            // 
            // ActFAQLabel
            // 
            this.ActFAQLabel.AutoSize = true;
            this.ActFAQLabel.Location = new System.Drawing.Point(50, 111);
            this.ActFAQLabel.Name = "ActFAQLabel";
            this.ActFAQLabel.Size = new System.Drawing.Size(186, 13);
            this.ActFAQLabel.TabIndex = 5;
            this.ActFAQLabel.Text = " - Общее количество добытой руды";
            // 
            // ActPictureBox
            // 
            this.ActPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ActPictureBox.Image")));
            this.ActPictureBox.Location = new System.Drawing.Point(12, 102);
            this.ActPictureBox.Name = "ActPictureBox";
            this.ActPictureBox.Size = new System.Drawing.Size(32, 32);
            this.ActPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ActPictureBox.TabIndex = 4;
            this.ActPictureBox.TabStop = false;
            // 
            // PassPictureBox
            // 
            this.PassPictureBox.Image = global::Развиваемся.Properties.Resources.ПассивныйЗаработок;
            this.PassPictureBox.Location = new System.Drawing.Point(12, 50);
            this.PassPictureBox.Name = "PassPictureBox";
            this.PassPictureBox.Size = new System.Drawing.Size(32, 32);
            this.PassPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PassPictureBox.TabIndex = 2;
            this.PassPictureBox.TabStop = false;
            // 
            // PozitiveLabel
            // 
            this.PozitiveLabel.AutoSize = true;
            this.PozitiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.PozitiveLabel.Location = new System.Drawing.Point(57, 151);
            this.PozitiveLabel.Name = "PozitiveLabel";
            this.PozitiveLabel.Size = new System.Drawing.Size(210, 31);
            this.PozitiveLabel.TabIndex = 6;
            this.PozitiveLabel.Text = "Приятной игры!";
            // 
            // FAQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.PozitiveLabel);
            this.Controls.Add(this.ActFAQLabel);
            this.Controls.Add(this.ActPictureBox);
            this.Controls.Add(this.PassFAQLabel);
            this.Controls.Add(this.PassPictureBox);
            this.Controls.Add(this.FAQLabel);
            this.Controls.Add(this.CloseButt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FAQForm";
            ((System.ComponentModel.ISupportInitialize)(this.ActPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButt;
        private System.Windows.Forms.Label FAQLabel;
        private System.Windows.Forms.PictureBox PassPictureBox;
        private System.Windows.Forms.Label PassFAQLabel;
        private System.Windows.Forms.PictureBox ActPictureBox;
        private System.Windows.Forms.Label ActFAQLabel;
        private System.Windows.Forms.Label PozitiveLabel;
    }
}