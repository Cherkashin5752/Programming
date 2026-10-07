using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ObjectOrientedPractics.Services
{
    internal class PathService
    {
        /// <summary>
        /// Возвращает путь дериктории до исполняемого файла
        /// </summary>
        /// <returns>Строка, содержащая абсолютный путь к папке с исполняемым файлом (без имени самого файла).</returns>
        static public string GetProjectRootDir()
        {
            string tempPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            string path = "";

            for (int i = 0; i < tempPath.LastIndexOf("\\"); i++)
            {
                path += tempPath[i];
            }

            return path;
        }
    }
}
