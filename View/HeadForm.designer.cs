namespace View
{
    partial class HeadForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPiram = new System.Windows.Forms.Button();
            this.buttonParall = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSphere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Лабораторная работа №2\r\nВыполнил:\r\nстудент гр.582-2\r\nСтепанов П.Ю.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(260, 363);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "здесь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Исходный код можно просмотреть";
            // 
            // buttonPiram
            // 
            this.buttonPiram.Location = new System.Drawing.Point(21, 221);
            this.buttonPiram.Name = "buttonPiram";
            this.buttonPiram.Size = new System.Drawing.Size(124, 28);
            this.buttonPiram.TabIndex = 4;
            this.buttonPiram.Text = "Пирамида";
            this.buttonPiram.UseVisualStyleBackColor = true;
            this.buttonPiram.Click += new System.EventHandler(this.buttonPiram_Click);
            // 
            // buttonParall
            // 
            this.buttonParall.Location = new System.Drawing.Point(21, 261);
            this.buttonParall.Name = "buttonParall";
            this.buttonParall.Size = new System.Drawing.Size(124, 28);
            this.buttonParall.TabIndex = 5;
            this.buttonParall.Text = "Параллелепипед";
            this.buttonParall.UseVisualStyleBackColor = true;
            this.buttonParall.Click += new System.EventHandler(this.buttonParall_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выберите фигуру, для которой";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "необходимо вычислить объем";
            // 
            // buttonSphere
            // 
            this.buttonSphere.Location = new System.Drawing.Point(21, 181);
            this.buttonSphere.Name = "buttonSphere";
            this.buttonSphere.Size = new System.Drawing.Size(124, 28);
            this.buttonSphere.TabIndex = 8;
            this.buttonSphere.Text = "Шар";
            this.buttonSphere.UseVisualStyleBackColor = true;
            this.buttonSphere.Click += new System.EventHandler(this.buttonSphere_Click);
            // 
            // HeadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 387);
            this.Controls.Add(this.buttonSphere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonParall);
            this.Controls.Add(this.buttonPiram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Name = "HeadForm";
            this.Text = "Расчет объёма фигур";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPiram;
        private System.Windows.Forms.Button buttonParall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSphere;
    }
}

