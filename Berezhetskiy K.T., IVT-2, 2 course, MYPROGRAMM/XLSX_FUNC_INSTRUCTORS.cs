using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public class XLSX_FUNC_INSTRUCTORS
    {
        public string filePath = "Инструкторы.xlsx";
        string[] headers = { "ID", "ФИО", "Телефон" };
        public void CREATE()
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Инструкторы");
                for (int i = 0; i < headers.Length; i++)
                {
                    ws.Cell(1, i + 1).Value = headers[i];
                    ws.Column(i + 1).Width = 20;
                }
                workbook.SaveAs(filePath);
            }
            LOGGER.LOG("Создан новый файл 'Инструкторы.xlsx'");
        }
        public void SAVE(string fio, string number)
        {
            if (!File.Exists(filePath))
            {
                CREATE();
            }
            using (var workbook = new XLWorkbook(filePath))
            {
                var ws = workbook.Worksheet(1);
                int lastRow = ws.LastRowUsed()?.RowNumber() + 1 ?? 2;
                ws.Cell(lastRow, 1).Value = lastRow - 1;
                ws.Cell(lastRow, 2).Value = fio;
                ws.Cell(lastRow, 3).Value = number;
                workbook.Save();
            }
            LOGGER.LOG($"Добавлен инструктор: {fio}, {number}");
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
                    var worksheet = workbook.Worksheet(1);
                    for (int i = 0; i < headers.Length; i++)
                    {
                        TABLE.Columns.Add(headers[i]);
                    }
                    var ROWS = worksheet.RowsUsed().Skip(1);
                    foreach (var row in ROWS)
                    {
                        DataRow newROWS = TABLE.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            newROWS[i] = row.Cell(i + 1).Value.ToString();
                        }
                        TABLE.Rows.Add(newROWS);
                    }
                    MessageBox.Show("Таблица загружена!");
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
                DataTable studentsTABLE = ReadINSTRUCTORS();

                foreach (DataRow row in studentsTABLE.Rows)
                {
                    string fio = row["ФИО"].ToString();
                    string number = row["Телефон"].ToString();
                    string INFO = $"{fio}, {number}";
                    comboBox.Items.Add(INFO);
                }

                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки ФИО и телефона: {ex.Message}");
            }
        }
        public DataTable ReadINSTRUCTORS()
        {
            DataTable TABLE = new DataTable();
            foreach (var header in headers)
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
                    for (int i = 0; i < headers.Length; i++)
                        newROWS[i] = row.Cell(i + 1).Value.ToString();
                    TABLE.Rows.Add(newROWS);
                }
            }
            return TABLE;
        }
        public void DELETE(int id)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Файл не найден!");
                    return;
                }
                DialogResult confirm = MessageBox.Show(
                    $"Удалить инструктора с ID {id}?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm != DialogResult.Yes)
                {
                    LOGGER.LOG($"Удаление инструктора с ID {id} отменено пользователем.");
                    return;
                }

                using (var workbook = new XLWorkbook(filePath))
                {
                    var ws = workbook.Worksheet(1);
                    var rows = ws.RowsUsed().Skip(1).ToList();
                    bool found = false;

                    foreach (var row in rows)
                    {
                        int currentId = row.Cell(1).GetValue<int>();
                        if (currentId == id)
                        {
                            row.Delete();
                            found = true;
                            break;
                        }
                    }

                    if (found)
                    {
                        int newId = 1;
                        foreach (var row in ws.RowsUsed().Skip(1))
                        {
                            row.Cell(1).Value = newId++;
                        }

                        workbook.Save();
                        MessageBox.Show("Инструктор успешно удалён!");
                        LOGGER.LOG($"Инструктор с ID {id} удалён из базы.");
                    }
                    else
                    {
                        MessageBox.Show("Инструктор с таким ID не найден!");
                        LOGGER.LOG($"Попытка удалить несуществующего инструктора ID {id}.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
                LOGGER.LOG($"Ошибка при удалении инструктора ID {id}: {ex.Message}");
            }
        }
    }
}