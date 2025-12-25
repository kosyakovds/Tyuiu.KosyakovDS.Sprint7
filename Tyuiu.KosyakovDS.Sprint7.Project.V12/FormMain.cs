using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Tyuiu.KosyakovDS.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            InitializeComponent();
            InitializeDataGridViewColumns();
        }

        private void toolStripMenuItemAbout_KDS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void InitializeDataGridViewColumns()
        {

            dataGridViewPCs_KDS.Columns.Clear();
            dataGridViewSuppliers_KDS.Columns.Clear();


            dataGridViewPCs_KDS.Columns.Add("Manufacturer", "Производитель");
            dataGridViewPCs_KDS.Columns.Add("CPU", "Процессор");
            dataGridViewPCs_KDS.Columns.Add("GPU", "Видеокарта");

            int ramCol = dataGridViewPCs_KDS.Columns.Add("RAM", "ОЗУ");
            dataGridViewPCs_KDS.Columns[ramCol].ValueType = typeof(int);

            int hddCol = dataGridViewPCs_KDS.Columns.Add("HDD", "Жёсткий диск");
            dataGridViewPCs_KDS.Columns[hddCol].ValueType = typeof(int);

            int dateCol = dataGridViewPCs_KDS.Columns.Add("ReleaseDate", "Дата выпуска");
            dataGridViewPCs_KDS.Columns[dateCol].ValueType = typeof(DateTime);
            dataGridViewPCs_KDS.Columns[dateCol].DefaultCellStyle.Format = "d";

            dataGridViewSuppliers_KDS.Columns.Add("Name", "Наименование");
            dataGridViewSuppliers_KDS.Columns.Add("Address", "Адрес");
            dataGridViewSuppliers_KDS.Columns.Add("Phone", "Телефон");
            dataGridViewSuppliers_KDS.Columns.Add("Note", "Примечание");
        }

        private List<PersonalComputer> pcList_KDS = new List<PersonalComputer>();

        private void ToolStripMenuItemOpen_KDS_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            openFileDialog.Title = "Выберите папку с файлами";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(openFileDialog.FileName);

                string pcsFile = Path.Combine(folderPath, "pcs.csv");
                string suppliersFile = Path.Combine(folderPath, "suppliers.csv");

                LoadPCs(pcsFile);
                LoadSuppliers(suppliersFile);

                MessageBox.Show("Файлы успешно загружены!");
            }
        }

        private void LoadPCs(string fileName)
        {
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Файл " + fileName + " не найден!");
                return;
            }

            dataGridViewPCs_KDS.Rows.Clear();
            pcList_KDS.Clear();

            string[] lines = File.ReadAllLines(fileName, Encoding.GetEncoding(1251));

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                if (parts.Length >= 6)
                {
                    int ram = int.TryParse(parts[3], out int r) ? r : 0;
                    int hdd = int.TryParse(parts[4], out int h) ? h : 0;
                    DateTime date = DateTime.TryParse(parts[5], out DateTime d) ? d : DateTime.MinValue;

                    dataGridViewPCs_KDS.Rows.Add(parts[0], parts[1], parts[2], ram, hdd, date);

                    pcList_KDS.Add(new PersonalComputer
                    {
                        Manufacturer = parts[0],
                        Processor = parts[1],
                        Frequency = parts[2],
                        RAM = parts[3],
                        HDD = parts[4],
                        ReleaseDate = parts[5]
                    });
                }
            }
        }

        private void LoadSuppliers(string fileName)
        {
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Файл " + fileName + " не найден!");
                return;
            }

            dataGridViewSuppliers_KDS.Rows.Clear();
            string[] lines = File.ReadAllLines(fileName, Encoding.GetEncoding(1251));

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                if (parts.Length >= 4)
                {
                    dataGridViewSuppliers_KDS.Rows.Add(parts[0], parts[1], parts[2], parts[3]);
                }
            }
        }

        private void ToolStripMenuItemSave_KDS_Click(object sender, EventArgs e)
        {
            SavePCs("pcs.csv");
            SaveSuppliers("suppliers.csv");
            MessageBox.Show("Данные успешно сохранены!");
        }

        private void ToolStripMenuItemSaveAs_KDS_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Выберите папку для сохранения файлов";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderDialog.SelectedPath;

                SavePCs(Path.Combine(folderPath, "pcs.csv"));
                SaveSuppliers(Path.Combine(folderPath, "suppliers.csv"));

                MessageBox.Show("Данные успешно сохранены в папку: " + folderPath);
            }
        }

        private void SavePCs(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Производитель;Процессор;Частота;ОЗУ;Жесткий диск;Дата выпуска");

            foreach (DataGridViewRow row in dataGridViewPCs_KDS.Rows)
            {
                if (row.IsNewRow) continue;

                string manufacturer = row.Cells[0].Value?.ToString() ?? "";
                string processor = row.Cells[1].Value?.ToString() ?? "";
                string frequency = row.Cells[2].Value?.ToString() ?? "";
                string ram = row.Cells[3].Value?.ToString() ?? "";
                string hdd = row.Cells[4].Value?.ToString() ?? "";
                string date = row.Cells[5].Value?.ToString() ?? "";

                sb.AppendLine($"{manufacturer};{processor};{frequency};{ram};{hdd};{date}");
            }

            File.WriteAllText(fileName, sb.ToString(), Encoding.GetEncoding(1251));
        }

        private void SaveSuppliers(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Наименование;Адрес;Телефон;Примечание");

            foreach (DataGridViewRow row in dataGridViewSuppliers_KDS.Rows)
            {
                if (row.IsNewRow) continue;

                string name = row.Cells[0].Value?.ToString() ?? "";
                string address = row.Cells[1].Value?.ToString() ?? "";
                string phone = row.Cells[2].Value?.ToString() ?? "";
                string note = row.Cells[3].Value?.ToString() ?? "";

                sb.AppendLine($"{name};{address};{phone};{note}");
            }

            File.WriteAllText(fileName, sb.ToString(), Encoding.GetEncoding(1251));
        }

        private void buttonStatsSum_Click(object sender, EventArgs e)
        {
            dataGridViewPCs_KDS.EndEdit();

            if (dataGridViewPCs_KDS.CurrentCell != null)
            {
                int targetColIndex = dataGridViewPCs_KDS.CurrentCell.ColumnIndex;
                string columnName = dataGridViewPCs_KDS.Columns[targetColIndex].HeaderText;

                List<PersonalComputer> selectedPCs = new List<PersonalComputer>();
                string rowsText = "";

                foreach (DataGridViewCell cell in dataGridViewPCs_KDS.SelectedCells)
                {
                    if (cell.ColumnIndex == targetColIndex)
                    {
                        int rIdx = cell.RowIndex;
                        if (rIdx != -1 && rIdx < pcList_KDS.Count)
                        {
                            selectedPCs.Add(pcList_KDS[rIdx]);

                            if (rowsText != "") rowsText += ", ";
                            rowsText += (rIdx + 1).ToString();
                        }
                    }
                }

                double result = ds.CalculateSum(selectedPCs, columnName);

                labelStatsResult_KDS.Text = $"Итого: Сумма по столбцу [{columnName}] и строкам [{rowsText}]: {result}";
            }
        }

        private void buttonStatsAvg_KDS_Click(object sender, EventArgs e)
        {
            dataGridViewPCs_KDS.EndEdit();

            if (dataGridViewPCs_KDS.CurrentCell != null)
            {
                int targetColIndex = dataGridViewPCs_KDS.CurrentCell.ColumnIndex;
                string columnName = dataGridViewPCs_KDS.Columns[targetColIndex].HeaderText;

                List<PersonalComputer> selectedPCs = new List<PersonalComputer>();
                string rowsText = "";

                foreach (DataGridViewCell cell in dataGridViewPCs_KDS.SelectedCells)
                {
                    if (cell.ColumnIndex == targetColIndex)
                    {
                        int rIdx = cell.RowIndex;
                        if (rIdx != -1 && rIdx < pcList_KDS.Count)
                        {
                            selectedPCs.Add(pcList_KDS[rIdx]);

                            if (rowsText != "") rowsText += ", ";
                            rowsText += (rIdx + 1).ToString();
                        }
                    }
                }

                double result = ds.CalculateAverage(selectedPCs, columnName);

                labelStatsResult_KDS.Text = $"Итого: Среднее по [{columnName}] для строк [{rowsText}]: {Math.Round(result, 2)}";
            }
        }

        private void buttonStatsMax_KDS_Click(object sender, EventArgs e)
        {
            dataGridViewPCs_KDS.EndEdit();

            if (dataGridViewPCs_KDS.CurrentCell != null)
            {
                int targetColIndex = dataGridViewPCs_KDS.CurrentCell.ColumnIndex;
                string columnName = dataGridViewPCs_KDS.Columns[targetColIndex].HeaderText;

                List<PersonalComputer> selectedPCs = new List<PersonalComputer>();
                string rowsText = "";

                foreach (DataGridViewCell cell in dataGridViewPCs_KDS.SelectedCells)
                {
                    if (cell.ColumnIndex == targetColIndex)
                    {
                        int rIdx = cell.RowIndex;
                        if (rIdx != -1 && rIdx < pcList_KDS.Count)
                        {
                            selectedPCs.Add(pcList_KDS[rIdx]);
                            if (rowsText != "") rowsText += ", ";
                            rowsText += (rIdx + 1).ToString();
                        }
                    }
                }

                double result = ds.CalculateMax(selectedPCs, columnName);
                labelStatsResult_KDS.Text = $"Итого: Максимум по [{columnName}] для строк [{rowsText}]: {result}";
            }
        }

        private void buttonStatsMin_KDS_Click(object sender, EventArgs e)
        {
            dataGridViewPCs_KDS.EndEdit();

            if (dataGridViewPCs_KDS.CurrentCell != null)
            {
                int targetColIndex = dataGridViewPCs_KDS.CurrentCell.ColumnIndex;
                string columnName = dataGridViewPCs_KDS.Columns[targetColIndex].HeaderText;

                List<PersonalComputer> selectedPCs = new List<PersonalComputer>();
                string rowsText = "";

                foreach (DataGridViewCell cell in dataGridViewPCs_KDS.SelectedCells)
                {
                    if (cell.ColumnIndex == targetColIndex)
                    {
                        int rIdx = cell.RowIndex;
                        if (rIdx != -1 && rIdx < pcList_KDS.Count)
                        {
                            selectedPCs.Add(pcList_KDS[rIdx]);
                            if (rowsText != "") rowsText += ", ";
                            rowsText += (rIdx + 1).ToString();
                        }
                    }
                }

                double result = ds.CalculateMin(selectedPCs, columnName);
                labelStatsResult_KDS.Text = $"Итого: Минимум по [{columnName}] для строк [{rowsText}]: {result}";
            }
        }

        private void buttonStatsCount_Click(object sender, EventArgs e)
        {
            dataGridViewPCs_KDS.EndEdit();

            if (dataGridViewPCs_KDS.CurrentCell != null)
            {
                int targetColIndex = dataGridViewPCs_KDS.CurrentCell.ColumnIndex;
                string columnName = dataGridViewPCs_KDS.Columns[targetColIndex].HeaderText;

                List<PersonalComputer> selectedPCs = new List<PersonalComputer>();
                string rowsText = "";

                foreach (DataGridViewCell cell in dataGridViewPCs_KDS.SelectedCells)
                {
                    if (cell.ColumnIndex == targetColIndex)
                    {
                        int rIdx = cell.RowIndex;
                        if (rIdx != -1 && rIdx < pcList_KDS.Count)
                        {
                            selectedPCs.Add(pcList_KDS[rIdx]);

                            if (rowsText != "") rowsText += ", ";
                            rowsText += (rIdx + 1).ToString();
                        }
                    }
                }

                int result = ds.CalculateCount(selectedPCs, columnName);

                labelStatsResult_KDS.Text = $"Итого: Количество записей по [{columnName}] в строках [{rowsText}]: {result}";
            }
        }
        private void buttonColumnChart_KDS_Click(object sender, EventArgs e)
        {
            if (dataGridViewPCs_KDS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строки в таблице!");
                return;
            }

            int targetCol = dataGridViewPCs_KDS.CurrentCell.ColumnIndex;
            string colName = dataGridViewPCs_KDS.Columns[targetCol].HeaderText;

            chartStats_KDS.Series[0].Points.Clear();
            chartStats_KDS.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartStats_KDS.Series[0].Name = colName;

            chartStats_KDS.Series[0]["PointWidth"] = "0.7";

            chartStats_KDS.ChartAreas[0].AxisX.Interval = 1;
            chartStats_KDS.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            int xPos = 1;

            var selectedRows = dataGridViewPCs_KDS.SelectedRows;

            foreach (DataGridViewRow row in selectedRows)
            {
                if (row.IsNewRow) continue;

                string name;
                if (row.Cells[0].Value != null)
                {
                    name = row.Cells[0].Value.ToString();
                }
                else
                {
                    name = "ПК";
                }

                double value = ds.GetValidDouble(row.Cells[targetCol].Value);

                int pIdx = chartStats_KDS.Series[0].Points.AddXY(xPos, value);

                chartStats_KDS.Series[0].Points[pIdx].AxisLabel = name;
                chartStats_KDS.Series[0].Points[pIdx].Label = value.ToString();

                xPos++;
            }
        }

        private void buttonPieChart_KDS_Click(object sender, EventArgs e)
        {
            if (dataGridViewPCs_KDS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строки в таблице!");
                return;
            }

            int targetCol = dataGridViewPCs_KDS.CurrentCell.ColumnIndex;
            string colName = dataGridViewPCs_KDS.Columns[targetCol].HeaderText;

            chartStats_KDS.Series[0].Points.Clear();
            chartStats_KDS.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (DataGridViewRow row in dataGridViewPCs_KDS.SelectedRows)
            {
                if (row.IsNewRow) continue;

                string name;
                if (row.Cells[0].Value != null)
                {
                    name = row.Cells[0].Value.ToString();
                }
                else
                {
                    name = "ПК";
                }

                double value = ds.GetValidDouble(row.Cells[targetCol].Value);

                if (value > 0)
                {
                    int pIdx = chartStats_KDS.Series[0].Points.AddXY(name, value);
                    chartStats_KDS.Series[0].Points[pIdx].Label = "#VALY";
                    chartStats_KDS.Series[0].Points[pIdx].LegendText = name;
                }
            }
        }

        private void buttonLineChart_KDS_Click(object sender, EventArgs e)
        {
            if (dataGridViewPCs_KDS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строки в таблице!");
                return;
            }

            int targetCol = dataGridViewPCs_KDS.CurrentCell.ColumnIndex;
            string colName = dataGridViewPCs_KDS.Columns[targetCol].HeaderText;

            chartStats_KDS.Series[0].Points.Clear();
            chartStats_KDS.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartStats_KDS.Series[0].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            chartStats_KDS.Series[0].MarkerSize = 8;
            chartStats_KDS.Series[0].BorderWidth = 3;
            chartStats_KDS.Series[0].Name = colName;

            chartStats_KDS.ChartAreas[0].AxisX.Interval = 1;
            chartStats_KDS.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            int xPos = 1;

            foreach (DataGridViewRow row in dataGridViewPCs_KDS.SelectedRows)
            {
                if (row.IsNewRow) continue;

                string name;
                if (row.Cells[0].Value != null)
                {
                    name = row.Cells[0].Value.ToString();
                }
                else
                {
                    name = "ПК";
                }

                double value = ds.GetValidDouble(row.Cells[targetCol].Value);

                int pIdx = chartStats_KDS.Series[0].Points.AddXY(xPos, value);

                chartStats_KDS.Series[0].Points[pIdx].AxisLabel = name;
                chartStats_KDS.Series[0].Points[pIdx].Label = value.ToString();

                xPos++;
            }
        }

        private void toolStripMenuItemDeletePC_KDS_Click(object sender, EventArgs e)
        {
            if (dataGridViewPCs_KDS.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выбранные записи?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewPCs_KDS.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            dataGridViewPCs_KDS.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выделите строку для удаления.");
            }
        }

        private void toolStripMenuItemAddPC_KDS_Click(object sender, EventArgs e)
        {
            dataGridViewPCs_KDS.Rows.Add();

            int lastRow = dataGridViewPCs_KDS.Rows.Count - 1;
            dataGridViewPCs_KDS.CurrentCell = dataGridViewPCs_KDS.Rows[lastRow].Cells[0];

            dataGridViewPCs_KDS.BeginEdit(true);
        }

        private void toolStripMenuItemDeleteManufacturer_KDS_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers_KDS.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выбранные записи?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewSuppliers_KDS.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            dataGridViewSuppliers_KDS.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выделите строку для удаления.");
            }
        }

        private void toolStripMenuItemAddManufacturer_KDS_Click(object sender, EventArgs e)
        {
            dataGridViewSuppliers_KDS.Rows.Add();

            int lastRow = dataGridViewSuppliers_KDS.Rows.Count - 1;
            dataGridViewSuppliers_KDS.CurrentCell = dataGridViewSuppliers_KDS.Rows[lastRow].Cells[0];

            dataGridViewSuppliers_KDS.BeginEdit(true);
        }

        private void buttonApplyFilter_KDS_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearchValue_KDS.Text.ToLower().Trim();
            string selectedColumnName = comboBoxFilterField_KDS.SelectedItem?.ToString();

            dataGridViewPCs_KDS.CurrentCell = null;

            foreach (DataGridViewRow row in dataGridViewPCs_KDS.Rows)
            {
                if (row.IsNewRow) continue;

                bool isVisible = false;

                if (selectedColumnName == "Все столбцы" || string.IsNullOrEmpty(selectedColumnName))
                {
                    for (int j = 0; j < row.Cells.Count; j++)
                    {
                        if (row.Cells[j].Value != null &&
                            row.Cells[j].Value.ToString().ToLower().Contains(searchText))
                        {
                            isVisible = true;
                            break;
                        }
                    }
                }
                else
                {
                    int targetColIndex = -1;
                    for (int i = 0; i < dataGridViewPCs_KDS.Columns.Count; i++)
                    {
                        if (dataGridViewPCs_KDS.Columns[i].HeaderText == selectedColumnName)
                        {
                            targetColIndex = i;
                            break;
                        }
                    }

                    if (targetColIndex != -1)
                    {
                        string cellValue = row.Cells[targetColIndex].Value?.ToString().ToLower() ?? "";
                        if (cellValue.Contains(searchText))
                        {
                            isVisible = true;
                        }
                    }
                }

                row.Visible = isVisible;
            }
        }

        private void buttonClearFilter_KDS_Click(object sender, EventArgs e)
        {

            textBoxSearchValue_KDS.Clear();
            comboBoxFilterField_KDS.SelectedIndex = 0;
            dataGridViewPCs_KDS.CurrentCell = null;

            foreach (DataGridViewRow row in dataGridViewPCs_KDS.Rows)
            {
                row.Visible = true;
            }
        }

        private void toolStripMenuItemManual_KDS_Click(object sender, EventArgs e)
        {
            string manualText = "РУКОВОДСТВО ПОЛЬЗОВАТЕЛЯ\n\n" +
        "1. ФАЙЛ: Используйте для открытия и сохранения CSV-таблиц.\n" +
        "2. РЕДАКТИРОВАТЬ: Добавление и удаление записей о ПК и поставщиках.\n" +
        "3. ПОИСК: Выберите поле, введите значение и нажмите иконку 'Поиск'.\n" +
        "4. СТАТИСТИКА: Выделите ячейки в таблице и нажмите нужную кнопку (Сумма, Мин/Макс и др.).\n" +
        "5. ГРАФИКИ: Переключайтесь между видами диаграмм на правой панели для анализа.\n\n" +
        "Подсказка: наведите на любую иконку для получения краткой справки.";

            MessageBox.Show(manualText, "Руководство пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}