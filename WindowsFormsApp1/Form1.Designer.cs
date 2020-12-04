namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.redbar = new System.Windows.Forms.TrackBar();
            this.greenbar = new System.Windows.Forms.TrackBar();
            this.bluebar = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьФотоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cropThePictreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cropTheImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(16, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 90);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gray Scale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 90);
            this.button2.TabIndex = 2;
            this.button2.Text = "White Scale";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // redbar
            // 
            this.redbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redbar.Location = new System.Drawing.Point(788, 78);
            this.redbar.Margin = new System.Windows.Forms.Padding(4);
            this.redbar.Maximum = 100;
            this.redbar.Name = "redbar";
            this.redbar.Size = new System.Drawing.Size(289, 56);
            this.redbar.TabIndex = 8;
            this.redbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.redbar.Scroll += new System.EventHandler(this.redbar_Scroll);
            // 
            // greenbar
            // 
            this.greenbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenbar.Location = new System.Drawing.Point(789, 142);
            this.greenbar.Margin = new System.Windows.Forms.Padding(4);
            this.greenbar.Maximum = 100;
            this.greenbar.Name = "greenbar";
            this.greenbar.Size = new System.Drawing.Size(289, 56);
            this.greenbar.TabIndex = 10;
            this.greenbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.greenbar.Scroll += new System.EventHandler(this.greenbar_Scroll);
            // 
            // bluebar
            // 
            this.bluebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bluebar.Location = new System.Drawing.Point(789, 206);
            this.bluebar.Margin = new System.Windows.Forms.Padding(4);
            this.bluebar.Maximum = 100;
            this.bluebar.Name = "bluebar";
            this.bluebar.Size = new System.Drawing.Size(289, 56);
            this.bluebar.TabIndex = 11;
            this.bluebar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.bluebar.Scroll += new System.EventHandler(this.bluebar_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1091, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сделатьФотоToolStripMenuItem,
            this.cropThePictreToolStripMenuItem,
            this.cropTheImageToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.открытьToolStripMenuItem.Text = "Open Image";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.сохранитьToolStripMenuItem.Text = "Save As";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сделатьФотоToolStripMenuItem
            // 
            this.сделатьФотоToolStripMenuItem.Name = "сделатьФотоToolStripMenuItem";
            this.сделатьФотоToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.сделатьФотоToolStripMenuItem.Text = "Take a picture";
            this.сделатьФотоToolStripMenuItem.Click += new System.EventHandler(this.сделатьФотоToolStripMenuItem_Click);
            // 
            // cropThePictreToolStripMenuItem
            // 
            this.cropThePictreToolStripMenuItem.Name = "cropThePictreToolStripMenuItem";
            this.cropThePictreToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.cropThePictreToolStripMenuItem.Text = "Add water mark";
            this.cropThePictreToolStripMenuItem.Click += new System.EventHandler(this.cropThePictreToolStripMenuItem_Click);
            // 
            // cropTheImageToolStripMenuItem
            // 
            this.cropTheImageToolStripMenuItem.Name = "cropTheImageToolStripMenuItem";
            this.cropTheImageToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.cropTheImageToolStripMenuItem.Text = "Crop the image";
            this.cropTheImageToolStripMenuItem.Click += new System.EventHandler(this.cropTheImageToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Location = new System.Drawing.Point(746, 252);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 197);
            this.panel1.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 102);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 82);
            this.button3.TabIndex = 3;
            this.button3.Text = "Red Scale";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(172, 99);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(155, 85);
            this.button10.TabIndex = 18;
            this.button10.Text = "Clean image";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.UseWaitCursor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(747, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Green";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1091, 589);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bluebar);
            this.Controls.Add(this.greenbar);
            this.Controls.Add(this.redbar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Редактор Фото";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar greenbar;
        private System.Windows.Forms.TrackBar bluebar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem сделатьФотоToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TrackBar redbar;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ToolStripMenuItem cropThePictreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cropTheImageToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

