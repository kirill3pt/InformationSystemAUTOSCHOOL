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
    public class deleteOPTIONS // класс для метода удаления
    {
        public int id { get; set; }
        public string reason { get; set; } = "удалено пользователем";
        public bool confirm { get; set; }

    }
    public class XLSX_FUNC_CARS
    {
        public string filePath = "Автомобили.xlsx";
        string[] headers = { "ID", "Марка", "Модель", "Гос. номер", "Год выпуска" };
        private void initHEADERS(IXLWorksheet ws) //вынесен метод создания заголовков в отдельную функцию вместо исп.
                                                  //цикла в методе CREATE
        {
            for (int i = 0; i < headers.Length; i++)
            {
                ws.Cell(1, i + 1).Value = headers[i];
                ws.Column(i + 1).Width = 20;
            }
        }
        public void CREATE()
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Автомобили");
                initHEADERS(ws);
                workbook.SaveAs(filePath);
            }
            LOGGER.LOG("Создан новый файл 'Автомобили.xlsx'");
        }
        public void SAVE(string marka, string model, string number, string year)
        {
            if (!File.Exists(filePath))
            {
                CREATE();
            }
            using (var workbook = new XLWorkbook(filePath))
            {
                var ws = workbook.Worksheet(1);
                int lastRow = ws.LastRowUsed()?.RowNumber() + 1 ?? 2;
                //убрана неиспользуемая переменная на этом месте
                ws.Cell(lastRow, 1).Value = lastRow - 1;
                ws.Cell(lastRow, 2).Value = marka;
                ws.Cell(lastRow, 3).Value = model;
                ws.Cell(lastRow, 4).Value = number;
                ws.Cell(lastRow, 5).Value = year;
                //удалён параметр "статус" в листах, форме добавления машин
                workbook.Save();
            }
            LOGGER.LOG($"Добавлен автомобиль: {marka}, {model}, {number}, {year}");
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
        public void MakeCOMBOBOX(ComboBox carBOX)
        {
            try
            {
                carBOX.Items.Clear();
                DataTable carsTABLE = new DataTable(); //встроен метов DataTable, для загрузки 
                //данных о машинах в combobox для создания занятий, ранее был вынесен в отдельный метод
                foreach (var header in headers)
                {
                    carsTABLE.Columns.Add(header);
                }
                using (var workbook = new XLWorkbook(filePath))
                {
                    var ws = workbook.Worksheet(1);
                    var rows = ws.RowsUsed().Skip(1);
                    foreach (var row in rows)
                    {
                        DataRow newROWS = carsTABLE.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                            newROWS[i] = row.Cell(i + 1).Value.ToString();
                        carsTABLE.Rows.Add(newROWS);
                    }
                }

                foreach (DataRow row in carsTABLE.Rows)
                {
                    string marka = row["Марка"].ToString();
                    string model = row["Модель"].ToString();
                    string number = row["Гос. номер"].ToString();
                    string status = row["Статус"].ToString();
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
        public void DELETE(deleteOPTIONS options) //заменен параметр с id на список из параметров - options
                //куда входит причина удаления, id, логическая переменная
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Файл не найден!");
                    return;
                }
                DialogResult confirm = MessageBox.Show(
                    $"Удалить автомобиль с ID {options.id}?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (options.confirm)
                {
                    DialogResult confirms = MessageBox.Show(
                        $"Удалить автомобиль с ID {options.id}?",
                        "Подтверждение удаления",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirm != DialogResult.Yes)
                    {
                        LOGGER.LOG($"Удаление автомобиля с ID {options.id} отменено пользователем.");
                        return;
                    }
                }

                using (var workbook = new XLWorkbook(filePath))
                {
                    var ws = workbook.Worksheet(1);
                    var rows = ws.RowsUsed().Skip(1).ToList();
                    bool found = false;

                    foreach (var row in rows)
                    {
                        int currentId = row.Cell(1).GetValue<int>();
                        if (currentId == options.id)
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
                        MessageBox.Show("Автомобиль успешно удалён!");
                        LOGGER.LOG($"Автомобиль с ID {options.id}, причина: {options.reason} - удалён.");
                    }
                    else
                    {
                        MessageBox.Show("Автомобиль с таким ID не найден!");
                        LOGGER.LOG($"Попытка удалить несуществующего автомобиля ID {options.id}.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
                LOGGER.LOG($"Ошибка при удалении автомобиля ID {options.id}: {ex.Message}");
            }
        }
    }
}
