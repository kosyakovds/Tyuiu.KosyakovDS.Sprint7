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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuStripMain_KDS = new MenuStrip();
            toolStripMenuItemFile_KDS = new ToolStripMenuItem();
            toolStripMenuItemOpen_KDS = new ToolStripMenuItem();
            toolStripMenuItemSave_KDS = new ToolStripMenuItem();
            toolStripMenuItemSaveAs_KDS = new ToolStripMenuItem();
            toolStripSeparatorFileMenu_KDS = new ToolStripSeparator();
            toolStripMenuItemEdit_KDS = new ToolStripMenuItem();
            toolStripMenuItemAdd_KDS = new ToolStripMenuItem();
            toolStripMenuItemAddPC_KDS = new ToolStripMenuItem();
            toolStripMenuItemAddManufacturer_KDS = new ToolStripMenuItem();
            toolStripMenuItemDelete_KDS = new ToolStripMenuItem();
            toolStripMenuItemDeletePC_KDS = new ToolStripMenuItem();
            toolStripMenuItemDeleteManufacturer_KDS = new ToolStripMenuItem();
            toolStripMenuItemHelp_KDS = new ToolStripMenuItem();
            toolStripMenuItemManual_KDS = new ToolStripMenuItem();
            toolStripMenuItemAbout_KDS = new ToolStripMenuItem();
            panelTop_KDS = new Panel();
            labelStatsResult_KDS = new Label();
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
            buttonPieChart_KDS = new Button();
            panelFill_KDS = new Panel();
            tabControlMain_KDS = new TabControl();
            tabPagePCs_KDS = new TabPage();
            dataGridViewPCs_KDS = new DataGridView();
            tabPageSuppliers_KDS = new TabPage();
            dataGridViewSuppliers_KDS = new DataGridView();
            splitContainerLeft_KDS = new SplitContainer();
            groupBoxChart_KDS = new GroupBox();
            buttonLineChart_KDS = new Button();
            chartStats_KDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonColumnChart_KDS = new Button();
            toolTip_KDS = new ToolTip(components);
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
            ((System.ComponentModel.ISupportInitialize)splitContainerLeft_KDS).BeginInit();
            splitContainerLeft_KDS.Panel1.SuspendLayout();
            splitContainerLeft_KDS.Panel2.SuspendLayout();
            splitContainerLeft_KDS.SuspendLayout();
            groupBoxChart_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStats_KDS).BeginInit();
            SuspendLayout();
            // 
            // menuStripMain_KDS
            // 
            menuStripMain_KDS.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile_KDS, toolStripMenuItemEdit_KDS, toolStripMenuItemHelp_KDS });
            menuStripMain_KDS.Location = new Point(0, 0);
            menuStripMain_KDS.Name = "menuStripMain_KDS";
            menuStripMain_KDS.Size = new Size(1284, 24);
            menuStripMain_KDS.TabIndex = 0;
            menuStripMain_KDS.Text = "Главное меню";
            // 
            // toolStripMenuItemFile_KDS
            // 
            toolStripMenuItemFile_KDS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemOpen_KDS, toolStripMenuItemSave_KDS, toolStripMenuItemSaveAs_KDS, toolStripSeparatorFileMenu_KDS });
            toolStripMenuItemFile_KDS.Name = "toolStripMenuItemFile_KDS";
            toolStripMenuItemFile_KDS.Size = new Size(48, 20);
            toolStripMenuItemFile_KDS.Text = "Файл";
            toolStripMenuItemFile_KDS.ToolTipText = "Файловые операции";
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
            toolStripMenuItemEdit_KDS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAdd_KDS, toolStripMenuItemDelete_KDS });
            toolStripMenuItemEdit_KDS.Name = "toolStripMenuItemEdit_KDS";
            toolStripMenuItemEdit_KDS.Size = new Size(99, 20);
            toolStripMenuItemEdit_KDS.Text = "Редактировать";
            toolStripMenuItemEdit_KDS.ToolTipText = "Редактирование записей";
            // 
            // toolStripMenuItemAdd_KDS
            // 
            toolStripMenuItemAdd_KDS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAddPC_KDS, toolStripMenuItemAddManufacturer_KDS });
            toolStripMenuItemAdd_KDS.Name = "toolStripMenuItemAdd_KDS";
            toolStripMenuItemAdd_KDS.Size = new Size(126, 22);
            toolStripMenuItemAdd_KDS.Text = "Добавить";
            // 
            // toolStripMenuItemAddPC_KDS
            // 
            toolStripMenuItemAddPC_KDS.Name = "toolStripMenuItemAddPC_KDS";
            toolStripMenuItemAddPC_KDS.Size = new Size(143, 22);
            toolStripMenuItemAddPC_KDS.Text = "Компьютер";
            toolStripMenuItemAddPC_KDS.Click += toolStripMenuItemAddPC_KDS_Click;
            // 
            // toolStripMenuItemAddManufacturer_KDS
            // 
            toolStripMenuItemAddManufacturer_KDS.Name = "toolStripMenuItemAddManufacturer_KDS";
            toolStripMenuItemAddManufacturer_KDS.Size = new Size(143, 22);
            toolStripMenuItemAddManufacturer_KDS.Text = "Поставщика";
            toolStripMenuItemAddManufacturer_KDS.Click += toolStripMenuItemAddManufacturer_KDS_Click;
            // 
            // toolStripMenuItemDelete_KDS
            // 
            toolStripMenuItemDelete_KDS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemDeletePC_KDS, toolStripMenuItemDeleteManufacturer_KDS });
            toolStripMenuItemDelete_KDS.Name = "toolStripMenuItemDelete_KDS";
            toolStripMenuItemDelete_KDS.Size = new Size(126, 22);
            toolStripMenuItemDelete_KDS.Text = "Удалить";
            // 
            // toolStripMenuItemDeletePC_KDS
            // 
            toolStripMenuItemDeletePC_KDS.Name = "toolStripMenuItemDeletePC_KDS";
            toolStripMenuItemDeletePC_KDS.Size = new Size(143, 22);
            toolStripMenuItemDeletePC_KDS.Text = "Компьютер";
            toolStripMenuItemDeletePC_KDS.Click += toolStripMenuItemDeletePC_KDS_Click;
            // 
            // toolStripMenuItemDeleteManufacturer_KDS
            // 
            toolStripMenuItemDeleteManufacturer_KDS.Name = "toolStripMenuItemDeleteManufacturer_KDS";
            toolStripMenuItemDeleteManufacturer_KDS.Size = new Size(143, 22);
            toolStripMenuItemDeleteManufacturer_KDS.Text = "Поставщика";
            toolStripMenuItemDeleteManufacturer_KDS.Click += toolStripMenuItemDeleteManufacturer_KDS_Click;
            // 
            // toolStripMenuItemHelp_KDS
            // 
            toolStripMenuItemHelp_KDS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemManual_KDS, toolStripMenuItemAbout_KDS });
            toolStripMenuItemHelp_KDS.Name = "toolStripMenuItemHelp_KDS";
            toolStripMenuItemHelp_KDS.Size = new Size(65, 20);
            toolStripMenuItemHelp_KDS.Text = "Справка";
            toolStripMenuItemHelp_KDS.ToolTipText = "Полезная информация";
            // 
            // toolStripMenuItemManual_KDS
            // 
            toolStripMenuItemManual_KDS.Name = "toolStripMenuItemManual_KDS";
            toolStripMenuItemManual_KDS.Size = new Size(180, 22);
            toolStripMenuItemManual_KDS.Text = "Руководство";
            toolStripMenuItemManual_KDS.Click += toolStripMenuItemManual_KDS_Click;
            // 
            // toolStripMenuItemAbout_KDS
            // 
            toolStripMenuItemAbout_KDS.Name = "toolStripMenuItemAbout_KDS";
            toolStripMenuItemAbout_KDS.Size = new Size(180, 22);
            toolStripMenuItemAbout_KDS.Text = "О программе";
            toolStripMenuItemAbout_KDS.Click += toolStripMenuItemAbout_KDS_Click;
            // 
            // panelTop_KDS
            // 
            panelTop_KDS.Controls.Add(labelStatsResult_KDS);
            panelTop_KDS.Controls.Add(groupBoxStats_KDS);
            panelTop_KDS.Controls.Add(groupBoxSearchFilter_KDS);
            panelTop_KDS.Dock = DockStyle.Top;
            panelTop_KDS.Location = new Point(0, 0);
            panelTop_KDS.Name = "panelTop_KDS";
            panelTop_KDS.Size = new Size(800, 124);
            panelTop_KDS.TabIndex = 1;
            // 
            // labelStatsResult_KDS
            // 
            labelStatsResult_KDS.AutoSize = true;
            labelStatsResult_KDS.Location = new Point(12, 103);
            labelStatsResult_KDS.Name = "labelStatsResult_KDS";
            labelStatsResult_KDS.RightToLeft = RightToLeft.No;
            labelStatsResult_KDS.Size = new Size(43, 15);
            labelStatsResult_KDS.TabIndex = 2;
            labelStatsResult_KDS.Text = "Итого:";
            // 
            // groupBoxStats_KDS
            // 
            groupBoxStats_KDS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxStats_KDS.Controls.Add(buttonStatsSum);
            groupBoxStats_KDS.Controls.Add(buttonStatsCount);
            groupBoxStats_KDS.Controls.Add(buttonStatsAvg_KDS);
            groupBoxStats_KDS.Controls.Add(buttonStatsMin_KDS);
            groupBoxStats_KDS.Controls.Add(buttonStatsMax_KDS);
            groupBoxStats_KDS.Location = new Point(423, 10);
            groupBoxStats_KDS.Name = "groupBoxStats_KDS";
            groupBoxStats_KDS.Size = new Size(370, 90);
            groupBoxStats_KDS.TabIndex = 1;
            groupBoxStats_KDS.TabStop = false;
            groupBoxStats_KDS.Text = "Статистика";
            // 
            // buttonStatsSum
            // 
            buttonStatsSum.BackgroundImage = Properties.Resources.sigma;
            buttonStatsSum.BackgroundImageLayout = ImageLayout.Zoom;
            buttonStatsSum.Location = new Point(154, 24);
            buttonStatsSum.Name = "buttonStatsSum";
            buttonStatsSum.Size = new Size(60, 60);
            buttonStatsSum.TabIndex = 0;
            toolTip_KDS.SetToolTip(buttonStatsSum, "Найти сумму элементов");
            buttonStatsSum.UseVisualStyleBackColor = true;
            buttonStatsSum.Click += buttonStatsSum_Click;
            // 
            // buttonStatsCount
            // 
            buttonStatsCount.BackgroundImage = Properties.Resources.tally;
            buttonStatsCount.BackgroundImageLayout = ImageLayout.Zoom;
            buttonStatsCount.Location = new Point(302, 24);
            buttonStatsCount.Name = "buttonStatsCount";
            buttonStatsCount.Size = new Size(60, 60);
            buttonStatsCount.TabIndex = 0;
            toolTip_KDS.SetToolTip(buttonStatsCount, "Найти количество элементов");
            buttonStatsCount.UseVisualStyleBackColor = true;
            buttonStatsCount.Click += buttonStatsCount_Click;
            // 
            // buttonStatsAvg_KDS
            // 
            buttonStatsAvg_KDS.BackgroundImage = Properties.Resources.average__1_;
            buttonStatsAvg_KDS.BackgroundImageLayout = ImageLayout.Zoom;
            buttonStatsAvg_KDS.Location = new Point(228, 24);
            buttonStatsAvg_KDS.Name = "buttonStatsAvg_KDS";
            buttonStatsAvg_KDS.Size = new Size(60, 60);
            buttonStatsAvg_KDS.TabIndex = 0;
            toolTip_KDS.SetToolTip(buttonStatsAvg_KDS, "Найти среднее элементов");
            buttonStatsAvg_KDS.UseVisualStyleBackColor = true;
            buttonStatsAvg_KDS.Click += buttonStatsAvg_KDS_Click;
            // 
            // buttonStatsMin_KDS
            // 
            buttonStatsMin_KDS.BackgroundImage = Properties.Resources.min;
            buttonStatsMin_KDS.BackgroundImageLayout = ImageLayout.Zoom;
            buttonStatsMin_KDS.Location = new Point(6, 24);
            buttonStatsMin_KDS.Name = "buttonStatsMin_KDS";
            buttonStatsMin_KDS.Size = new Size(60, 60);
            buttonStatsMin_KDS.TabIndex = 0;
            toolTip_KDS.SetToolTip(buttonStatsMin_KDS, "Найти минимальный элемент");
            buttonStatsMin_KDS.UseVisualStyleBackColor = true;
            buttonStatsMin_KDS.Click += buttonStatsMin_KDS_Click;
            // 
            // buttonStatsMax_KDS
            // 
            buttonStatsMax_KDS.BackgroundImage = Properties.Resources.max;
            buttonStatsMax_KDS.BackgroundImageLayout = ImageLayout.Zoom;
            buttonStatsMax_KDS.Location = new Point(80, 24);
            buttonStatsMax_KDS.Name = "buttonStatsMax_KDS";
            buttonStatsMax_KDS.Size = new Size(60, 60);
            buttonStatsMax_KDS.TabIndex = 0;
            toolTip_KDS.SetToolTip(buttonStatsMax_KDS, "Найти максимальный элемент");
            buttonStatsMax_KDS.UseVisualStyleBackColor = true;
            buttonStatsMax_KDS.Click += buttonStatsMax_KDS_Click;
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
            groupBoxSearchFilter_KDS.Size = new Size(400, 90);
            groupBoxSearchFilter_KDS.TabIndex = 0;
            groupBoxSearchFilter_KDS.TabStop = false;
            groupBoxSearchFilter_KDS.Text = "Поиск и фильтрация";
            // 
            // buttonClearFilter_KDS
            // 
            buttonClearFilter_KDS.BackgroundImage = Properties.Resources.trash;
            buttonClearFilter_KDS.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClearFilter_KDS.Location = new Point(348, 34);
            buttonClearFilter_KDS.Name = "buttonClearFilter_KDS";
            buttonClearFilter_KDS.Size = new Size(46, 42);
            buttonClearFilter_KDS.TabIndex = 5;
            toolTip_KDS.SetToolTip(buttonClearFilter_KDS, "Сбросить фильтр");
            buttonClearFilter_KDS.UseVisualStyleBackColor = true;
            buttonClearFilter_KDS.Click += buttonClearFilter_KDS_Click;
            // 
            // buttonApplyFilter_KDS
            // 
            buttonApplyFilter_KDS.BackgroundImage = Properties.Resources.added;
            buttonApplyFilter_KDS.BackgroundImageLayout = ImageLayout.Zoom;
            buttonApplyFilter_KDS.Location = new Point(296, 33);
            buttonApplyFilter_KDS.Name = "buttonApplyFilter_KDS";
            buttonApplyFilter_KDS.Size = new Size(46, 43);
            buttonApplyFilter_KDS.TabIndex = 4;
            toolTip_KDS.SetToolTip(buttonApplyFilter_KDS, "Применить фильтр");
            buttonApplyFilter_KDS.UseVisualStyleBackColor = true;
            buttonApplyFilter_KDS.Click += buttonApplyFilter_KDS_Click;
            // 
            // textBoxSearchValue_KDS
            // 
            textBoxSearchValue_KDS.Location = new Point(170, 43);
            textBoxSearchValue_KDS.Name = "textBoxSearchValue_KDS";
            textBoxSearchValue_KDS.Size = new Size(120, 23);
            textBoxSearchValue_KDS.TabIndex = 3;
            toolTip_KDS.SetToolTip(textBoxSearchValue_KDS, "Введите ключевое значение для фильтра");
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
            comboBoxFilterField_KDS.Items.AddRange(new object[] { "Все столбцы", "Производитель", "Процессор", "Видеокарта", "ОЗУ", "Жёсткий диск", "Дата выпуска" });
            comboBoxFilterField_KDS.Location = new Point(10, 43);
            comboBoxFilterField_KDS.Name = "comboBoxFilterField_KDS";
            comboBoxFilterField_KDS.Size = new Size(150, 23);
            comboBoxFilterField_KDS.TabIndex = 1;
            toolTip_KDS.SetToolTip(comboBoxFilterField_KDS, "Выберите элемент из поля фильтра");
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
            // buttonPieChart_KDS
            // 
            buttonPieChart_KDS.BackgroundImage = Properties.Resources.pie_chart;
            buttonPieChart_KDS.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPieChart_KDS.Location = new Point(138, 23);
            buttonPieChart_KDS.Name = "buttonPieChart_KDS";
            buttonPieChart_KDS.Size = new Size(60, 60);
            buttonPieChart_KDS.TabIndex = 1;
            toolTip_KDS.SetToolTip(buttonPieChart_KDS, "Построить круговую диаграмму");
            buttonPieChart_KDS.UseVisualStyleBackColor = true;
            buttonPieChart_KDS.Click += buttonPieChart_KDS_Click;
            // 
            // panelFill_KDS
            // 
            panelFill_KDS.Controls.Add(tabControlMain_KDS);
            panelFill_KDS.Dock = DockStyle.Bottom;
            panelFill_KDS.Location = new Point(0, 130);
            panelFill_KDS.Name = "panelFill_KDS";
            panelFill_KDS.Size = new Size(800, 507);
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
            tabControlMain_KDS.Size = new Size(800, 507);
            tabControlMain_KDS.TabIndex = 0;
            // 
            // tabPagePCs_KDS
            // 
            tabPagePCs_KDS.Controls.Add(dataGridViewPCs_KDS);
            tabPagePCs_KDS.Location = new Point(4, 24);
            tabPagePCs_KDS.Name = "tabPagePCs_KDS";
            tabPagePCs_KDS.Padding = new Padding(3);
            tabPagePCs_KDS.Size = new Size(792, 479);
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
            dataGridViewPCs_KDS.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewPCs_KDS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPCs_KDS.Size = new Size(786, 473);
            dataGridViewPCs_KDS.TabIndex = 0;
            // 
            // tabPageSuppliers_KDS
            // 
            tabPageSuppliers_KDS.Controls.Add(dataGridViewSuppliers_KDS);
            tabPageSuppliers_KDS.Location = new Point(4, 24);
            tabPageSuppliers_KDS.Name = "tabPageSuppliers_KDS";
            tabPageSuppliers_KDS.Padding = new Padding(3);
            tabPageSuppliers_KDS.Size = new Size(792, 479);
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
            dataGridViewSuppliers_KDS.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewSuppliers_KDS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSuppliers_KDS.Size = new Size(786, 473);
            dataGridViewSuppliers_KDS.TabIndex = 0;
            // 
            // splitContainerLeft_KDS
            // 
            splitContainerLeft_KDS.Dock = DockStyle.Fill;
            splitContainerLeft_KDS.Location = new Point(0, 24);
            splitContainerLeft_KDS.Name = "splitContainerLeft_KDS";
            // 
            // splitContainerLeft_KDS.Panel1
            // 
            splitContainerLeft_KDS.Panel1.Controls.Add(panelTop_KDS);
            splitContainerLeft_KDS.Panel1.Controls.Add(panelFill_KDS);
            // 
            // splitContainerLeft_KDS.Panel2
            // 
            splitContainerLeft_KDS.Panel2.Controls.Add(groupBoxChart_KDS);
            splitContainerLeft_KDS.Size = new Size(1284, 637);
            splitContainerLeft_KDS.SplitterDistance = 800;
            splitContainerLeft_KDS.TabIndex = 3;
            // 
            // groupBoxChart_KDS
            // 
            groupBoxChart_KDS.Controls.Add(buttonLineChart_KDS);
            groupBoxChart_KDS.Controls.Add(chartStats_KDS);
            groupBoxChart_KDS.Controls.Add(buttonColumnChart_KDS);
            groupBoxChart_KDS.Controls.Add(buttonPieChart_KDS);
            groupBoxChart_KDS.Location = new Point(12, 10);
            groupBoxChart_KDS.Name = "groupBoxChart_KDS";
            groupBoxChart_KDS.Size = new Size(456, 620);
            groupBoxChart_KDS.TabIndex = 3;
            groupBoxChart_KDS.TabStop = false;
            groupBoxChart_KDS.Text = "График";
            // 
            // buttonLineChart_KDS
            // 
            buttonLineChart_KDS.BackgroundImage = Properties.Resources.line;
            buttonLineChart_KDS.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLineChart_KDS.Location = new Point(72, 24);
            buttonLineChart_KDS.Name = "buttonLineChart_KDS";
            buttonLineChart_KDS.Size = new Size(60, 60);
            buttonLineChart_KDS.TabIndex = 1;
            toolTip_KDS.SetToolTip(buttonLineChart_KDS, "Построить функцию");
            buttonLineChart_KDS.UseVisualStyleBackColor = true;
            buttonLineChart_KDS.Click += buttonLineChart_KDS_Click;
            // 
            // chartStats_KDS
            // 
            chartArea2.Name = "ChartArea1";
            chartStats_KDS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartStats_KDS.Legends.Add(legend2);
            chartStats_KDS.Location = new Point(6, 93);
            chartStats_KDS.Name = "chartStats_KDS";
            chartStats_KDS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartStats_KDS.Series.Add(series2);
            chartStats_KDS.Size = new Size(444, 521);
            chartStats_KDS.TabIndex = 2;
            // 
            // buttonColumnChart_KDS
            // 
            buttonColumnChart_KDS.BackgroundImage = Properties.Resources.bar_chart;
            buttonColumnChart_KDS.BackgroundImageLayout = ImageLayout.Zoom;
            buttonColumnChart_KDS.Location = new Point(6, 25);
            buttonColumnChart_KDS.Name = "buttonColumnChart_KDS";
            buttonColumnChart_KDS.Size = new Size(60, 60);
            buttonColumnChart_KDS.TabIndex = 1;
            toolTip_KDS.SetToolTip(buttonColumnChart_KDS, "Построить гистограмму");
            buttonColumnChart_KDS.UseVisualStyleBackColor = true;
            buttonColumnChart_KDS.Click += buttonColumnChart_KDS_Click;
            // 
            // toolTip_KDS
            // 
            toolTip_KDS.ToolTipIcon = ToolTipIcon.Info;
            toolTip_KDS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 661);
            Controls.Add(splitContainerLeft_KDS);
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
            splitContainerLeft_KDS.Panel1.ResumeLayout(false);
            splitContainerLeft_KDS.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerLeft_KDS).EndInit();
            splitContainerLeft_KDS.ResumeLayout(false);
            groupBoxChart_KDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartStats_KDS).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd_KDS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete_KDS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp_KDS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemManual_KDS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_KDS;
        private System.Windows.Forms.Panel panelTop_KDS;
        private System.Windows.Forms.GroupBox groupBoxStats_KDS;
        private System.Windows.Forms.Button buttonPieChart_KDS;
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
        private System.Windows.Forms.SplitContainer splitContainerMain_KDS;
        private SplitContainer splitContainerLeft_KDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_KDS;
        private Button buttonLineChart_KDS;
        private Button buttonColumnChart_KDS;
        private ToolStripMenuItem toolStripMenuItemAddPC_KDS;
        private ToolStripMenuItem toolStripMenuItemAddManufacturer_KDS;
        private ToolStripMenuItem toolStripMenuItemDeletePC_KDS;
        private ToolStripMenuItem toolStripMenuItemDeleteManufacturer_KDS;
        private Label labelStatsResult_KDS;
        private GroupBox groupBoxChart_KDS;
        private ToolTip toolTip_KDS;
    }
}