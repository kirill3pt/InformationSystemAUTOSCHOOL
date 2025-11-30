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
using static ClosedXML.Excel.XLPredefinedFormat;

namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public class XLSX_FUNC_STUDENTS
    {
        public string filePath = "Ученики.xlsx";
        string[] headers = { "ID", "ФИО", "Телефон", "Группа", "Статус", "Оплата" };
        public void CREATE()
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Ученики");
                for (int i = 0; i < headers.Length; i++)
                {
                    ws.Cell(1, i + 1).Value = headers[i];
                    ws.Column(i + 1).Width = 20;
                }
                workbook.SaveAs(filePath);
            }
            LOGGER.LOG("Создан новый файл 'Ученики.xlsx'");
        }
        private void ifFileExists() //консолидация дублирующихся условных фрагментов
        { 
            if (!File.Exists(filePath))
            {
                CREATE(); 
            }
        }
        public void SAVE(string fio, string phone, string group, string paid)
        {
            ifFileExists();
            using (var workbook = new XLWorkbook(filePath))
            {
                var ws = workbook.Worksheet(1);
                int lastRow = ws.LastRowUsed()?.RowNumber() + 1 ?? 2;
                string[] data = { fio, phone, group, paid };
                ws.Cell(lastRow, 1).Value = lastRow - 1;
                ws.Cell(lastRow, 2).Value = fio;
                ws.Cell(lastRow, 3).Value = phone;
                ws.Cell(lastRow, 4).Value = group;
                ws.Cell(lastRow, 5).Value = "учится";
                ws.Cell(lastRow, 6).Value = paid;
                workbook.Save();
            }
            LOGGER.LOG($"Добавлен ученик: {fio}, {phone}, {group}, {paid}");
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
                    for (int i = 0; i < headers.Length; i++)
                    {
                        TABLE.Columns.Add(headers[i]);
                    }
                    var ROWS = ws.RowsUsed().Skip(1);
                    foreach (var row in ROWS)
                    {
                        DataRow NEWROWS = TABLE.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            NEWROWS[i] = row.Cell(i + 1).Value.ToString();
                        }
                        TABLE.Rows.Add(NEWROWS);
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
        public void MakeCOMBOBOX(ComboBox comboBox) //удален управляющий флаг,
                                                    //управление вынесено в два метода: firstItemIfExists 
                                                    //и showErrorMessage
        {
            try
            {
                comboBox.Items.Clear();
                DataTable studentsTABLE = ReadSTUDENTS();
                foreach (DataRow row in studentsTABLE.Rows)
                {
                    string fio = row["ФИО"].ToString();
                    if (!string.IsNullOrEmpty(fio))
                    {
                        comboBox.Items.Add(fio);
                    }
                }

                firstItemIfExists(comboBox);
            }
            catch (Exception ex)
            {
                showErrorMessage(ex);
            }
        }
        private void firstItemIfExists(ComboBox comboBox)
        {
            if (comboBox.Items.Count == 0)
            {
                return;
            }
            comboBox.SelectedIndex = 0;
        }
        private void showErrorMessage(Exception ex)
        {
            MessageBox.Show($"Ошибка загрузки ФИО: {ex.Message}");
        }
        public DataTable ReadSTUDENTS()
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
        private bool confirmDelete(int id) //декомпозиция условного оператора
        {
            DialogResult confirm = MessageBox.Show(
            $"Удалить ученика с ID {id}?",
            "Подтверждение удаления",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );
            if (confirm != DialogResult.Yes)
            {
                LOGGER.LOG($"Удаление ученика с ID {id} отменено пользователем.");
                return false;
            }
            return true;
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
                if (!confirmDelete(id)) //декомпозиция условного оператора
                {
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
                        MessageBox.Show("Ученик успешно удалён!");
                        LOGGER.LOG($"Ученик с ID {id} удалён из базы.");
                    }
                    if (!found) //консолидация условного выражения
                    {
                        MessageBox.Show("Ученик с таким ID не найден!");
                        LOGGER.LOG($"Попытка удалить несуществующего ученика ID {id}.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
                LOGGER.LOG($"Ошибка при удалении ученика ID {id}: {ex.Message}");
            }
        }
    }
}