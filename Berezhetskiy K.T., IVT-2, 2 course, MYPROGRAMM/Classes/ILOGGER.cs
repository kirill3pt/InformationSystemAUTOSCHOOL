using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    internal interface ILOGGER
    {
        void SETLOGFOLDER(string folderPath);
        void LOG(string message);
    }
}
