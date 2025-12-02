using System;
using ClosedXML.Excel;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;


namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public class XLSX_FUNC_CARS
    {
        public string filePath = "Автомобили.xlsx";
        private string[] headers_ = { "ID", "Марка", "Модель", "Гос. номер", "Год выпуска" };
        public void CREATE()
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Автомобили");
                for (int i = 0; i < headers_.Length; i++)
                {
                    ws.Cell(1, i + 1).Value = headers_[i];
                    ws.Column(i + 1).Width = 20;
                }
                workbook.SaveAs(filePath);
            }
            LOGGER.LOG("Создан новый файл 'Автомобили.xlsx'");
        }
        public void SAVE(string marka, string model, string number, string year )
        {
            if (!File.Exists(filePath))
            {
                CREATE();
            }
            using (var workbook = new XLWorkbook(filePath))
            {
                var ws = workbook.Worksheet(1);
                int lastRow = ws.LastRowUsed()?.RowNumber() + 1 ?? 2;
                string[] data = { marka, model, number, year };
                ws.Cell(lastRow, 1).Value = lastRow - 1;
                ws.Cell(lastRow, 2).Value = marka;
                ws.Cell(lastRow, 3).Value = model;
                ws.Cell(lastRow, 4).Value = number;
                ws.Cell(lastRow, 5).Value = year;
                workbook.Save();
            }
            LOGGER.LOG($"Добавлен автомобиль: {marka}, {model}, {number}, {year} ");
        }
        public DataTable SHOW()
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл не найден! Для создания нажмите \"Добавить\" внизу");
                return new DataTable();
            }
            using (var workbook = new XLWorkbook(filePath))
            {
                try
                {
                    DataTable TABLE = new DataTable();
                    var ws = workbook.Worksheet(1);
                    for (int i = 0; i < headers_.Length; i++)
                    {
                        TABLE.Columns.Add(headers_[i]);
                    }
                    var ROWS = ws.RowsUsed().Skip(1);
                    foreach (var row in ROWS)
                    {
                        DataRow newROWS = TABLE.NewRow();
                        for (int i = 0; i < headers_.Length; i++)
                        {
                            newROWS[i] = row.Cell(i + 1).Value.ToString();
                        }
                        TABLE.Rows.Add(newROWS);
                    }
                    return TABLE;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                    return new DataTable();
                }
            }
        }
        public void MakeCOMBOBOX(ComboBox carBOX)
        {
            try
            {
                carBOX.Items.Clear();
                DataTable carsTABLE = ReadCARS();

                foreach (DataRow row in carsTABLE.Rows)
                {
                    string marka = row["Марка"].ToString();
                    string model = row["Модель"].ToString();
                    string number = row["Гос. номер"].ToString();
                    string carINFO = $"{marka} {model}, {number}";
                    carBOX.Items.Add(carINFO);
                }
                if (carBOX.Items.Count > 0)
                {
                    carBOX.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки автомобилей: {ex.Message}");
            }
        }
        public DataTable ReadCARS()
        {
            DataTable TABLE = new DataTable();
            foreach (var header in headers_)
            {
                TABLE.Columns.Add(header);
            }
            using (var workbook = new XLWorkbook(filePath))
            {
                var ws = workbook.Worksheet(1);
                var rows = ws.RowsUsed().Skip(1);
                foreach (var row in rows)
                {
                    DataRow newROWS = TABLE.NewRow();
                    for (int i = 0; i < headers_.Length; i++)
                        newROWS[i] = row.Cell(i + 1).Value.ToString();
                    TABLE.Rows.Add(newROWS);
                }
            }
            return TABLE;
        }
        public void DELETE(List<int> ids)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл не найден!");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Удалить записи автомобиля с ID: {string.Join(", ", ids)}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
            {
                LOGGER.LOG($"Удаление отменено пользователем.");
                return;
            }

            using (var workbook = new XLWorkbook(filePath))
            {
                var ws = workbook.Worksheet(1);
                var rows = ws.RowsUsed().Skip(1).ToList();
                bool anyDeleted = false;
                List<string> deletedCarsInfo = new List<string>();

                foreach (var row in rows)
                {
                    int currentId = row.Cell(1).GetValue<int>();
                    if (ids.Contains(currentId))
                    {
                        string marka = row.Cell(2).GetValue<string>();
                        string model = row.Cell(3).GetValue<string>();
                        string number = row.Cell(4).GetValue<string>();

                        deletedCarsInfo.Add($"{marka} {model}, гос. номер: {number}");

                        row.Delete();
                        anyDeleted = true;
                    }
                }

                if (anyDeleted)
                {
                    int newId = 1;
                    foreach (var row in ws.RowsUsed().Skip(1))
                    {
                        row.Cell(1).Value = newId++;
                    }
                    workbook.Save();
                    MessageBox.Show("Записи успешно удалены!");
                    string logMessage = $"Удалены автомобили:\n" + string.Join("\n", deletedCarsInfo);
                    LOGGER.LOG(logMessage);
                }
                else
                {
                    MessageBox.Show("Ни одна из выбранных записей не найдена!");
                    LOGGER.LOG($"Попытка удалить несуществующие записи машин ID: {string.Join(", ", ids)}.");
                }
            }
        }
    }
}
