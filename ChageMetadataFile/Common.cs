using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace ChageMetadataFile
{
    public class Common
    {

        /// <summary>
        /// Modifica la fecha de creación y modificación de un archivo
        /// </summary>
        /// <param name="pfile">Ruta completa del archivo</param>
        /// <param name="pCreateDate">Nueva fecha de creación del archivo</param>
        /// <param name="pCreateTime">Nueva hora de creación del archivo</param>
        /// <param name="pModifiDate">Nueva fecha de modificación del archivo</param>
        /// <param name="pModifiTime">Nueva hora de modificación del archivo</param>
        public static void ChangeDateFile(string pfile , DateTime pCreateDate, DateTime pCreateTime, DateTime pModifiDate, DateTime pModifiTime)
        {
            try
            {
                Int32 year = pCreateDate.Year;
                Int32 month = pCreateDate.Month;
                Int32 day = pCreateDate.Day;
                Int32 hour = pCreateTime.Hour;
                Int32 minute = pCreateTime.Minute;
                Int32 second = pCreateTime.Second;

                Int32 myear = pModifiDate.Year;
                Int32 mmonth = pModifiDate.Month;
                Int32 mday = pModifiDate.Day;
                Int32 mhour = pModifiTime.Hour;
                Int32 mminute = pModifiTime.Minute;
                Int32 msecond = pModifiTime.Second;


                DateTime dateCreate = new DateTime(year, month, day, hour, minute, second);
                DateTime dateModified = new DateTime(myear, mmonth, mday, mhour, mminute, msecond);

                File.SetCreationTime(pfile, dateCreate);
                File.SetLastWriteTime(pfile, dateModified);

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
            
        }


        public static void ChangeDateDirectory(string pfile, DateTime pCreateDate, DateTime pCreateTime, DateTime pModifiDate, DateTime pModifiTime)
        {
            Int32 year = pCreateDate.Year;
            Int32 month = pCreateDate.Month;
            Int32 day = pCreateDate.Day;
            Int32 hour = pCreateTime.Hour;
            Int32 minute = pCreateTime.Minute;
            Int32 second = pCreateTime.Second;

            Int32 myear = pModifiDate.Year;
            Int32 mmonth = pModifiDate.Month;
            Int32 mday = pModifiDate.Day;
            Int32 mhour = pModifiTime.Hour;
            Int32 mminute = pModifiTime.Minute;
            Int32 msecond = pModifiTime.Second;


            DateTime dateCreate = new DateTime(year, month, day, hour, minute, second);
            DateTime dateModified = new DateTime(myear, mmonth, mday, mhour, mminute, msecond);

            Directory.SetCreationTime(pfile, dateCreate);
            Directory.SetLastWriteTime(pfile, dateModified);


        }

        public static List<string> GetDirectories(string pDirectory)
        {
            List<string> dirs = new List<string>();
            foreach (string dir in Directory.GetDirectories(pDirectory))
            {
                dirs.Add(dir);
                findSubDirectory(dir, dirs);
            }
            return dirs;
        }

        private static void findSubDirectory(string pDirectory,  List<string> pdirs)
        {
            foreach (string directory in Directory.GetDirectories(pDirectory))
            {
                pdirs.Add(directory);
                findSubDirectory(directory, pdirs);     
            }
        }
    }
}
