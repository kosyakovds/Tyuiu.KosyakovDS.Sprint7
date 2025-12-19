namespace Tyuiu.KosyakovDS.Sprint7.Project.V12
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            FileToolStripMenuItem_KDS = new ToolStripMenuItem();
            FormAboutToolStripMenuItem_KDS = new ToolStripMenuItem();
            нагаToolStripMenuItem = new ToolStripMenuItem();
            FileCreateToolStripMenuItem_KDS = new ToolStripMenuItem();
            FileOpenToolStripMenuItem_KDS = new ToolStripMenuItem();
            FileSaveToolStripMenuItem_KDS = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem_KDS, FormAboutToolStripMenuItem_KDS, нагаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem_KDS
            // 
            FileToolStripMenuItem_KDS.DropDownItems.AddRange(new ToolStripItem[] { FileCreateToolStripMenuItem_KDS, FileOpenToolStripMenuItem_KDS, FileSaveToolStripMenuItem_KDS });
            FileToolStripMenuItem_KDS.Name = "FileToolStripMenuItem_KDS";
            FileToolStripMenuItem_KDS.Size = new Size(48, 20);
            FileToolStripMenuItem_KDS.Text = "Файл";
            // 
            // FormAboutToolStripMenuItem_KDS
            // 
            FormAboutToolStripMenuItem_KDS.Name = "FormAboutToolStripMenuItem_KDS";
            FormAboutToolStripMenuItem_KDS.Size = new Size(65, 20);
            FormAboutToolStripMenuItem_KDS.Text = "Справка";
            FormAboutToolStripMenuItem_KDS.Click += FormAboutToolStripMenuItem_Click;
            // 
            // нагаToolStripMenuItem
            // 
            нагаToolStripMenuItem.Name = "нагаToolStripMenuItem";
            нагаToolStripMenuItem.Size = new Size(43, 20);
            нагаToolStripMenuItem.Text = "нага";
            // 
            // FileCreateToolStripMenuItem_KDS
            // 
            FileCreateToolStripMenuItem_KDS.Name = "FileCreateToolStripMenuItem_KDS";
            FileCreateToolStripMenuItem_KDS.Size = new Size(180, 22);
            FileCreateToolStripMenuItem_KDS.Text = "Создать";
            // 
            // FileOpenToolStripMenuItem_KDS
            // 
            FileOpenToolStripMenuItem_KDS.Name = "FileOpenToolStripMenuItem_KDS";
            FileOpenToolStripMenuItem_KDS.Size = new Size(180, 22);
            FileOpenToolStripMenuItem_KDS.Text = "Открыть";
            // 
            // FileSaveToolStripMenuItem_KDS
            // 
            FileSaveToolStripMenuItem_KDS.Name = "FileSaveToolStripMenuItem_KDS";
            FileSaveToolStripMenuItem_KDS.Size = new Size(180, 22);
            FileSaveToolStripMenuItem_KDS.Text = "Сохранить";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileToolStripMenuItem_KDS;
        private ToolStripMenuItem FormAboutToolStripMenuItem_KDS;
        private ToolStripMenuItem нагаToolStripMenuItem;
        private ToolStripMenuItem FileCreateToolStripMenuItem_KDS;
        private ToolStripMenuItem FileOpenToolStripMenuItem_KDS;
        private ToolStripMenuItem FileSaveToolStripMenuItem_KDS;
    }
}
