using System.Drawing;

namespace TrainerSharshekeev
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.arrElementNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.arrPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.информияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.циклическаяСортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitonicSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.быстраяСортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравнительныйАнализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.IterationLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.arrPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(21, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(192, 38);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Циклическая сортировка\r\n( Сортировка выбором )";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(21, 148);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(155, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Гномья сортировка";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(21, 179);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(185, 41);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Быстрая сортировка (Quick Sort)";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Напишите количество\r\nэлементов массива";
            // 
            // arrElementNumber
            // 
            this.arrElementNumber.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrElementNumber.Location = new System.Drawing.Point(21, 278);
            this.arrElementNumber.MaxLength = 2;
            this.arrElementNumber.Name = "arrElementNumber";
            this.arrElementNumber.Size = new System.Drawing.Size(185, 24);
            this.arrElementNumber.TabIndex = 5;
            this.arrElementNumber.Text = "25";
            this.arrElementNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arrElementNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arrElementNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите тип \r\nсортировки";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.HotTrack;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(21, 328);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(185, 42);
            this.start.TabIndex = 7;
            this.start.Text = "Начать";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.OrangeRed;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(21, 376);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(185, 42);
            this.reset.TabIndex = 8;
            this.reset.Text = "Сброс";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // arrPanel
            // 
            this.arrPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.arrPanel.Controls.Add(this.pictureBox1);
            this.arrPanel.Location = new System.Drawing.Point(291, 82);
            this.arrPanel.Name = "arrPanel";
            this.arrPanel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.arrPanel.Size = new System.Drawing.Size(642, 379);
            this.arrPanel.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.pictureBox1.Size = new System.Drawing.Size(605, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информияToolStripMenuItem,
            this.сравнительныйАнализToolStripMenuItem,
            this.инфоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 25);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // информияToolStripMenuItem
            // 
            this.информияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.циклическаяСортировкаToolStripMenuItem,
            this.bitonicSortToolStripMenuItem,
            this.быстраяСортировкаToolStripMenuItem});
            this.информияToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.информияToolStripMenuItem.Name = "информияToolStripMenuItem";
            this.информияToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.информияToolStripMenuItem.Text = "Алгоритмы";
            // 
            // циклическаяСортировкаToolStripMenuItem
            // 
            this.циклическаяСортировкаToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.циклическаяСортировкаToolStripMenuItem.Name = "циклическаяСортировкаToolStripMenuItem";
            this.циклическаяСортировкаToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.циклическаяСортировкаToolStripMenuItem.Text = "Циклическая сортировка";
            this.циклическаяСортировкаToolStripMenuItem.Click += new System.EventHandler(this.CycleSortToolStripMenuItem_Click);
            // 
            // bitonicSortToolStripMenuItem
            // 
            this.bitonicSortToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitonicSortToolStripMenuItem.Name = "bitonicSortToolStripMenuItem";
            this.bitonicSortToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.bitonicSortToolStripMenuItem.Text = "Гномья сортировка";
            this.bitonicSortToolStripMenuItem.Click += new System.EventHandler(this.GnomeSortToolStripMenuItem_Click);
            // 
            // быстраяСортировкаToolStripMenuItem
            // 
            this.быстраяСортировкаToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.быстраяСортировкаToolStripMenuItem.Name = "быстраяСортировкаToolStripMenuItem";
            this.быстраяСортировкаToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.быстраяСортировкаToolStripMenuItem.Text = "Быстрая сортировка";
            this.быстраяСортировкаToolStripMenuItem.Click += new System.EventHandler(this.QucikSortToolStripMenuItem_Click);
            // 
            // сравнительныйАнализToolStripMenuItem
            // 
            this.сравнительныйАнализToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.сравнительныйАнализToolStripMenuItem.Name = "сравнительныйАнализToolStripMenuItem";
            this.сравнительныйАнализToolStripMenuItem.Size = new System.Drawing.Size(156, 21);
            this.сравнительныйАнализToolStripMenuItem.Text = "Сравнительный анализ";
            this.сравнительныйАнализToolStripMenuItem.Click += new System.EventHandler(this.ComparativeAnalysisToolStripMenuItem_Click);
            // 
            // инфоToolStripMenuItem
            // 
            this.инфоToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.инфоToolStripMenuItem.Name = "инфоToolStripMenuItem";
            this.инфоToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.инфоToolStripMenuItem.Text = "Инфо";
            this.инфоToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Время:";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(351, 52);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(39, 16);
            this.TimerLabel.TabIndex = 16;
            this.TimerLabel.Text = "0 сек.";
            // 
            // IterationLabel
            // 
            this.IterationLabel.AutoSize = true;
            this.IterationLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IterationLabel.Location = new System.Drawing.Point(550, 52);
            this.IterationLabel.Name = "IterationLabel";
            this.IterationLabel.Size = new System.Drawing.Size(13, 16);
            this.IterationLabel.TabIndex = 18;
            this.IterationLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Итераций:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 461);
            this.Controls.Add(this.IterationLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrPanel);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrElementNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тренажер по сортировкам массива";
            this.arrPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arrElementNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Panel arrPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem информияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem циклическаяСортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitonicSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem быстраяСортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сравнительныйАнализToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инфоToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label IterationLabel;
        private System.Windows.Forms.Label label5;
    }
}