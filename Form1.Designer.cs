namespace demo_proj
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
            this.reg_but = new System.Windows.Forms.Button();
            this.log_but = new System.Windows.Forms.Button();
            this.logtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passtb = new System.Windows.Forms.TextBox();
            this.cls_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reg_but
            // 
            this.reg_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reg_but.Location = new System.Drawing.Point(12, 203);
            this.reg_but.Name = "reg_but";
            this.reg_but.Size = new System.Drawing.Size(117, 34);
            this.reg_but.TabIndex = 0;
            this.reg_but.Text = "регистрация";
            this.reg_but.UseVisualStyleBackColor = true;
            this.reg_but.Click += new System.EventHandler(this.reg_but_Click);
            // 
            // log_but
            // 
            this.log_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.log_but.Location = new System.Drawing.Point(135, 203);
            this.log_but.Name = "log_but";
            this.log_but.Size = new System.Drawing.Size(117, 34);
            this.log_but.TabIndex = 1;
            this.log_but.Text = "вход";
            this.log_but.UseVisualStyleBackColor = true;
            this.log_but.Click += new System.EventHandler(this.log_but_Click);
            // 
            // logtb
            // 
            this.logtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.logtb.Location = new System.Drawing.Point(12, 32);
            this.logtb.Name = "logtb";
            this.logtb.Size = new System.Drawing.Size(240, 29);
            this.logtb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "пароль";
            // 
            // passtb
            // 
            this.passtb.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passtb.Location = new System.Drawing.Point(12, 115);
            this.passtb.Name = "passtb";
            this.passtb.PasswordChar = 'o';
            this.passtb.Size = new System.Drawing.Size(240, 31);
            this.passtb.TabIndex = 4;
            // 
            // cls_but
            // 
            this.cls_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cls_but.Location = new System.Drawing.Point(69, 152);
            this.cls_but.Name = "cls_but";
            this.cls_but.Size = new System.Drawing.Size(117, 34);
            this.cls_but.TabIndex = 6;
            this.cls_but.Text = "выйти";
            this.cls_but.UseVisualStyleBackColor = true;
            this.cls_but.Click += new System.EventHandler(this.cls_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 246);
            this.Controls.Add(this.cls_but);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logtb);
            this.Controls.Add(this.log_but);
            this.Controls.Add(this.reg_but);
            this.Name = "Form1";
            this.Text = "Окно авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reg_but;
        private System.Windows.Forms.Button log_but;
        private System.Windows.Forms.TextBox logtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passtb;
        private System.Windows.Forms.Button cls_but;
    }
}

