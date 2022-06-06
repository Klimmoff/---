
namespace Примитивный_Кликер
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.ValueUpgrade = new System.Windows.Forms.Label();
            this.CostUpgrade = new System.Windows.Forms.Label();
            this.CountUpgrade = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 140);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(276, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 140);
            this.button2.TabIndex = 2;
            this.button2.Text = "Upgrade";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.BackColor = System.Drawing.Color.White;
            this.MoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.MoneyLabel.ForeColor = System.Drawing.Color.Black;
            this.MoneyLabel.Location = new System.Drawing.Point(28, 43);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(121, 26);
            this.MoneyLabel.TabIndex = 3;
            this.MoneyLabel.Text = "Деньги: 0$";
            // 
            // ValueUpgrade
            // 
            this.ValueUpgrade.AutoSize = true;
            this.ValueUpgrade.BackColor = System.Drawing.Color.Transparent;
            this.ValueUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.ValueUpgrade.ForeColor = System.Drawing.Color.Black;
            this.ValueUpgrade.Location = new System.Drawing.Point(28, 90);
            this.ValueUpgrade.Name = "ValueUpgrade";
            this.ValueUpgrade.Size = new System.Drawing.Size(271, 26);
            this.ValueUpgrade.TabIndex = 4;
            this.ValueUpgrade.Text = "Количество Апгрейдов: 0";
            // 
            // CostUpgrade
            // 
            this.CostUpgrade.AutoSize = true;
            this.CostUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.CostUpgrade.Location = new System.Drawing.Point(28, 131);
            this.CostUpgrade.Name = "CostUpgrade";
            this.CostUpgrade.Size = new System.Drawing.Size(214, 26);
            this.CostUpgrade.TabIndex = 5;
            this.CostUpgrade.Text = "Цена Апгрейда: 25$";
            // 
            // CountUpgrade
            // 
            this.CountUpgrade.AutoSize = true;
            this.CountUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.CountUpgrade.Location = new System.Drawing.Point(28, 176);
            this.CountUpgrade.Name = "CountUpgrade";
            this.CountUpgrade.Size = new System.Drawing.Size(191, 26);
            this.CountUpgrade.TabIndex = 6;
            this.CountUpgrade.Text = "За Один Клик: 1$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Примитивный_Кликер.Properties.Resources.o3h;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 461);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.CountUpgrade);
            this.Controls.Add(this.CostUpgrade);
            this.Controls.Add(this.ValueUpgrade);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label ValueUpgrade;
        private System.Windows.Forms.Label CostUpgrade;
        private System.Windows.Forms.Label CountUpgrade;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

