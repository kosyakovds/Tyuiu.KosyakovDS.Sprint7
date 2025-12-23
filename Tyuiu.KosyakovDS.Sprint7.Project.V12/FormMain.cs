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

        private void buttonStatistics_KDS_Click(object sender, EventArgs e)
        {
            List<PersonalComputer> pcs = new List<PersonalComputer>();
            List<Supplier> suppliers = new List<Supplier>();

            foreach (DataGridViewRow row in dataGridViewPCs_KDS.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value != null)
                {
                    pcs.Add(new PersonalComputer { Manufacturer = row.Cells[0].Value.ToString() });
                }
            }

            foreach (DataGridViewRow row in dataGridViewSuppliers_KDS.Rows)
            {
                if (!row.IsNewRow)
                {
                    suppliers.Add(new Supplier());
                }
            }

            string stats = ds.GetStatistics(pcs, suppliers);

            FormStats formStats = new FormStats(stats);
            formStats.ShowDialog();
        }

        private void buttonStatsSum_Click(object sender, EventArgs e)
        {
            dataGridViewPCs_KDS.EndEdit();

            if (dataGridViewPCs_KDS.CurrentCell != null)
            {
                int targetColIndex = dataGridViewPCs_KDS.CurrentCell.ColumnIndex;
                string columnName = dataGridViewPCs_KDS.Columns[targetColIndex].HeaderText;

                double sum = 0;
                string rowsText = "";

                foreach (DataGridViewCell cell in dataGridViewPCs_KDS.SelectedCells)
                {
                    if (cell.ColumnIndex == targetColIndex)
                    {
                        if (cell.RowIndex != -1 && cell.RowIndex < pcList_KDS.Count)
                        {
                            string valueToParse = "";

                            if (columnName == "ОЗУ") valueToParse = pcList_KDS[cell.RowIndex].RAM;
                            else if (columnName == "Жёсткий диск") valueToParse = pcList_KDS[cell.RowIndex].HDD;

                            if (double.TryParse(valueToParse.Replace(".", ","), out double val))
                            {
                                sum += val;
                            }

                            if (rowsText != "") rowsText += ", ";
                            rowsText += (cell.RowIndex + 1).ToString();
                        }
                    }
                }

                labelStatsResult_KDS.Text = $"Итого: Сумма по столбцу [{columnName}] и строкам [{rowsText}]: {sum}";
            }
        }
    }
}