using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Tyuiu.KosyakovDS.Sprint7.Project.V12
{
    partial class FormMain
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
            menuStripMain_KDS = new MenuStrip();
            toolStripMenuItemFile_KDS = new ToolStripMenuItem();
            toolStripMenuItemOpen_KDS = new ToolStripMenuItem();
            toolStripMenuItemSave_KDS = new ToolStripMenuItem();
            toolStripMenuItemSaveAs_KDS = new ToolStripMenuItem();
            toolStripSeparatorFileMenu_KDS = new ToolStripSeparator();
            toolStripMenuItemEdit_KDS = new ToolStripMenuItem();
            toolStripMenuItemAddPC_KDS = new ToolStripMenuItem();
            toolStripMenuItemDeletePC_KDS = new ToolStripMenuItem();
            toolStripMenuItemHelp_KDS = new ToolStripMenuItem();
            toolStripMenuItemManual_KDS = new ToolStripMenuItem();
            toolStripMenuItemAbout_KDS = new ToolStripMenuItem();
            panelTop_KDS = new Panel();
            buttonChart_KDS = new Button();
            groupBoxStats_KDS = new GroupBox();
            buttonStatsSum = new Button();
            buttonStatsCount = new Button();
            buttonStatsAvg_KDS = new Button();
            buttonStatsMin_KDS = new Button();
            buttonStatsMax_KDS = new Button();
            groupBoxSearchFilter_KDS = new GroupBox();
            buttonClearFilter_KDS = new Button();
            buttonApplyFilter_KDS = new Button();
            textBoxSearchValue_KDS = new TextBox();
            labelSearchValue_KDS = new Label();
            comboBoxFilterField_KDS = new ComboBox();
            labelFilterField_KDS = new Label();
            panelFill_KDS = new Panel();
            tabControlMain_KDS = new TabControl();
            tabPagePCs_KDS = new TabPage();
            dataGridViewPCs_KDS = new DataGridView();
            tabPageSuppliers_KDS = new TabPage();
            dataGridViewSuppliers_KDS = new DataGridView();
            labelStatsResult_KDS = new Label();
            menuStripMain_KDS.SuspendLayout();
            panelTop_KDS.SuspendLayout();
            groupBoxStats_KDS.SuspendLayout();
            groupBoxSearchFilter_KDS.SuspendLayout();
            panelFill_KDS.SuspendLayout();
            tabControlMain_KDS.SuspendLayout();
            tabPagePCs_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPCs_KDS).BeginInit();
            tabPageSuppliers_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers_KDS).BeginInit();
            SuspendLayout();
            // 
            // menuStripMain_KDS
            // 
            menuStripMain_KDS.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile_KDS, toolStripMenuItemEdit_KDS, toolStripMenuItemHelp_KDS });
            menuStripMain_KDS.Location = new Point(0, 0);
            menuStripMain_KDS.Name = "menuStripMain_KDS";
            menuStripMain_KDS.Size = new Size(984, 24);
            menuStripMain_KDS.TabIndex = 0;
            menuStripMain_KDS.Text = "Главное меню";
            // 
            // toolStripMenuItemFile_KDS
            // 
            toolStripMenuItemFile_KDS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemOpen_KDS, toolStripMenuItemSave_KDS, toolStripMenuItemSaveAs_KDS, toolStripSeparatorFileMenu_KDS });
            toolStripMenuItemFile_KDS.Name = "toolStripMenuItemFile_KDS";
            toolStripMenuItemFile_KDS.Size = new Size(48, 20);
            toolStripMenuItemFile_KDS.Text = "Файл";
            // 
            // toolStripMenuItemOpen_KDS
            // 
            toolStripMenuItemOpen_KDS.Name = "toolStripMenuItemOpen_KDS";
            toolStripMenuItemOpen_KDS.Size = new Size(163, 22);
            toolStripMenuItemOpen_KDS.Text = "Открыть";
            toolStripMenuItemOpen_KDS.Click += ToolStripMenuItemOpen_KDS_Click;
            // 
            // toolStripMenuItemSave_KDS
            // 
            toolStripMenuItemSave_KDS.Name = "toolStripMenuItemSave_KDS";
            toolStripMenuItemSave_KDS.Size = new Size(163, 22);
            toolStripMenuItemSave_KDS.Text = "Сохранить";
            toolStripMenuItemSave_KDS.Click += ToolStripMenuItemSave_KDS_Click;
            // 
            // toolStripMenuItemSaveAs_KDS
            // 
            toolStripMenuItemSaveAs_KDS.Name = "toolStripMenuItemSaveAs_KDS";
            toolStripMenuItemSaveAs_KDS.Size = new Size(163, 22);
            toolStripMenuItemSaveAs_KDS.Text = "Сохранить как...";
            toolStripMenuItemSaveAs_KDS.Click += ToolStripMenuItemSaveAs_KDS_Click;
            // 
            // toolStripSeparatorFileMenu_KDS
            // 
            toolStripSeparatorFileMenu_KDS.Name = "toolStripSeparatorFileMenu_KDS";
            toolStripSeparatorFileMenu_KDS.Size = new Size(160, 6);
            // 
            // toolStripMenuItemEdit_KDS
            // 
            toolStripMenuItemEdit_KDS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAddPC_KDS, toolStripMenuItemDeletePC_KDS });
            toolStripMenuItemEdit_KDS.Name = "toolStripMenuItemEdit_KDS";
            toolStripMenuItemEdit_KDS.Size = new Size(99, 20);
            toolStripMenuItemEdit_KDS.Text = "Редактировать";
            // 
            // toolStripMenuItemAddPC_KDS
            // 
            toolStripMenuItemAddPC_KDS.Name = "toolStripMenuItemAddPC_KDS";
            toolStripMenuItemAddPC_KDS.Size = new Size(145, 22);
            toolStripMenuItemAddPC_KDS.Text = "Добавить ПК";
            // 
            // toolStripMenuItemDeletePC_KDS
            // 
            toolStripMenuItemDeletePC_KDS.Name = "toolStripMenuItemDeletePC_KDS";
            toolStripMenuItemDeletePC_KDS.Size = new Size(145, 22);
            toolStripMenuItemDeletePC_KDS.Text = "Удалить ПК";
            // 
            // toolStripMenuItemHelp_KDS
            // 
            toolStripMenuItemHelp_KDS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemManual_KDS, toolStripMenuItemAbout_KDS });
            toolStripMenuItemHelp_KDS.Name = "toolStripMenuItemHelp_KDS";
            toolStripMenuItemHelp_KDS.Size = new Size(65, 20);
            toolStripMenuItemHelp_KDS.Text = "Справка";
            // 
            // toolStripMenuItemManual_KDS
            // 
            toolStripMenuItemManual_KDS.Name = "toolStripMenuItemManual_KDS";
            toolStripMenuItemManual_KDS.Size = new Size(149, 22);
            toolStripMenuItemManual_KDS.Text = "Руководство";
            // 
            // toolStripMenuItemAbout_KDS
            // 
            toolStripMenuItemAbout_KDS.Name = "toolStripMenuItemAbout_KDS";
            toolStripMenuItemAbout_KDS.Size = new Size(149, 22);
            toolStripMenuItemAbout_KDS.Text = "О программе";
            toolStripMenuItemAbout_KDS.Click += toolStripMenuItemAbout_KDS_Click;
            // 
            // panelTop_KDS
            // 
            panelTop_KDS.Controls.Add(labelStatsResult_KDS);
            panelTop_KDS.Controls.Add(buttonChart_KDS);
            panelTop_KDS.Controls.Add(groupBoxStats_KDS);
            panelTop_KDS.Controls.Add(groupBoxSearchFilter_KDS);
            panelTop_KDS.Dock = DockStyle.Top;
            panelTop_KDS.Location = new Point(0, 24);
            panelTop_KDS.Name = "panelTop_KDS";
            panelTop_KDS.Size = new Size(984, 130);
            panelTop_KDS.TabIndex = 1;
            // 
            // buttonChart_KDS
            // 
            buttonChart_KDS.Location = new Point(872, 15);
            buttonChart_KDS.Name = "buttonChart_KDS";
            buttonChart_KDS.Size = new Size(100, 35);
            buttonChart_KDS.TabIndex = 1;
            buttonChart_KDS.Text = "График";
            buttonChart_KDS.UseVisualStyleBackColor = true;
            // 
            // groupBoxStats_KDS
            // 
            groupBoxStats_KDS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxStats_KDS.Controls.Add(buttonStatsSum);
            groupBoxStats_KDS.Controls.Add(buttonStatsCount);
            groupBoxStats_KDS.Controls.Add(buttonStatsAvg_KDS);
            groupBoxStats_KDS.Controls.Add(buttonStatsMin_KDS);
            groupBoxStats_KDS.Controls.Add(buttonStatsMax_KDS);
            groupBoxStats_KDS.Location = new Point(518, 10);
            groupBoxStats_KDS.Name = "groupBoxStats_KDS";
            groupBoxStats_KDS.Size = new Size(250, 90);
            groupBoxStats_KDS.TabIndex = 1;
            groupBoxStats_KDS.TabStop = false;
            groupBoxStats_KDS.Text = "Статистика";
            // 
            // buttonStatsSum
            // 
            buttonStatsSum.Location = new Point(168, 22);
            buttonStatsSum.Name = "buttonStatsSum";
            buttonStatsSum.Size = new Size(75, 23);
            buttonStatsSum.TabIndex = 0;
            buttonStatsSum.Text = "Сумма";
            buttonStatsSum.UseVisualStyleBackColor = true;
            buttonStatsSum.Click += buttonStatsSum_Click;
            // 
            // buttonStatsCount
            // 
            buttonStatsCount.Location = new Point(129, 51);
            buttonStatsCount.Name = "buttonStatsCount";
            buttonStatsCount.Size = new Size(83, 23);
            buttonStatsCount.TabIndex = 0;
            buttonStatsCount.Text = "Количество";
            buttonStatsCount.UseVisualStyleBackColor = true;
            // 
            // buttonStatsAvg_KDS
            // 
            buttonStatsAvg_KDS.Location = new Point(87, 22);
            buttonStatsAvg_KDS.Name = "buttonStatsAvg_KDS";
            buttonStatsAvg_KDS.Size = new Size(75, 23);
            buttonStatsAvg_KDS.TabIndex = 0;
            buttonStatsAvg_KDS.Text = "Среднее";
            buttonStatsAvg_KDS.UseVisualStyleBackColor = true;
            // 
            // buttonStatsMin_KDS
            // 
            buttonStatsMin_KDS.Location = new Point(6, 50);
            buttonStatsMin_KDS.Name = "buttonStatsMin_KDS";
            buttonStatsMin_KDS.Size = new Size(75, 23);
            buttonStatsMin_KDS.TabIndex = 0;
            buttonStatsMin_KDS.Text = "Мин";
            buttonStatsMin_KDS.UseVisualStyleBackColor = true;
            // 
            // buttonStatsMax_KDS
            // 
            buttonStatsMax_KDS.Location = new Point(6, 21);
            buttonStatsMax_KDS.Name = "buttonStatsMax_KDS";
            buttonStatsMax_KDS.Size = new Size(75, 23);
            buttonStatsMax_KDS.TabIndex = 0;
            buttonStatsMax_KDS.Text = "Макс";
            buttonStatsMax_KDS.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchFilter_KDS
            // 
            groupBoxSearchFilter_KDS.Controls.Add(buttonClearFilter_KDS);
            groupBoxSearchFilter_KDS.Controls.Add(buttonApplyFilter_KDS);
            groupBoxSearchFilter_KDS.Controls.Add(textBoxSearchValue_KDS);
            groupBoxSearchFilter_KDS.Controls.Add(labelSearchValue_KDS);
            groupBoxSearchFilter_KDS.Controls.Add(comboBoxFilterField_KDS);
            groupBoxSearchFilter_KDS.Controls.Add(labelFilterField_KDS);
            groupBoxSearchFilter_KDS.Location = new Point(12, 10);
            groupBoxSearchFilter_KDS.Name = "groupBoxSearchFilter_KDS";
            groupBoxSearchFilter_KDS.Size = new Size(500, 90);
            groupBoxSearchFilter_KDS.TabIndex = 0;
            groupBoxSearchFilter_KDS.TabStop = false;
            groupBoxSearchFilter_KDS.Text = "Поиск и фильтрация";
            // 
            // buttonClearFilter_KDS
            // 
            buttonClearFilter_KDS.Location = new Point(400, 41);
            buttonClearFilter_KDS.Name = "buttonClearFilter_KDS";
            buttonClearFilter_KDS.Size = new Size(90, 27);
            buttonClearFilter_KDS.TabIndex = 5;
            buttonClearFilter_KDS.Text = "Очистить";
            buttonClearFilter_KDS.UseVisualStyleBackColor = true;
            // 
            // buttonApplyFilter_KDS
            // 
            buttonApplyFilter_KDS.Location = new Point(300, 41);
            buttonApplyFilter_KDS.Name = "buttonApplyFilter_KDS";
            buttonApplyFilter_KDS.Size = new Size(90, 27);
            buttonApplyFilter_KDS.TabIndex = 4;
            buttonApplyFilter_KDS.Text = "Применить";
            buttonApplyFilter_KDS.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchValue_KDS
            // 
            textBoxSearchValue_KDS.Location = new Point(170, 43);
            textBoxSearchValue_KDS.Name = "textBoxSearchValue_KDS";
            textBoxSearchValue_KDS.Size = new Size(120, 23);
            textBoxSearchValue_KDS.TabIndex = 3;
            // 
            // labelSearchValue_KDS
            // 
            labelSearchValue_KDS.AutoSize = true;
            labelSearchValue_KDS.Location = new Point(170, 25);
            labelSearchValue_KDS.Name = "labelSearchValue_KDS";
            labelSearchValue_KDS.Size = new Size(63, 15);
            labelSearchValue_KDS.TabIndex = 2;
            labelSearchValue_KDS.Text = "Значение:";
            // 
            // comboBoxFilterField_KDS
            // 
            comboBoxFilterField_KDS.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterField_KDS.FormattingEnabled = true;
            comboBoxFilterField_KDS.Items.AddRange(new object[] { "Производитель", "Процессор", "Видекарта", "ОЗУ", "Жёсткий диск", "Дата выпуска" });
            comboBoxFilterField_KDS.Location = new Point(10, 43);
            comboBoxFilterField_KDS.Name = "comboBoxFilterField_KDS";
            comboBoxFilterField_KDS.Size = new Size(150, 23);
            comboBoxFilterField_KDS.TabIndex = 1;
            // 
            // labelFilterField_KDS
            // 
            labelFilterField_KDS.AutoSize = true;
            labelFilterField_KDS.Location = new Point(10, 25);
            labelFilterField_KDS.Name = "labelFilterField_KDS";
            labelFilterField_KDS.Size = new Size(89, 15);
            labelFilterField_KDS.TabIndex = 0;
            labelFilterField_KDS.Text = "Поле фильтра:";
            // 
            // panelFill_KDS
            // 
            panelFill_KDS.Controls.Add(tabControlMain_KDS);
            panelFill_KDS.Dock = DockStyle.Fill;
            panelFill_KDS.Location = new Point(0, 154);
            panelFill_KDS.Name = "panelFill_KDS";
            panelFill_KDS.Size = new Size(984, 507);
            panelFill_KDS.TabIndex = 2;
            // 
            // tabControlMain_KDS
            // 
            tabControlMain_KDS.Controls.Add(tabPagePCs_KDS);
            tabControlMain_KDS.Controls.Add(tabPageSuppliers_KDS);
            tabControlMain_KDS.Dock = DockStyle.Fill;
            tabControlMain_KDS.Location = new Point(0, 0);
            tabControlMain_KDS.Name = "tabControlMain_KDS";
            tabControlMain_KDS.SelectedIndex = 0;
            tabControlMain_KDS.Size = new Size(984, 507);
            tabControlMain_KDS.TabIndex = 0;
            // 
            // tabPagePCs_KDS
            // 
            tabPagePCs_KDS.Controls.Add(dataGridViewPCs_KDS);
            tabPagePCs_KDS.Location = new Point(4, 24);
            tabPagePCs_KDS.Name = "tabPagePCs_KDS";
            tabPagePCs_KDS.Padding = new Padding(3);
            tabPagePCs_KDS.Size = new Size(976, 479);
            tabPagePCs_KDS.TabIndex = 0;
            tabPagePCs_KDS.Text = "Компьютеры";
            tabPagePCs_KDS.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPCs_KDS
            // 
            dataGridViewPCs_KDS.AllowUserToAddRows = false;
            dataGridViewPCs_KDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPCs_KDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPCs_KDS.Dock = DockStyle.Fill;
            dataGridViewPCs_KDS.Location = new Point(3, 3);
            dataGridViewPCs_KDS.Name = "dataGridViewPCs_KDS";
            dataGridViewPCs_KDS.ReadOnly = true;
            dataGridViewPCs_KDS.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewPCs_KDS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPCs_KDS.Size = new Size(970, 473);
            dataGridViewPCs_KDS.TabIndex = 0;
            // 
            // tabPageSuppliers_KDS
            // 
            tabPageSuppliers_KDS.Controls.Add(dataGridViewSuppliers_KDS);
            tabPageSuppliers_KDS.Location = new Point(4, 24);
            tabPageSuppliers_KDS.Name = "tabPageSuppliers_KDS";
            tabPageSuppliers_KDS.Padding = new Padding(3);
            tabPageSuppliers_KDS.Size = new Size(976, 479);
            tabPageSuppliers_KDS.TabIndex = 1;
            tabPageSuppliers_KDS.Text = "Поставщики";
            tabPageSuppliers_KDS.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSuppliers_KDS
            // 
            dataGridViewSuppliers_KDS.AllowUserToAddRows = false;
            dataGridViewSuppliers_KDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers_KDS.Dock = DockStyle.Fill;
            dataGridViewSuppliers_KDS.Location = new Point(3, 3);
            dataGridViewSuppliers_KDS.Name = "dataGridViewSuppliers_KDS";
            dataGridViewSuppliers_KDS.ReadOnly = true;
            dataGridViewSuppliers_KDS.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewSuppliers_KDS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSuppliers_KDS.Size = new Size(970, 473);
            dataGridViewSuppliers_KDS.TabIndex = 0;
            // 
            // labelStatsResult_KDS
            // 
            labelStatsResult_KDS.AutoSize = true;
            labelStatsResult_KDS.Location = new Point(524, 103);
            labelStatsResult_KDS.Name = "labelStatsResult_KDS";
            labelStatsResult_KDS.RightToLeft = RightToLeft.No;
            labelStatsResult_KDS.Size = new Size(43, 15);
            labelStatsResult_KDS.TabIndex = 2;
            labelStatsResult_KDS.Text = "Итого:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(panelFill_KDS);
            Controls.Add(panelTop_KDS);
            Controls.Add(menuStripMain_KDS);
            MainMenuStrip = menuStripMain_KDS;
            Name = "FormMain";
            Text = "Менеджер ПК";
            menuStripMain_KDS.ResumeLayout(false);
            menuStripMain_KDS.PerformLayout();
            panelTop_KDS.ResumeLayout(false);
            panelTop_KDS.PerformLayout();
            groupBoxStats_KDS.ResumeLayout(false);
            groupBoxSearchFilter_KDS.ResumeLayout(false);
            groupBoxSearchFilter_KDS.PerformLayout();
            panelFill_KDS.ResumeLayout(false);
            tabControlMain_KDS.ResumeLayout(false);
            tabPagePCs_KDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPCs_KDS).EndInit();
            tabPageSuppliers_KDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers_KDS).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain_KDS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile_KDS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen_KDS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave_KDS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveAs_KDS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorFileMenu_KDS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit_KDS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddPC_KDS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeletePC_KDS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp_KDS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemManual_KDS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_KDS;
        private System.Windows.Forms.Panel panelTop_KDS;
        private System.Windows.Forms.GroupBox groupBoxStats_KDS;
        private System.Windows.Forms.Button buttonChart_KDS;
        private System.Windows.Forms.GroupBox groupBoxSearchFilter_KDS;
        private System.Windows.Forms.Button buttonApplyFilter_KDS;
        private System.Windows.Forms.Button buttonClearFilter_KDS;
        private System.Windows.Forms.TextBox textBoxSearchValue_KDS;
        private System.Windows.Forms.Label labelSearchValue_KDS;
        private System.Windows.Forms.ComboBox comboBoxFilterField_KDS;
        private System.Windows.Forms.Label labelFilterField_KDS;
        private System.Windows.Forms.Panel panelFill_KDS;
        private System.Windows.Forms.TabControl tabControlMain_KDS;
        private System.Windows.Forms.TabPage tabPagePCs_KDS;
        private System.Windows.Forms.TabPage tabPageSuppliers_KDS;
        private System.Windows.Forms.DataGridView dataGridViewPCs_KDS;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers_KDS;
        private Button buttonStatsSum;
        private Button buttonStatsCount;
        private Button buttonStatsAvg_KDS;
        private Button buttonStatsMin_KDS;
        private Button buttonStatsMax_KDS;
        private Label labelStatsResult_KDS;
    }
}