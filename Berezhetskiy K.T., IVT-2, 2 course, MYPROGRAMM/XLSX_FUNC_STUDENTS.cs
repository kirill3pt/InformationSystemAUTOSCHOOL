using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public class XLSX_FUNC_STUDENTS
    {
        public string filePath = "Ученики.xlsx";
        private string[] headers_ = { "ID", "ФИО", "Телефон", "Группа", "Статус" };
        public void CREATE()
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Ученики");
                for (int i = 0; i < headers_.Length; i++)
                {
                    ws.Cell(1, i + 1).Value = headers_[i];
                    ws.Column(i + 1).Width = 20;
                }
                workbook.SaveAs(filePath);
            }
            LOGGER.LOG("Создан новый файл 'Ученики.xlsx'");
        }
        public void SAVE(string fio, string phone, string group)
        {
            if (!File.Exists(filePath))
            {
                CREATE();
            }
            using (var workbook = new XLWorkbook(filePath))
            {
                var ws = workbook.Worksheet(1);
                int lastRow = ws.LastRowUsed()?.RowNumber() + 1 ?? 2;
                string[] data = { fio, phone, group};
                ws.Cell(lastRow, 1).Value = lastRow - 1;
                ws.Cell(lastRow, 2).Value = fio;
                ws.Cell(lastRow, 3).Value = phone;
                ws.Cell(lastRow, 4).Value = group;
                ws.Cell(lastRow, 5).Value = "учится";
                workbook.Save();
            }
            LOGGER.LOG($"Добавлен ученик: {fio}, {phone}, {group}");
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
                        DataRow NEWROWS = TABLE.NewRow();
                        for (int i = 0; i < headers_.Length; i++)
                        {
                            NEWROWS[i] = row.Cell(i + 1).Value.ToString();
                        }
                        TABLE.Rows.Add(NEWROWS);
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
        public void MakeCOMBOBOX(ComboBox comboBox)
        {
            try
            {
                comboBox.Items.Clear();
                DataTable studentsTABLE = ReadSTUDENTS();

                foreach (DataRow row in studentsTABLE.Rows)
                {
                    string fio = row["ФИО"].ToString();
                    string fioINFO = $"{fio}";
                    comboBox.Items.Add(fioINFO);
                }

                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки ФИО: {ex.Message}");
            }
        }
        public DataTable ReadSTUDENTS()
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
                    {
                        newROWS[i] = row.Cell(i + 1).Value.ToString();
                    }
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
                $"Удалить записи ученика с ID: {string.Join(", ", ids)}?",
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

                foreach (var row in rows)
                {
                    int currentId = row.Cell(1).GetValue<int>();
                    if (ids.Contains(currentId))
                    {
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
                    LOGGER.LOG($"Удалены записи ученика с ID: {string.Join(", ", ids)}.");
                }
                else
                {
                    MessageBox.Show("Ни одна из выбранных записей не найдена!");
                    LOGGER.LOG($"Попытка удалить несуществующие записи ID: {string.Join(", ", ids)}.");
                }
            }
        }
    }
}