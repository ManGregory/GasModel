using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GasModelWin.Helper
{
    public static class ExportHelper
    {
        private static float[] GetColumnWidths(DataGridView dgv, float totalWidth)
        {
            return (from DataGridViewColumn column in dgv.Columns
                    select (column.Width * totalWidth) / dgv.Columns.GetColumnsWidth(DataGridViewElementStates.Visible))
                .ToArray();
        }

        public static void SavePdf(DataGridView dgvResults, string fileName)
        {
            PdfPTable pdfTable = new PdfPTable(dgvResults.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            BaseFont baseFont = BaseFont.CreateFont(@"arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            var font = new Font(baseFont) {Size = 9};
            //Adding Header row
            foreach (DataGridViewColumn column in dgvResults.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font))
                {
                    BackgroundColor = new BaseColor(240, 240, 240)
                };
                pdfTable.AddCell(cell);
            }
            var cellFont = new Font(baseFont);
            cellFont.Size = 8;
            //Adding DataRow
            foreach (DataGridViewRow row in dgvResults.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new PdfPCell(new Phrase(cell.Value.ToString(), cellFont)));
                }
            }
            pdfTable.SetWidths(GetColumnWidths(dgvResults, 210));

            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                pdfDoc.SetPageSize(PageSize.A4.Rotate());
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }

        public static void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }  
    }
}
