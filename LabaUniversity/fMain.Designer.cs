namespace LabaUniversity
{
    partial class fMain
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
            this.butAccrueScholarship = new System.Windows.Forms.Button();
            this.butAccrueSalary = new System.Windows.Forms.Button();
            this.butViewLists = new System.Windows.Forms.Button();
            this.butGetRepot = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butAccrueScholarship
            // 
            this.butAccrueScholarship.AutoEllipsis = true;
            this.butAccrueScholarship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butAccrueScholarship.Location = new System.Drawing.Point(48, 87);
            this.butAccrueScholarship.Name = "butAccrueScholarship";
            this.butAccrueScholarship.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butAccrueScholarship.Size = new System.Drawing.Size(173, 40);
            this.butAccrueScholarship.TabIndex = 0;
            this.butAccrueScholarship.Text = "Начислить стипендию";
            this.butAccrueScholarship.UseVisualStyleBackColor = true;
            this.butAccrueScholarship.Click += new System.EventHandler(this.butAccrueScholarship_Click);
            // 
            // butAccrueSalary
            // 
            this.butAccrueSalary.AutoEllipsis = true;
            this.butAccrueSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butAccrueSalary.Location = new System.Drawing.Point(48, 244);
            this.butAccrueSalary.Name = "butAccrueSalary";
            this.butAccrueSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butAccrueSalary.Size = new System.Drawing.Size(173, 40);
            this.butAccrueSalary.TabIndex = 1;
            this.butAccrueSalary.Text = "Начислить зарплату";
            this.butAccrueSalary.UseVisualStyleBackColor = true;
            this.butAccrueSalary.Click += new System.EventHandler(this.butAccrueSalary_Click);
            // 
            // butViewLists
            // 
            this.butViewLists.AutoEllipsis = true;
            this.butViewLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butViewLists.Location = new System.Drawing.Point(292, 86);
            this.butViewLists.Name = "butViewLists";
            this.butViewLists.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butViewLists.Size = new System.Drawing.Size(173, 40);
            this.butViewLists.TabIndex = 2;
            this.butViewLists.Text = "Просмотр списков";
            this.butViewLists.UseVisualStyleBackColor = true;
            this.butViewLists.Click += new System.EventHandler(this.butViewLists_Click);
            // 
            // butGetRepot
            // 
            this.butGetRepot.AutoEllipsis = true;
            this.butGetRepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butGetRepot.Location = new System.Drawing.Point(292, 244);
            this.butGetRepot.Name = "butGetRepot";
            this.butGetRepot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butGetRepot.Size = new System.Drawing.Size(173, 40);
            this.butGetRepot.TabIndex = 3;
            this.butGetRepot.Text = "Получить отчет";
            this.butGetRepot.UseVisualStyleBackColor = true;
            this.butGetRepot.Click += new System.EventHandler(this.butGetRepot_Click);
            // 
            // butExit
            // 
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExit.Location = new System.Drawing.Point(431, 330);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 31);
            this.butExit.TabIndex = 4;
            this.butExit.Text = "Выход";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 373);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butGetRepot);
            this.Controls.Add(this.butViewLists);
            this.Controls.Add(this.butAccrueSalary);
            this.Controls.Add(this.butAccrueScholarship);
            this.Name = "fMain";
            this.Text = "Бухгалтерия ЧелГУ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butAccrueScholarship;
        private System.Windows.Forms.Button butAccrueSalary;
        private System.Windows.Forms.Button butViewLists;
        private System.Windows.Forms.Button butGetRepot;
        private System.Windows.Forms.Button butExit;
    }
}

