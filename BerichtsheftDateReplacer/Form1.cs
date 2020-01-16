using DocumentFormat.OpenXml.Packaging;
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

namespace BerichtsheftDateReplacer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.DefaultExt = "docx";
            openFileDialog1.Filter = "Word documents (*.docx)|*.docx";
        }

        void GenerateBerichtshefte(string path, DateTime ausbildungsbeginn, DateTime ausbildungsende, int wochenrhythmus)
        {
            ausbildungsbeginn = StartOfWeek(ausbildungsbeginn, DayOfWeek.Monday);

            List<string> newPaths = new List<string>();
            DateTime tempTime = ausbildungsbeginn;
            int i = 0;
            while(tempTime < ausbildungsende)
            {
                i++;
                tempTime = tempTime.AddDays(7 * wochenrhythmus);

                string tempPath = path.Remove(path.Length - 5) + i + ".docx";
                if (File.Exists(tempPath))
                {
                    tempPath = "";
                }
                else
                {
                    File.Copy(path, tempPath);
                }
                newPaths.Add(tempPath);
            }
            tempTime = ausbildungsbeginn;

            i = 0;
            foreach (string newPath in newPaths)
            {
                i++;
                DateTime berichtsheftBeginn = tempTime;
                tempTime = tempTime.AddDays(7 * wochenrhythmus);
                DateTime berichtsheftEnde = tempTime.AddDays(-1);
                DateTime berichtsheftSchreib = tempTime;

                if (string.IsNullOrEmpty(newPath))
                    continue;

                using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(newPath, true))
                {
                    string documentText;
                    using (StreamReader reader = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                    {
                        documentText = reader.ReadToEnd();
                    }
                    documentText = documentText.Replace("##FROMDATE##", berichtsheftBeginn.ToString("dd.MM.yyyy"));
                    documentText = documentText.Replace("##TODATE##", berichtsheftEnde.ToString("dd.MM.yyyy"));
                    documentText = documentText.Replace("##WRITEDATE##", berichtsheftSchreib.ToString("dd.MM.yyyy"));
                    documentText = documentText.Replace("##NUM##", i.ToString());

                    using (StreamWriter writer = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
                    {
                        writer.Write(documentText);
                    }
                }
            }
        }

        private void btn_selectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFileLabel.Text = openFileDialog1.FileName;
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            GenerateBerichtshefte(openFileDialog1.FileName, dateTime_StartOfAusbildung.Value, dateTime_EndOfAusbildung.Value, (int)numeric_Wochenrhythmus.Value);
        }

        public static DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
