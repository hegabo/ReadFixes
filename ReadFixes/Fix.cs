using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ReadFixes
{
    class Fix
    {
        // Fields
        private string _strFileName;
        private DateTime _dtmFixTime;
        private string _strDynObject;
        private Double _dblSDEasting;
        private Double _dblSDNorthing;
        private Double _dblSDHeight;
        private Double _dblErrorEasting;
        private Double _dblErrorNorthing;
        private Double _dblErrorHeight;
        private Double _dblAvgEasting;
        private Double _dblEAvgrNorthing;
        private Double _dblAvgHeight;
        private Double _dblMedEasting;
        private Double _dblMedNorthing;
        private Double _dblMedHeight;
        private int _intCount;
        private int _intCountFiltered;
        private Sample[] _samples;

        // Properties
        public string FileName { get => _strFileName; set => _strFileName = value; }
        public DateTime FixTime { get => _dtmFixTime; set => _dtmFixTime = value; }
        public string DynObject { get => _strDynObject; set => _strDynObject = value; }
        public Double DblSDEasting { get => _dblSDEasting; set => _dblSDEasting = value; }
        public Double DblSDNorthing { get => _dblSDNorthing; set => _dblSDNorthing = value; }
        public Double DblSDHeight { get => _dblSDHeight; set => _dblSDHeight = value; }
        public Double DblErrorEasting { get => _dblErrorEasting; set => _dblErrorEasting = value; }
        public Double DblErrorNorthing { get => _dblErrorNorthing; set => _dblErrorNorthing = value; }
        public Double DblErrorHeight { get => _dblErrorHeight; set => _dblErrorHeight = value; }
        public Double DblAvgEasting { get => _dblAvgEasting; set => _dblAvgEasting = value; }
        public Double DblEAvgrNorthing { get => _dblEAvgrNorthing; set => _dblEAvgrNorthing = value; }
        public Double DblAvgHeight { get => _dblAvgHeight; set => _dblAvgHeight = value; }
        public Double DblMedEasting { get => _dblMedEasting; set => _dblMedEasting = value; }
        public Double DblMedNorthing { get => _dblMedNorthing; set => _dblMedNorthing = value; }
        public Double DblMedHeight { get => _dblMedHeight; set => _dblMedHeight = value; }
        public int IntCount { get => _intCount; set => _intCount = value; }
        public int IntCountFiltered { get => _intCountFiltered; set => _intCountFiltered = value; }
        public Sample[] Samples { get => _samples; set => _samples = value; }

        public Fix(string fileName)
        {
            this.FileName = fileName;
            Helper.PopulateFix(this);
        }

        
    }


    public struct Sample
    {
        public Double dblEasting;
        public Double dblNorthing;
        public Double dblHeight;
        public bool bolRejected;
    }


    // Helper Class
    class Helper
    {
        // Static method to populate the fix
        public static void PopulateFix(Fix fix)
        {
            try
            {
                using (StreamReader fixReader = new StreamReader(fix.FileName))
                {
                    // First Line
                    string strLine = fixReader.ReadLine();
                    fix.FixTime = DateTime.ParseExact(strLine.Substring(29, 19), "dd.MM.yyyy HH:mm:ss", new CultureInfo("en-GB"));
                    fix.DynObject = strLine.Substring(75);

                    // Skip 3 lines
                    SkipLines(fixReader, 3);

                    // Read Counts and Easting statistics
                    string[] arrLine = fixReader.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    fix.IntCount = int.Parse(arrLine[9]);
                    fix.IntCountFiltered = int.Parse(arrLine[7]);
                    fix.DblSDEasting = Double.Parse(arrLine[5]);
                    fix.DblErrorEasting = Double.Parse(arrLine[6]);

                    // Read Northing statistics
                    arrLine = fixReader.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    fix.DblSDNorthing = Double.Parse(arrLine[5]);
                    fix.DblErrorNorthing = Double.Parse(arrLine[6]);

                    // Read Height statistics
                    arrLine = fixReader.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    fix.DblSDHeight = Double.Parse(arrLine[5]);
                    fix.DblErrorHeight = Double.Parse(arrLine[6]);

                    // Skip 3 lines
                    SkipLines(fixReader, 3);

                    // Read Result
                    arrLine = fixReader.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    fix.DblAvgEasting = Double.Parse(arrLine[1]);
                    fix.DblMedEasting = Double.Parse(arrLine[2]);
                    arrLine = fixReader.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    fix.DblEAvgrNorthing = Double.Parse(arrLine[1]);
                    fix.DblMedNorthing = Double.Parse(arrLine[2]);
                    arrLine = fixReader.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    fix.DblAvgHeight = Double.Parse(arrLine[1]);
                    fix.DblMedHeight = Double.Parse(arrLine[2]);

                    // Skip 14 lines
                    SkipLines(fixReader, 14);

                    // Fill-in the samples
                    fix.Samples = new Sample[fix.IntCount];
                    for (int i = 0; i < fix.IntCount; i++)
                    {
                        arrLine = fixReader.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        fix.Samples[i].dblEasting = Double.Parse(arrLine[0]);
                        fix.Samples[i].dblNorthing = Double.Parse(arrLine[1]);
                        fix.Samples[i].dblHeight = Double.Parse(arrLine[2]);
                        fix.Samples[i].bolRejected = (arrLine.Length == 4);
                    }
                    fixReader.Close();
                }
            }

            catch
            {

            }

            finally
            {

            }

        }

        public static void SkipLines(StreamReader reader, int iLines)
        {
            for (int i = 0; i < iLines; i++)
            {
                reader.ReadLine();
            }
        }


        
    }


    
}
