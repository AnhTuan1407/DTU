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
    public partial class frm_MainEVM : Form
    {
        public frm_MainEVM()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void textBoxMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender; // Lấy TextBox gửi sự kiện

            // Kiểm tra nếu phím được nhấn là một chữ số từ 1 đến 12 hoặc không phải là phím Control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Từ chối ký tự đang được nhập
                MessageBox.Show("Please enter a digit from 1 to 12.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Lấy giá trị số hiện tại của TextBox
                string currentText = textBox.Text + e.KeyChar.ToString();
                int currentValue;
                if (int.TryParse(currentText, out currentValue))
                {
                    // Kiểm tra nếu giá trị là từ 1 đến 12
                    if (currentValue <= 0 || currentValue > 12)
                    {
                        e.Handled = true; // Từ chối giá trị ngoài phạm vi
                        MessageBox.Show("Please enter a digit from 1 to 12.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép các ký tự số và phím Delete
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete)
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
                textBox.Text = "1";
            }
        }

        private void btn_DeleteEVM_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                MessageBox.Show("Successful Delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_monthE.Clear();
                txt_monthSC.Clear();
                txt_BAC.Clear();
                txt_AC.Clear();
                txt_EV.Clear();
                txt_PV.Clear();
                txt_SV.Clear();
                txt_SPI.Clear();
                txt_CV.Clear();
                txt_CPI.Clear();
                txt_EAC.Clear();
                txt_ETC.Clear();
                txt_VAC.Clear();
            }
        }
        private double GetTextBoxValueOrDefault(TextBox textBox)
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

        private void btn_EVM_Click(object sender, EventArgs e)
        {
            double monthS = GetTextBoxValueOrDefault(txt_monthSC);
            double monthE = GetTextBoxValueOrDefault(txt_monthE);
            double bac = GetTextBoxValueOrDefault(txt_BAC);
            double ac = GetTextBoxValueOrDefault(txt_AC);
            double ev = GetTextBoxValueOrDefault(txt_EV);
            double pv = (bac / 12) * 6;
            double sv = ev - pv;
            double spi = ev/pv;
            double cv = ev - ac;
            double cpi = ev/ac;
            double eac = ((bac - ev)/cpi) + ac;
            double etc = eac -ac;
            double vac = eac - bac;

            txt_PV.Text = pv.ToString();
            txt_SV.Text = sv.ToString();
            txt_SPI.Text = spi.ToString();
            txt_CV.Text = cv.ToString();
            txt_CPI.Text = cpi.ToString();
            txt_EAC.Text = eac.ToString();
            txt_ETC.Text = etc.ToString();
            txt_VAC.Text = vac.ToString();

            if(spi == 1)
            {
                lb_SPI.Text = "The project is progressing on schedule.";
            }
            else if (spi > 1)
            {
                lb_SPI.Text = "The project is progressing faster than planned.";
            }
            else
            {
                lb_SPI.Text = "The project is behind schedule.";
            }

            if (cpi == 1)
            {
                lb_CPI.Text = "The project is spending on budget.";
            }
            else if (cpi > 1)
            {
                lb_CPI.Text = "The project is spending less "+"\nthan the expected budget.";
            }
            else
            {
                lb_CPI.Text = "The project is spending more " + "\nthan the expected budget";
            }

        }

        private void btn_exportEVM_Click(object sender, EventArgs e)
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
                excelWorksheet.Cells[1, 1] = "The project is scheduled to last (Months) ";
                excelWorksheet.Cells[1, 2] = "The end of";
                excelWorksheet.Cells[1, 3] = "Budget at completion (BAC)";
                excelWorksheet.Cells[1, 4] = "Actual Cost (AC)";
                excelWorksheet.Cells[1, 5] = "Earned Value (EV)";


                // Ghi dữ liệu từ TextBox vào Excel
                excelWorksheet.Cells[2, 1] = GetTextBoxValueOrDefault(txt_monthSC);
                excelWorksheet.Cells[2, 2] = GetTextBoxValueOrDefault(txt_monthE);
                excelWorksheet.Cells[2, 3] = GetTextBoxValueOrDefault(txt_BAC);
                excelWorksheet.Cells[2, 4] = GetTextBoxValueOrDefault(txt_AC);
                excelWorksheet.Cells[2, 5] = GetTextBoxValueOrDefault(txt_EV);

                double monthS = GetTextBoxValueOrDefault(txt_monthSC);
                double monthE = GetTextBoxValueOrDefault(txt_monthE);
                double bac = GetTextBoxValueOrDefault(txt_BAC);
                double ac = GetTextBoxValueOrDefault(txt_AC);
                double ev = GetTextBoxValueOrDefault(txt_EV);
                double pv = (bac / 12) * 6;
                double sv = ev - pv;
                double spi = ev / pv;
                double cv = ev - ac;
                double cpi = ev / ac;
                double eac = ((bac - ev) / cpi) + ac;
                double etc = eac - ac;
                double vac = eac - bac;

                excelWorksheet.Cells[4, 1] = "Planned Value (PV)";
                excelWorksheet.Cells[4, 2] = "Schedule Variance (SV)";
                excelWorksheet.Cells[4, 3] = "Schedule Performance Index (SPI)";
                excelWorksheet.Cells[4, 4] = "Cost Variance (CV)";
                excelWorksheet.Cells[4, 5] = "Cost Performance Index (CPI)";
                excelWorksheet.Cells[4, 6] = "Estimate At Completion (EAC)";
                excelWorksheet.Cells[4, 7] = "Estimate To Complete (ETC)";
                excelWorksheet.Cells[4, 8] = "Variance At Completion (VAC)";

                excelWorksheet.Cells[5, 1] = pv;
                excelWorksheet.Cells[5, 2] = sv;
                excelWorksheet.Cells[5, 3] = spi;
                excelWorksheet.Cells[5, 4] = cv;
                excelWorksheet.Cells[5, 5] = cpi;
                excelWorksheet.Cells[5, 6] = eac;
                excelWorksheet.Cells[5, 7] = etc;
                excelWorksheet.Cells[5, 8] = vac;


                if (spi == 1)
                {
                    excelWorksheet.Cells[7, 1] = "The project is progressing on schedule.";
                }
                else if (spi > 1)
                {
                    excelWorksheet.Cells[7, 1] = "The project is progressing faster than planned.";
                }
                else
                {
                    excelWorksheet.Cells[7, 1] = "The project is behind schedule.";
                }

                if (cpi == 1)
                {
                    excelWorksheet.Cells[8, 1] = "The project is spending on budget.";
                }
                else if (cpi > 1)
                {
                    excelWorksheet.Cells[8, 1] = "The project is spending less than the expected budget.";
                }
                else
                {
                    excelWorksheet.Cells[8, 1] = "The project is spending more than the expected budget";
                }

                excelWorkbook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlWorkbookDefault);
                excelWorkbook.Close();
                excelApp.Quit();
                MessageBox.Show("Data exported successfully to Excel!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
