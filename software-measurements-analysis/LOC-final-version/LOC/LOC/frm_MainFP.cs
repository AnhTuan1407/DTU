using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LOC
{
    public partial class frm_MainFP : Form
    {
        public frm_MainFP()
        {
            InitializeComponent();
        }

        private void frm_MainFP_Load(object sender, EventArgs e)
        {

        }
        private void txt_EIs_Simple_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép các ký tự số và các phím điều hướng (ví dụ: Backspace, Delete) 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_EIs_Simple_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "^[0-9]*$"))
            {
                textBox.Text = string.Empty;
            }
        }

        private void btn_deleteAll_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                MessageBox.Show("Successful Delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_EIs_Simple.Clear();
                txt_EIs_Average.Clear();
                txt_EIs_Complex.Clear();
                txt_OIs_Simple.Clear();
                txt_OIs_Average.Clear();
                txt_OIs_Complex.Clear();
                txt_EQs_Simple.Clear();
                txt_EQs_Average.Clear();
                txt_EQs_Complex.Clear();
                txt_EIFs_Simple.Clear();
                txt_EIFs_Average.Clear();
                txt_EIFs_Complex.Clear();
                txt_ILFs_Simple.Clear();
                txt_ILFs_Average.Clear();
                txt_ILFs_Complex.Clear();
                lb_Result.Text = "";
            }
        }
        private int GetTextBoxValueOrDefault(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return 0;
            }
            else
            {
                return int.Parse(textBox.Text);
            }
        }
        private void btn_FP_Click(object sender, EventArgs e)
        {
            int eisSimple = GetTextBoxValueOrDefault(txt_EIs_Simple);
            int eisAverage = GetTextBoxValueOrDefault(txt_EIs_Average);
            int eisComplex = GetTextBoxValueOrDefault(txt_EIs_Complex);
            int oisSimple = GetTextBoxValueOrDefault(txt_OIs_Simple);
            int oisAverage = GetTextBoxValueOrDefault(txt_OIs_Average);
            int oisComplex = GetTextBoxValueOrDefault(txt_OIs_Complex);
            int eqsSimple = GetTextBoxValueOrDefault(txt_EQs_Simple);
            int eqsAverage = GetTextBoxValueOrDefault(txt_EQs_Average);
            int eqsComplex = GetTextBoxValueOrDefault(txt_EQs_Complex);
            int eifsSimple = GetTextBoxValueOrDefault(txt_EIFs_Simple);
            int eifsAverage = GetTextBoxValueOrDefault(txt_EIFs_Average);
            int eifsComplex = GetTextBoxValueOrDefault(txt_EIFs_Complex);
            int ilfsSimple = GetTextBoxValueOrDefault(txt_ILFs_Simple);
            int ilfsAverage = GetTextBoxValueOrDefault(txt_ILFs_Average);
            int ilfsComplex = GetTextBoxValueOrDefault(txt_ILFs_Complex);
            int fp = (eisSimple * 7 + eisAverage * 10 + eisComplex * 15) +
                     (oisSimple * 5 + oisAverage * 7 + oisComplex * 10) +
                     (eqsSimple * 3 + eqsAverage * 4 + eqsComplex * 6) +
                     (eifsSimple * 3 + eifsAverage * 4 + eifsComplex * 6) +
                     (ilfsSimple * 4 + ilfsAverage * 5 + ilfsComplex * 7);
            lb_Result.Text = fp.ToString();
            
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            // Sử dụng SaveFileDialog để lưu file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Export to Excel";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Excel.Application excelApp = new Excel.Application();

                Excel.Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);

                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                excelWorksheet.Name = "Report";

                // Tiêu đề các cột trong Excel
                excelWorksheet.Cells[1, 1] = "EIs_Simple";
                excelWorksheet.Cells[1, 2] = "EIs_Average";
                excelWorksheet.Cells[1, 3] = "EIs_Complex";
                excelWorksheet.Cells[1, 4] = "OIs_Simple";
                excelWorksheet.Cells[1, 5] = "OIs_Average";
                excelWorksheet.Cells[1, 6] = "OIs_Complex";
                excelWorksheet.Cells[1, 7] = "EQs_Simple";
                excelWorksheet.Cells[1, 8] = "EQs_Average";
                excelWorksheet.Cells[1, 9] = "EQs_Complex";
                excelWorksheet.Cells[1, 10] = "EIFs_Simple";
                excelWorksheet.Cells[1, 11] = "EIFs_Average";
                excelWorksheet.Cells[1, 12] = "EIFs_Complex";
                excelWorksheet.Cells[1, 13] = "ILFs_Simple";
                excelWorksheet.Cells[1, 14] = "ILFs_Average";
                excelWorksheet.Cells[1, 15] = "ILFs_Complex";
                excelWorksheet.Cells[1, 16] = "FunctionPoint";

                // Ghi dữ liệu từ TextBox vào Excel
                excelWorksheet.Cells[2, 1] = GetTextBoxValueOrDefault(txt_EIs_Simple);
                excelWorksheet.Cells[2, 2] = GetTextBoxValueOrDefault(txt_EIs_Average);
                excelWorksheet.Cells[2, 3] = GetTextBoxValueOrDefault(txt_EIs_Complex);
                excelWorksheet.Cells[2, 4] = GetTextBoxValueOrDefault(txt_OIs_Simple);
                excelWorksheet.Cells[2, 5] = GetTextBoxValueOrDefault(txt_OIs_Average);
                excelWorksheet.Cells[2, 6] = GetTextBoxValueOrDefault(txt_OIs_Complex);
                excelWorksheet.Cells[2, 7] = GetTextBoxValueOrDefault(txt_EQs_Simple);
                excelWorksheet.Cells[2, 8] = GetTextBoxValueOrDefault(txt_EQs_Average);
                excelWorksheet.Cells[2, 9] = GetTextBoxValueOrDefault(txt_EQs_Complex);
                excelWorksheet.Cells[2, 10] = GetTextBoxValueOrDefault(txt_EIFs_Simple);
                excelWorksheet.Cells[2, 11] = GetTextBoxValueOrDefault(txt_EIFs_Average);
                excelWorksheet.Cells[2, 12] = GetTextBoxValueOrDefault(txt_EIFs_Complex);
                excelWorksheet.Cells[2, 13] = GetTextBoxValueOrDefault(txt_ILFs_Simple);
                excelWorksheet.Cells[2, 14] = GetTextBoxValueOrDefault(txt_ILFs_Average);
                excelWorksheet.Cells[2, 15] = GetTextBoxValueOrDefault(txt_ILFs_Complex);

                // Tính toán Function Point từ các giá trị TextBox
                int eisSimple = GetTextBoxValueOrDefault(txt_EIs_Simple);
                int eisAverage = GetTextBoxValueOrDefault(txt_EIs_Average);
                int eisComplex = GetTextBoxValueOrDefault(txt_EIs_Complex);
                int oisSimple = GetTextBoxValueOrDefault(txt_OIs_Simple);
                int oisAverage = GetTextBoxValueOrDefault(txt_OIs_Average);
                int oisComplex = GetTextBoxValueOrDefault(txt_OIs_Complex);
                int eqsSimple = GetTextBoxValueOrDefault(txt_EQs_Simple);
                int eqsAverage = GetTextBoxValueOrDefault(txt_EQs_Average);
                int eqsComplex = GetTextBoxValueOrDefault(txt_EQs_Complex);
                int eifsSimple = GetTextBoxValueOrDefault(txt_EIFs_Simple);
                int eifsAverage = GetTextBoxValueOrDefault(txt_EIFs_Average);
                int eifsComplex = GetTextBoxValueOrDefault(txt_EIFs_Complex);
                int ilfsSimple = GetTextBoxValueOrDefault(txt_ILFs_Simple);
                int ilfsAverage = GetTextBoxValueOrDefault(txt_ILFs_Average);
                int ilfsComplex = GetTextBoxValueOrDefault(txt_ILFs_Complex);

                int fp = (eisSimple * 7 + eisAverage * 10 + eisComplex * 15) +
                         (oisSimple * 5 + oisAverage * 7 + oisComplex * 10) +
                         (eqsSimple * 3 + eqsAverage * 4 + eqsComplex * 6) +
                         (eifsSimple * 3 + eifsAverage * 4 + eifsComplex * 6) +
                         (ilfsSimple * 4 + ilfsAverage * 5 + ilfsComplex * 7);
                excelWorksheet.Cells[2, 16] = fp.ToString();
                excelWorkbook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlWorkbookDefault);
                excelWorkbook.Close();
                excelApp.Quit();
                MessageBox.Show("Data exported successfully to Excel!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
