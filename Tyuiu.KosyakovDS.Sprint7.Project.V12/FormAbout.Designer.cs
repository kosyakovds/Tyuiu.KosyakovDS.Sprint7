namespace Tyuiu.KosyakovDS.Sprint6.Task7.V20
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_KDS = new PictureBox();
            textBox1 = new TextBox();
            buttonOk_KDS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KDS).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_KDS
            // 
            pictureBoxAvatar_KDS.Image = (Image)resources.GetObject("pictureBoxAvatar_KDS.Image");
            pictureBoxAvatar_KDS.Location = new Point(8, 14);
            pictureBoxAvatar_KDS.Margin = new Padding(2);
            pictureBoxAvatar_KDS.Name = "pictureBoxAvatar_KDS";
            pictureBoxAvatar_KDS.Size = new Size(188, 184);
            pictureBoxAvatar_KDS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar_KDS.TabIndex = 0;
            pictureBoxAvatar_KDS.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(208, 14);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(346, 152);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonOk_KDS
            // 
            buttonOk_KDS.BackColor = SystemColors.ButtonHighlight;
            buttonOk_KDS.Location = new Point(476, 178);
            buttonOk_KDS.Margin = new Padding(2);
            buttonOk_KDS.Name = "buttonOk_KDS";
            buttonOk_KDS.Size = new Size(78, 20);
            buttonOk_KDS.TabIndex = 2;
            buttonOk_KDS.Text = "Ok";
            buttonOk_KDS.UseVisualStyleBackColor = false;
            buttonOk_KDS.Click += buttonOk_KDS_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 213);
            Controls.Add(buttonOk_KDS);
            Controls.Add(textBox1);
            Controls.Add(pictureBoxAvatar_KDS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KDS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_KDS;
        private TextBox textBox1;
        private Button buttonOk_KDS;
    }
}