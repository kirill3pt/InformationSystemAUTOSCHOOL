using System;
using System.IO;
using System.Windows.Forms;

namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    public static class LOGGER
    {
        public static string logFILEPATH_ { get; private set; } = "Logs/log.txt";
        static LOGGER()
        {
            var savedFolder = Properties.Settings.Default.LogFolderPath;
            if (!string.IsNullOrEmpty(savedFolder))
                logFILEPATH_ = Path.Combine(savedFolder, "log.txt");
            else
                logFILEPATH_ = Path.Combine("Logs", "log.txt");
        }
        public static void SETLOGFOLDER(string folderPath)
        {
            logFILEPATH_ = Path.Combine(folderPath, "log.txt");
        }

        public static void LOG(string message)
        {
            try
            {
                string directory = Path.GetDirectoryName(logFILEPATH_);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                File.AppendAllText(logFILEPATH_, $"[{DateTime.Now}]: {message}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка записи лога: {ex.Message}");
            }
        }
    }
}
