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
    public partial class frm_MainUCP : Form
    {
        public frm_MainUCP()
        {
            InitializeComponent();
        }
        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép các ký tự số và các phím điều hướng (ví dụ: Backspace, Delete) 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "^[0-9]*$"))
            {
                textBox.Text = string.Empty;
            }
        }


        private void btn_DeleteUUCW_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                MessageBox.Show("Successful Delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_UUCW_average.Clear();
                txt_UUCW_complex.Clear();
                txt_UUCW_Simple.Clear();
                lb_ResultUUCW.Text = "";
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

        private void count_UUCW()
        {
            int UUCW_Simple = GetTextBoxValueOrDefault(txt_UUCW_Simple);
            int UUCW_Average = GetTextBoxValueOrDefault(txt_UUCW_average);
            int UUCW_Complex = GetTextBoxValueOrDefault(txt_UUCW_complex);
            int uucw = UUCW_Simple * 2 + UUCW_Average * 10 + UUCW_Complex * 15;
            lb_ResultUUCW.Text = uucw.ToString();
        }

        private void btn_UUCW_Click(object sender, EventArgs e)
        {
            count_UUCW();
        }



        private void btn_exportUUCW_Click_1(object sender, EventArgs e)
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
                excelWorksheet.Cells[1, 1] = "Number of simple Use Cases";
                excelWorksheet.Cells[1, 2] = "Number of average Use Cases";
                excelWorksheet.Cells[1, 3] = "Number of complex Use Cases";
                excelWorksheet.Cells[1, 4] = "UUCW";


                // Ghi dữ liệu từ TextBox vào Excel
                excelWorksheet.Cells[2, 1] = GetTextBoxValueOrDefault(txt_UUCW_Simple);
                excelWorksheet.Cells[2, 2] = GetTextBoxValueOrDefault(txt_UUCW_average);
                excelWorksheet.Cells[2, 3] = GetTextBoxValueOrDefault(txt_UUCW_complex);


                // Tính toán Function Point từ các giá trị TextBox
                int UUCW_Simple = GetTextBoxValueOrDefault(txt_UUCW_Simple);
                int UUCW_Average = GetTextBoxValueOrDefault(txt_UUCW_average);
                int UUCW_Complex = GetTextBoxValueOrDefault(txt_UUCW_complex);
                int uucw = UUCW_Simple * 2 + UUCW_Average * 10 + UUCW_Complex * 15;

                excelWorksheet.Cells[2, 4] = uucw.ToString();
                excelWorkbook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlWorkbookDefault);
                excelWorkbook.Close();
                excelApp.Quit();
                MessageBox.Show("Data exported successfully to Excel!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_exportUAW_Click(object sender, EventArgs e)
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
                excelWorksheet.Cells[1, 1] = "Simple Actors ";
                excelWorksheet.Cells[1, 2] = "Average Actors ";
                excelWorksheet.Cells[1, 3] = "Complex Actors ";
                excelWorksheet.Cells[1, 4] = "UAW";


                // Ghi dữ liệu từ TextBox vào Excel
                excelWorksheet.Cells[2, 1] = GetTextBoxValueOrDefault(txt_UAW_simple);
                excelWorksheet.Cells[2, 2] = GetTextBoxValueOrDefault(txt_UAW_average);
                excelWorksheet.Cells[2, 3] = GetTextBoxValueOrDefault(txt_UAW_complex);


                // Tính toán Function Point từ các giá trị TextBox
                int UAW_Simple = GetTextBoxValueOrDefault(txt_UAW_simple);
                int UAW_Average = GetTextBoxValueOrDefault(txt_UAW_average);
                int UAW_Complex = GetTextBoxValueOrDefault(txt_UAW_complex);
                int uaw = UAW_Simple * 1 + UAW_Average * 2 + UAW_Complex * 3;

                excelWorksheet.Cells[2, 4] = uaw.ToString();
                excelWorkbook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlWorkbookDefault);
                excelWorkbook.Close();
                excelApp.Quit();
                MessageBox.Show("Data exported successfully to Excel!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_DeleteUAW_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                MessageBox.Show("Successful Delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_UAW_complex.Clear();
                txt_UAW_average.Clear();
                txt_UAW_simple.Clear();
                lb_ResultUAW.Text = "";
            }
        }

        private void count_UAW()
        {
            int UAW_Simple = GetTextBoxValueOrDefault(txt_UAW_simple);
            int UAW_Average = GetTextBoxValueOrDefault(txt_UAW_average);
            int UAW_Complex = GetTextBoxValueOrDefault(txt_UAW_complex);
            int uaw = UAW_Simple * 1 + UAW_Average * 2 + UAW_Complex * 3;
            lb_ResultUAW.Text = uaw.ToString();
        }

        private void btn_UAW_Click(object sender, EventArgs e)
        {
            count_UAW();
        }
        private void textBoxVAF_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender; // Lấy TextBox gửi sự kiện

            // Kiểm tra nếu phím được nhấn là một chữ số từ 1 đến 5 hoặc không phải là phím Control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Từ chối ký tự đang được nhập
                MessageBox.Show("Please enter a digit from 1 to 5.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Lấy giá trị số hiện tại của TextBox
                string currentText = textBox.Text + e.KeyChar.ToString();
                int currentValue;
                if (int.TryParse(currentText, out currentValue))
                {
                    // Kiểm tra nếu giá trị là từ 1 đến 5
                    if (currentValue <= 0 || currentValue > 5)
                    {
                        e.Handled = true; // Từ chối giá trị ngoài phạm vi
                        MessageBox.Show("Please enter a digit from 1 to 5.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender; // Lấy TextBox gửi sự kiện

            // Kiểm tra nếu TextBox rỗng hoặc giá trị không hợp lệ, đặt lại thành 1
            int currentValue;
            if (!int.TryParse(textBox.Text, out currentValue) || currentValue <= 0 || currentValue > 5)
            {
                textBox.Text = "0";
            }
        }

        private void btn_deleteVAF_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                MessageBox.Show("Successful Delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CPL.Clear();
                txt_DCC.Clear();
                txt_DTP.Clear();
                txt_EOE.Clear();
                txt_FAC.Clear();
                txt_HUC.Clear();
                txt_IHE.Clear();
                txt_MSI.Clear();
                txt_ODC.Clear();
                txt_OLU.Clear();
                txt_OPE.Clear();
                txt_PER.Clear();
                txt_RSB.Clear();
                txt_TRN.Clear();
                txt_VAF.Clear();
            }
        }
        private double GetTextBoxValueOrDefault_VAF(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return 0;
            }
            else
            {
                return double.Parse(textBox.Text);
            }
        }
        private void count_VAF()
        {
            double dcc = GetTextBoxValueOrDefault_VAF(txt_DCC);
            double dtp = GetTextBoxValueOrDefault_VAF(txt_DTP);
            double per = GetTextBoxValueOrDefault_VAF(txt_PER);
            double huc = GetTextBoxValueOrDefault_VAF(txt_HUC);
            double trn = GetTextBoxValueOrDefault_VAF(txt_TRN);
            double odc = GetTextBoxValueOrDefault_VAF(txt_ODC);
            double eoe = GetTextBoxValueOrDefault_VAF(txt_EOE);
            double olu = GetTextBoxValueOrDefault_VAF(txt_OLU);
            double cpl = GetTextBoxValueOrDefault_VAF(txt_CPL);
            double rsb = GetTextBoxValueOrDefault_VAF(txt_RSB);
            double ihe = GetTextBoxValueOrDefault_VAF(txt_IHE);
            double ope = GetTextBoxValueOrDefault_VAF(txt_OPE);
            double msi = GetTextBoxValueOrDefault_VAF(txt_MSI);
            double fac = GetTextBoxValueOrDefault_VAF(txt_FAC);

            double sum = dcc * 2 + dtp * 1 + per * 3 + huc * 2 + trn * 2 + odc * 1 +
                         eoe * 1 + olu * 1 + cpl * 1 + rsb * 1 + ihe * 0.5 + ope * 0.5
                         + msi * 2 + fac * 1;
            double vaf = 0.65 + sum * 0.01;
            txt_VAF.Text = vaf.ToString();
        }

        private void btn_VAF_Click(object sender, EventArgs e)
        {
            count_VAF();

            //if (0 < (sum * 0.01) && (sum * 0.01) < 0.7)
            //{
            //    txt_VAF.Text = (0.65 + (sum * 0.01)).ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Min = 0 and Max = 0.7", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            
        }

        private void btn_exportVAF_Click(object sender, EventArgs e)
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
                excelWorksheet.Cells[1, 1] = "Data Communications (DCC) ";
                excelWorksheet.Cells[1, 2] = "Distributed Data Processing (DTP) ";
                excelWorksheet.Cells[1, 3] = "Performance (PER) ";
                excelWorksheet.Cells[1, 4] = "Heavily Used Configuration (HUC)";
                excelWorksheet.Cells[1, 5] = "Transaction Rate (TRN)";
                excelWorksheet.Cells[1, 6] = "Online Data Entry (ODC) ";
                excelWorksheet.Cells[1, 7] = "End-User Efficiency (EOE) ";
                excelWorksheet.Cells[1, 8] = "Online Update (OLU) ";
                excelWorksheet.Cells[1, 9] = "Complex Processing (CPL)";
                excelWorksheet.Cells[1, 10] = "Reusability (RSB)";
                excelWorksheet.Cells[1, 11] = "Installation Ease (IHE) ";
                excelWorksheet.Cells[1, 12] = "Operational Ease (OPE) ";
                excelWorksheet.Cells[1, 13] = "Multiple Sites (MSI) ";
                excelWorksheet.Cells[1, 14] = "Facilitate Change (FAC)";
                excelWorksheet.Cells[1, 15] = "VAF";


                // Ghi dữ liệu từ TextBox vào Excel
                excelWorksheet.Cells[2, 1] = GetTextBoxValueOrDefault_VAF(txt_DCC);
                excelWorksheet.Cells[2, 2] = GetTextBoxValueOrDefault_VAF(txt_DTP);
                excelWorksheet.Cells[2, 3] = GetTextBoxValueOrDefault_VAF(txt_PER);
                excelWorksheet.Cells[2, 4] = GetTextBoxValueOrDefault_VAF(txt_HUC);
                excelWorksheet.Cells[2, 5] = GetTextBoxValueOrDefault_VAF(txt_TRN);
                excelWorksheet.Cells[2, 6] = GetTextBoxValueOrDefault_VAF(txt_ODC);
                excelWorksheet.Cells[2, 7] = GetTextBoxValueOrDefault_VAF(txt_EOE);
                excelWorksheet.Cells[2, 8] = GetTextBoxValueOrDefault_VAF(txt_OLU);
                excelWorksheet.Cells[2, 9] = GetTextBoxValueOrDefault_VAF(txt_CPL);
                excelWorksheet.Cells[2, 10] = GetTextBoxValueOrDefault_VAF(txt_RSB);
                excelWorksheet.Cells[2, 11] = GetTextBoxValueOrDefault_VAF(txt_IHE);
                excelWorksheet.Cells[2, 12] = GetTextBoxValueOrDefault_VAF(txt_OPE);
                excelWorksheet.Cells[2, 13] = GetTextBoxValueOrDefault_VAF(txt_MSI);
                excelWorksheet.Cells[2, 14] = GetTextBoxValueOrDefault_VAF(txt_FAC);


                // Tính toán Function Point từ các giá trị TextBox
                double dcc = GetTextBoxValueOrDefault_VAF(txt_DCC);
                double dtp = GetTextBoxValueOrDefault_VAF(txt_DTP);
                double per = GetTextBoxValueOrDefault_VAF(txt_PER);
                double huc = GetTextBoxValueOrDefault_VAF(txt_HUC);
                double trn = GetTextBoxValueOrDefault_VAF(txt_TRN);
                double odc = GetTextBoxValueOrDefault_VAF(txt_ODC);
                double eoe = GetTextBoxValueOrDefault_VAF(txt_EOE);
                double olu = GetTextBoxValueOrDefault_VAF(txt_OLU);
                double cpl = GetTextBoxValueOrDefault_VAF(txt_CPL);
                double rsb = GetTextBoxValueOrDefault_VAF(txt_RSB);
                double ihe = GetTextBoxValueOrDefault_VAF(txt_IHE);
                double ope = GetTextBoxValueOrDefault_VAF(txt_OPE);
                double msi = GetTextBoxValueOrDefault_VAF(txt_MSI);
                double fac = GetTextBoxValueOrDefault_VAF(txt_FAC);

                double sum = dcc * 2 + dtp * 1 + per * 3 + huc * 2 + trn * 2 + odc * 1 +
                             eoe * 1 + olu * 1 + cpl * 1 + rsb * 1 + ihe * 0.5 + ope * 0.5
                             + msi * 2 + fac * 1;
                double vaf = 0.65 + sum * 0.01;
                //txt_VAF.Text = vaf.ToString();

                excelWorksheet.Cells[2, 15] = vaf.ToString();
                excelWorkbook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlWorkbookDefault);
                excelWorkbook.Close();
                excelApp.Quit();
                MessageBox.Show("Data exported successfully to Excel!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_deleteAll_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                MessageBox.Show("Successful Delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_UUCW_average.Clear();
                txt_UUCW_complex.Clear();
                txt_UUCW_Simple.Clear();
                lb_ResultUUCW.Text = "";

                txt_UAW_complex.Clear();
                txt_UAW_average.Clear();
                txt_UAW_simple.Clear();
                lb_ResultUAW.Text = "";

                txt_CPL.Clear();
                txt_DCC.Clear();
                txt_DTP.Clear();
                txt_EOE.Clear();
                txt_FAC.Clear();
                txt_HUC.Clear();
                txt_IHE.Clear();
                txt_MSI.Clear();
                txt_ODC.Clear();
                txt_OLU.Clear();
                txt_OPE.Clear();
                txt_PER.Clear();
                txt_RSB.Clear();
                txt_TRN.Clear();
                txt_VAF.Clear();
            }
        }

        private void btn_UCP_Click(object sender, EventArgs e)
        {
            int UUCW_Simple = GetTextBoxValueOrDefault(txt_UUCW_Simple);
            int UUCW_Average = GetTextBoxValueOrDefault(txt_UUCW_average);
            int UUCW_Complex = GetTextBoxValueOrDefault(txt_UUCW_complex);
            int uucw = UUCW_Simple * 2 + UUCW_Average * 10 + UUCW_Complex * 15;
            lb_ResultUUCW.Text = uucw.ToString();

            int UAW_Simple = GetTextBoxValueOrDefault(txt_UAW_simple);
            int UAW_Average = GetTextBoxValueOrDefault(txt_UAW_average);
            int UAW_Complex = GetTextBoxValueOrDefault(txt_UAW_complex);
            int uaw = UAW_Simple * 1 + UAW_Average * 2 + UAW_Complex * 3;
            lb_ResultUAW.Text = uaw.ToString();

            double dcc = GetTextBoxValueOrDefault_VAF(txt_DCC);
            double dtp = GetTextBoxValueOrDefault_VAF(txt_DTP);
            double per = GetTextBoxValueOrDefault_VAF(txt_PER);
            double huc = GetTextBoxValueOrDefault_VAF(txt_HUC);
            double trn = GetTextBoxValueOrDefault_VAF(txt_TRN);
            double odc = GetTextBoxValueOrDefault_VAF(txt_ODC);
            double eoe = GetTextBoxValueOrDefault_VAF(txt_EOE);
            double olu = GetTextBoxValueOrDefault_VAF(txt_OLU);
            double cpl = GetTextBoxValueOrDefault_VAF(txt_CPL);
            double rsb = GetTextBoxValueOrDefault_VAF(txt_RSB);
            double ihe = GetTextBoxValueOrDefault_VAF(txt_IHE);
            double ope = GetTextBoxValueOrDefault_VAF(txt_OPE);
            double msi = GetTextBoxValueOrDefault_VAF(txt_MSI);
            double fac = GetTextBoxValueOrDefault_VAF(txt_FAC);

            double sum = dcc * 2 + dtp * 1 + per * 3 + huc * 2 + trn * 2 + odc * 1 +
                         eoe * 1 + olu * 1 + cpl * 1 + rsb * 1 + ihe * 0.5 + ope * 0.5
                         + msi * 2 + fac * 1;
            double vaf = 0.65 + sum * 0.01;
            txt_VAF.Text = vaf.ToString();


            double result = (uucw + uaw) * vaf;
            lb_method.Text = "UCP = ( UUCW + UAW ) * VAF";
            lb_resultAll.Text = "= ( " + uucw + " + " + uaw + " ) * " + vaf + " = " + result;
        }

        private void btn_exportAll_Click(object sender, EventArgs e)
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
                excelWorksheet.Cells[1, 1] = "Number of simple Use Cases";
                excelWorksheet.Cells[1, 2] = "Number of average Use Cases";
                excelWorksheet.Cells[1, 3] = "Number of complex Use Cases";
                excelWorksheet.Cells[1, 4] = "UUCW";


                // Ghi dữ liệu từ TextBox vào Excel
                excelWorksheet.Cells[2, 1] = GetTextBoxValueOrDefault(txt_UUCW_Simple);
                excelWorksheet.Cells[2, 2] = GetTextBoxValueOrDefault(txt_UUCW_average);
                excelWorksheet.Cells[2, 3] = GetTextBoxValueOrDefault(txt_UUCW_complex);


                // Tính toán Function Point từ các giá trị TextBox
                int UUCW_Simple = GetTextBoxValueOrDefault(txt_UUCW_Simple);
                int UUCW_Average = GetTextBoxValueOrDefault(txt_UUCW_average);
                int UUCW_Complex = GetTextBoxValueOrDefault(txt_UUCW_complex);
                int uucw = UUCW_Simple * 2 + UUCW_Average * 10 + UUCW_Complex * 15;

                excelWorksheet.Cells[2, 4] = uucw.ToString();

                // Tiêu đề các cột trong Excel
                excelWorksheet.Cells[4, 1] = "Simple Actors ";
                excelWorksheet.Cells[4, 2] = "Average Actors ";
                excelWorksheet.Cells[4, 3] = "Complex Actors ";
                excelWorksheet.Cells[4, 4] = "UAW";


                // Ghi dữ liệu từ TextBox vào Excel
                excelWorksheet.Cells[5, 1] = GetTextBoxValueOrDefault(txt_UAW_simple);
                excelWorksheet.Cells[5, 2] = GetTextBoxValueOrDefault(txt_UAW_average);
                excelWorksheet.Cells[5, 3] = GetTextBoxValueOrDefault(txt_UAW_complex);


                // Tính toán Function Point từ các giá trị TextBox
                int UAW_Simple = GetTextBoxValueOrDefault(txt_UAW_simple);
                int UAW_Average = GetTextBoxValueOrDefault(txt_UAW_average);
                int UAW_Complex = GetTextBoxValueOrDefault(txt_UAW_complex);
                int uaw = UAW_Simple * 1 + UAW_Average * 2 + UAW_Complex * 3;

                excelWorksheet.Cells[5, 4] = uaw.ToString();

                excelWorksheet.Cells[7, 1] = "Data Communications (DCC) ";
                excelWorksheet.Cells[7, 2] = "Distributed Data Processing (DTP) ";
                excelWorksheet.Cells[7, 3] = "Performance (PER) ";
                excelWorksheet.Cells[7, 4] = "Heavily Used Configuration (HUC)";
                excelWorksheet.Cells[7, 5] = "Transaction Rate (TRN)";
                excelWorksheet.Cells[7, 6] = "Online Data Entry (ODC) ";
                excelWorksheet.Cells[7, 7] = "End-User Efficiency (EOE) ";
                excelWorksheet.Cells[7, 8] = "Online Update (OLU) ";
                excelWorksheet.Cells[7, 9] = "Complex Processing (CPL)";
                excelWorksheet.Cells[7, 10] = "Reusability (RSB)";
                excelWorksheet.Cells[7, 11] = "Installation Ease (IHE) ";
                excelWorksheet.Cells[7, 12] = "Operational Ease (OPE) ";
                excelWorksheet.Cells[7, 13] = "Multiple Sites (MSI) ";
                excelWorksheet.Cells[7, 14] = "Facilitate Change (FAC)";
                excelWorksheet.Cells[7, 15] = "VAF";


                // Ghi dữ liệu từ TextBox vào Excel
                excelWorksheet.Cells[8, 1] = GetTextBoxValueOrDefault_VAF(txt_DCC);
                excelWorksheet.Cells[8, 2] = GetTextBoxValueOrDefault_VAF(txt_DTP);
                excelWorksheet.Cells[8, 3] = GetTextBoxValueOrDefault_VAF(txt_PER);
                excelWorksheet.Cells[8, 4] = GetTextBoxValueOrDefault_VAF(txt_HUC);
                excelWorksheet.Cells[8, 5] = GetTextBoxValueOrDefault_VAF(txt_TRN);
                excelWorksheet.Cells[8, 6] = GetTextBoxValueOrDefault_VAF(txt_ODC);
                excelWorksheet.Cells[8, 7] = GetTextBoxValueOrDefault_VAF(txt_EOE);
                excelWorksheet.Cells[8, 8] = GetTextBoxValueOrDefault_VAF(txt_OLU);
                excelWorksheet.Cells[8, 9] = GetTextBoxValueOrDefault_VAF(txt_CPL);
                excelWorksheet.Cells[8, 10] = GetTextBoxValueOrDefault_VAF(txt_RSB);
                excelWorksheet.Cells[8, 11] = GetTextBoxValueOrDefault_VAF(txt_IHE);
                excelWorksheet.Cells[8, 12] = GetTextBoxValueOrDefault_VAF(txt_OPE);
                excelWorksheet.Cells[8, 13] = GetTextBoxValueOrDefault_VAF(txt_MSI);
                excelWorksheet.Cells[8, 14] = GetTextBoxValueOrDefault_VAF(txt_FAC);


                // Tính toán Function Point từ các giá trị TextBox
                double dcc = GetTextBoxValueOrDefault_VAF(txt_DCC);
                double dtp = GetTextBoxValueOrDefault_VAF(txt_DTP);
                double per = GetTextBoxValueOrDefault_VAF(txt_PER);
                double huc = GetTextBoxValueOrDefault_VAF(txt_HUC);
                double trn = GetTextBoxValueOrDefault_VAF(txt_TRN);
                double odc = GetTextBoxValueOrDefault_VAF(txt_ODC);
                double eoe = GetTextBoxValueOrDefault_VAF(txt_EOE);
                double olu = GetTextBoxValueOrDefault_VAF(txt_OLU);
                double cpl = GetTextBoxValueOrDefault_VAF(txt_CPL);
                double rsb = GetTextBoxValueOrDefault_VAF(txt_RSB);
                double ihe = GetTextBoxValueOrDefault_VAF(txt_IHE);
                double ope = GetTextBoxValueOrDefault_VAF(txt_OPE);
                double msi = GetTextBoxValueOrDefault_VAF(txt_MSI);
                double fac = GetTextBoxValueOrDefault_VAF(txt_FAC);

                double sum = dcc * 2 + dtp * 1 + per * 3 + huc * 2 + trn * 2 + odc * 1 +
                             eoe * 1 + olu * 1 + cpl * 1 + rsb * 1 + ihe * 0.5 + ope * 0.5
                             + msi * 2 + fac * 1;
                double vaf = 0.65 + sum * 0.01;
                //txt_VAF.Text = vaf.ToString();

                excelWorksheet.Cells[8, 15] = vaf.ToString();

                excelWorksheet.Cells[10, 1] = "UUCW";
                excelWorksheet.Cells[10, 2] = "UAW";
                excelWorksheet.Cells[10, 3] = "VAF";
                excelWorksheet.Cells[10, 4] = "UCP = (UUCW + UAW) * VAF";


                // Ghi dữ liệu từ TextBox vào Excel
                excelWorksheet.Cells[11, 1] = uucw;
                excelWorksheet.Cells[11, 2] = uaw;
                excelWorksheet.Cells[11, 3] = vaf;
                excelWorksheet.Cells[11, 4] = (uucw + uaw) * vaf;

                excelWorkbook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlWorkbookDefault);
                excelWorkbook.Close();
                excelApp.Quit();
                MessageBox.Show("Data exported successfully to Excel!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
} 
