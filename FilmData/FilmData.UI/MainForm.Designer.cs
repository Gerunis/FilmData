namespace FilmData.UI
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ActorAdd = new System.Windows.Forms.Button();
            this.ActorWatch = new System.Windows.Forms.Button();
            this.ActorChange = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ActorDelete = new System.Windows.Forms.Button();
            this.FilmDelete = new System.Windows.Forms.Button();
            this.FilmChange = new System.Windows.Forms.Button();
            this.FilmWatch = new System.Windows.Forms.Button();
            this.FilmAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 399);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ActorDelete);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.ActorChange);
            this.tabPage1.Controls.Add(this.ActorWatch);
            this.tabPage1.Controls.Add(this.ActorAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(585, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Актеры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.FilmDelete);
            this.tabPage2.Controls.Add(this.FilmChange);
            this.tabPage2.Controls.Add(this.FilmWatch);
            this.tabPage2.Controls.Add(this.FilmAdd);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(585, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Фильмы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ActorAdd
            // 
            this.ActorAdd.Location = new System.Drawing.Point(6, 6);
            this.ActorAdd.Name = "ActorAdd";
            this.ActorAdd.Size = new System.Drawing.Size(75, 23);
            this.ActorAdd.TabIndex = 0;
            this.ActorAdd.Text = "Добавить";
            this.ActorAdd.UseVisualStyleBackColor = true;
            // 
            // ActorWatch
            // 
            this.ActorWatch.Location = new System.Drawing.Point(88, 6);
            this.ActorWatch.Name = "ActorWatch";
            this.ActorWatch.Size = new System.Drawing.Size(75, 23);
            this.ActorWatch.TabIndex = 1;
            this.ActorWatch.Text = "Просмотр";
            this.ActorWatch.UseVisualStyleBackColor = true;
            // 
            // ActorChange
            // 
            this.ActorChange.Location = new System.Drawing.Point(170, 6);
            this.ActorChange.Name = "ActorChange";
            this.ActorChange.Size = new System.Drawing.Size(75, 23);
            this.ActorChange.TabIndex = 2;
            this.ActorChange.Text = "Изменить";
            this.ActorChange.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(572, 316);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 35);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(572, 316);
            this.listBox2.TabIndex = 7;
            // 
            // ActorDelete
            // 
            this.ActorDelete.Location = new System.Drawing.Point(251, 6);
            this.ActorDelete.Name = "ActorDelete";
            this.ActorDelete.Size = new System.Drawing.Size(75, 23);
            this.ActorDelete.TabIndex = 4;
            this.ActorDelete.Text = "Удалить";
            this.ActorDelete.UseVisualStyleBackColor = true;
            // 
            // FilmDelete
            // 
            this.FilmDelete.Location = new System.Drawing.Point(251, 6);
            this.FilmDelete.Name = "FilmDelete";
            this.FilmDelete.Size = new System.Drawing.Size(75, 23);
            this.FilmDelete.TabIndex = 11;
            this.FilmDelete.Text = "Удалить";
            this.FilmDelete.UseVisualStyleBackColor = true;
            // 
            // FilmChange
            // 
            this.FilmChange.Location = new System.Drawing.Point(170, 6);
            this.FilmChange.Name = "FilmChange";
            this.FilmChange.Size = new System.Drawing.Size(75, 23);
            this.FilmChange.TabIndex = 10;
            this.FilmChange.Text = "Изменить";
            this.FilmChange.UseVisualStyleBackColor = true;
            // 
            // FilmWatch
            // 
            this.FilmWatch.Location = new System.Drawing.Point(88, 6);
            this.FilmWatch.Name = "FilmWatch";
            this.FilmWatch.Size = new System.Drawing.Size(75, 23);
            this.FilmWatch.TabIndex = 9;
            this.FilmWatch.Text = "Просмотр";
            this.FilmWatch.UseVisualStyleBackColor = true;
            // 
            // FilmAdd
            // 
            this.FilmAdd.Location = new System.Drawing.Point(6, 6);
            this.FilmAdd.Name = "FilmAdd";
            this.FilmAdd.Size = new System.Drawing.Size(75, 23);
            this.FilmAdd.TabIndex = 8;
            this.FilmAdd.Text = "Добавить";
            this.FilmAdd.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 438);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(320, 180);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ActorChange;
        private System.Windows.Forms.Button ActorWatch;
        private System.Windows.Forms.Button ActorAdd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button ActorDelete;
        private System.Windows.Forms.Button FilmDelete;
        private System.Windows.Forms.Button FilmChange;
        private System.Windows.Forms.Button FilmWatch;
        private System.Windows.Forms.Button FilmAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
    }
}