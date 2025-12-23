namespace Tyuiu.KosyakovDS.Sprint7.Project.V12
{
    partial class FormStats
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            buttonClose_KDS = new Button();
            groupBoxStats_KDS = new GroupBox();
            textBoxStats_KDS = new TextBox();
            groupBoxStats_KDS.SuspendLayout();
            SuspendLayout();
            // 
            // buttonClose_KDS
            // 
            buttonClose_KDS.Location = new Point(297, 226);
            buttonClose_KDS.Name = "buttonClose_KDS";
            buttonClose_KDS.Size = new Size(75, 23);
            buttonClose_KDS.TabIndex = 0;
            buttonClose_KDS.Text = "OK";
            buttonClose_KDS.UseVisualStyleBackColor = true;
            buttonClose_KDS.Click += buttonClose_KDS_Click;
            // 
            // groupBoxStats_KDS
            // 
            groupBoxStats_KDS.Controls.Add(textBoxStats_KDS);
            groupBoxStats_KDS.Location = new Point(12, 12);
            groupBoxStats_KDS.Name = "groupBoxStats_KDS";
            groupBoxStats_KDS.Size = new Size(360, 208);
            groupBoxStats_KDS.TabIndex = 1;
            groupBoxStats_KDS.TabStop = false;
            groupBoxStats_KDS.Text = "Статистика по данным";
            // 
            // textBoxStats_KDS
            // 
            textBoxStats_KDS.BackColor = SystemColors.ControlLightLight;
            textBoxStats_KDS.BorderStyle = BorderStyle.None;
            textBoxStats_KDS.Dock = DockStyle.Fill;
            textBoxStats_KDS.Location = new Point(3, 19);
            textBoxStats_KDS.Multiline = true;
            textBoxStats_KDS.Name = "textBoxStats_KDS";
            textBoxStats_KDS.ReadOnly = true;
            textBoxStats_KDS.Size = new Size(354, 186);
            textBoxStats_KDS.TabIndex = 0;
            // 
            // FormStats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(groupBoxStats_KDS);
            Controls.Add(buttonClose_KDS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStats";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Статистика";
            groupBoxStats_KDS.ResumeLayout(false);
            groupBoxStats_KDS.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose_KDS;
        private System.Windows.Forms.GroupBox groupBoxStats_KDS;
        private System.Windows.Forms.TextBox textBoxStats_KDS;
    }
}