using System;
using ClosedXML.Excel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public class XLSX_FUNC_LESSONS
    {
        public string filePath = "Занятия.xlsx";
        private readonly string[] headers_ = { "ID", "Дата", "Время", "Ученик (Ф.И.О)", "Инструктор (Ф.И.О)", "Автомобиль (Марка, модель, гос. номер", "Статус" };
        public void CREATE()
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Занятия");
                for (int i = 0; i < headers_.Length; i++)
                {
                    ws.Cell(1, i + 1).Value = headers_[i];
                    ws.Column(i + 1).Width = 20;
                }
                workbook.SaveAs(filePath);
            }
            LOGGER.LOG("Создан новый файл 'Занятия.xlsx'");
        }
        public void SAVE(string date, string time, string fio, string instructor, string car, string status = "запланировано")
        {
            if (!File.Exists(filePath))
            {
                CREATE();
            }
            using (var workbook = new XLWorkbook(filePath))
            {
                var ws = workbook.Worksheet(1);
                int lastRow = ws.LastRowUsed()?.RowNumber() + 1 ?? 2;
                string[] data = { date, time, fio, car };
                ws.Cell(lastRow, 1).Value = lastRow - 1;
                ws.Cell(lastRow, 2).Value = date;
                ws.Cell(lastRow, 3).Value = time;
                ws.Cell(lastRow, 4).Value = fio;
                ws.Cell(lastRow, 5).Value = instructor;
                ws.Cell(lastRow, 6).Value = car;
                ws.Cell(lastRow, 7).Value = status;
                workbook.Save();
            }
            LOGGER.LOG($"Добавлено занятие: {date} {time}, ученик: {fio}, авто: {car}, статус: {status} ");
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
                    for (int i = 0; i < headers_.Length; i++)
                    {
                        TABLE.Columns.Add(headers_[i]);
                    }
                    var ROWS = worksheet.RowsUsed().Skip(1);
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
        public void statusLESSON(int id, string status)
        {
            using (var workbook = new XLWorkbook(filePath))
            {
                var ws = workbook.Worksheet(1);
                var rows = ws.RowsUsed().Skip(1);

                foreach (var row in rows)
                {
                    if (row.Cell(1).GetValue<int>() == id)
                    {
                        var idCell = row.Cell(1);

                        if (status == "запланировано")
                        {
                            idCell.Style.Fill.BackgroundColor = XLColor.Yellow;
                        }
                        else if (status == "отменено")
                        {
                            idCell.Style.Fill.BackgroundColor = XLColor.Red;
                        }
                        else if (status == "проведено")
                        {
                            idCell.Style.Fill.BackgroundColor = XLColor.Green;
                        }
                        int statusCol = ws.LastColumnUsed().ColumnNumber();
                        row.Cell(statusCol).Value = status;
                        LOGGER.LOG($"Изменён статус занятия ID={id} → {status}");
                        break;
                    }
                }
                workbook.Save();
            }
        }
        public void DELETE(List<int> ids)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл не найден!");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Удалить записи занятия с ID: {string.Join(", ", ids)}?",
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
                    LOGGER.LOG($"Удалены записи занятия с ID: {string.Join(", ", ids)}.");
                }
                else
                {
                    MessageBox.Show("Ни одна из выбранных записей не найдена!");
                    LOGGER.LOG($"Попытка удалить несуществующие записи занятий ID: {string.Join(", ", ids)}.");
                }
            }
        }
    }
}
