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
        private readonly string[] headers = { "ID", "Дата", "Время", "Ученик (Ф.И.О)", "Инструктор (Ф.И.О)", "Автомобиль (Марка, модель, гос. номер", "Статус" };
        public void CREATE()
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Занятия");
                for (int i = 0; i < headers.Length; i++)
                {
                    ws.Cell(1, i + 1).Value = headers[i];
                    ws.Column(i + 1).Width = 20;
                }
                workbook.SaveAs(filePath);
            }
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
                string[] data = { date, time, fio, car};
                ws.Cell(lastRow, 1).Value = lastRow - 1;
                ws.Cell(lastRow, 2).Value = date;
                ws.Cell(lastRow, 3).Value = time;
                ws.Cell(lastRow, 4).Value = fio;
                ws.Cell(lastRow, 5).Value = instructor;
                ws.Cell(lastRow, 6).Value = car;
                ws.Cell(lastRow, 7).Value = status;
                workbook.Save();
            }
        }
        public DataTable SHOW()
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл не найден!");
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
                        break;
                    }
                }
                workbook.Save();
            }
        }
    }
}
