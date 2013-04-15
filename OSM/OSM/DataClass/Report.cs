using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSM.DataClass
{
    class Report
    {
        public static string Report_ID_forTeacher;//教师正在操作的实验报告ID
        public static string Report_ID_forStudent;//学生正在操作的实验报告ID
        public static bool IfimageSaved = false;//学生正在编辑的实验报告是否存储了图片的标志
        public static string Report_Path;//保存最近的实验报告word生成路径
    }
}
