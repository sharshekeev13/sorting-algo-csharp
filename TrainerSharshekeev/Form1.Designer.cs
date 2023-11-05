namespace TrainerSharshekeev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GetStartedWelcomeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrainerSharshekeev.Resource1.Welcome;
            this.pictureBox1.Location = new System.Drawing.Point(173, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(182, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Привет!👋";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Добро пожаловать в приложение \"Тренажер по сортировкам массива\"";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 52);
            this.label3.TabIndex = 3;
            this.label3.Text = "Этот тренажер поможет вам освоить важные навыки в программировании, которые приго" +
    "дятся не только в учебе, но и в реальной жизни.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetStartedWelcomeButton
            // 
            this.GetStartedWelcomeButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.GetStartedWelcomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetStartedWelcomeButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetStartedWelcomeButton.ForeColor = System.Drawing.Color.White;
            this.GetStartedWelcomeButton.Location = new System.Drawing.Point(173, 341);
            this.GetStartedWelcomeButton.Name = "GetStartedWelcomeButton";
            this.GetStartedWelcomeButton.Size = new System.Drawing.Size(152, 37);
            this.GetStartedWelcomeButton.TabIndex = 4;
            this.GetStartedWelcomeButton.Text = "Начнём!";
            this.GetStartedWelcomeButton.UseVisualStyleBackColor = false;
            this.GetStartedWelcomeButton.Click += new System.EventHandler(this.GetStartedWelcomeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.GetStartedWelcomeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Привет!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GetStartedWelcomeButton;
    }
}

