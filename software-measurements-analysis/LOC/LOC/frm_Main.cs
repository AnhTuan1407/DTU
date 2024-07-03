using Microsoft.Office.Interop.Excel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Excel = Microsoft.Office.Interop.Excel;

namespace LOC
{
    public partial class frm_Main : Form
    {

        public frm_Main()
        {
            InitializeComponent();
            loadListView();
        }

        private void btn_Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //hien thi duong dan folder len textbox
                txt_folder.Text = "   " + fbd.SelectedPath;
            }
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true; //co the chon nhieu file
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //hien thi duong dan file len textbox
                txt_file.Text = "   " + ofd.FileName;
            }
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_folder.Text))
            {
                //dem so dong code trong folder
                CountLinesInFolder(txt_folder.Text);
                txt_file.Text = "";
                txt_folder.Text = "";
            }
            else if (!string.IsNullOrEmpty(txt_file.Text))
            {
                //dem so dong code trong file
                CountLinesInFile(txt_file.Text);
                txt_file.Text = "";
                txt_folder.Text = "";
            }
            else
            {
                MessageBox.Show("Please select a file or folder first.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_file.Text = "";
                txt_folder.Text = "";
            }
        }

        private void CountLinesInFolder(string folderPath)
        {
            //lay danh sach cac file trong folder
            var files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                if (IsSourceFile(file))
                {
                    //dem so dong code
                    var lines = File.ReadAllLines(file).Length;
                    //lay ten tep
                    var name = Path.GetFileName(file);
                    //lay duong dan tep
                    var path = file;
                    var blank = 0;
                    var comment = 0;
                    using (StreamReader reader = new StreamReader(file))
                    {
                        string line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Trim() == "")
                            {
                                blank++;
                            }

                            if (line.Trim().StartsWith("//") || line.Trim().StartsWith("/*"))
                            {
                                comment++;
                            }
                        }
                    }

                    var item = new ListViewItem(new[] { name, lines.ToString(), blank.ToString(), comment.ToString(), path });
                    listView1.Items.Add(item);

                }
            }
        }

        private void CountLinesInFile(string filePath)
        {
            if (IsSourceFile(filePath))
            {
                var lines = File.ReadAllLines(filePath).Length;
                var name = Path.GetFileName(filePath);
                var path = filePath;
                var blank = 0;
                var comment = 0;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Trim() == "")
                        {
                            blank++;
                        }

                        if (line.Trim().StartsWith("//") || line.Trim().StartsWith("/*"))
                        {
                            comment++;
                        }
                    }
                }
                var item = new ListViewItem(new[] { name, lines.ToString(), blank.ToString(), comment.ToString(), path });
                listView1.Items.Add(item);
            }
        }

        private bool IsSourceFile(string filePath)
        {
            //kiem tra tep co dung ma nguon khong
            var extension = Path.GetExtension(filePath);
            return extension == ".cs" || extension == ".cpp" || extension == ".js" || extension == ".java";
        }

        void loadListView()
        {
            listView1.Columns.Add("File Name", 200).Tag = true;
            listView1.Columns.Add("LOC", 100).Tag = true;
            listView1.Columns.Add("Blank", 100).Tag = true;
            listView1.Columns.Add("Comment", 100).Tag = true;
            listView1.Columns.Add("Directory File", 500).Tag = true;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            //su dung SaveFileDialog de luu file excel
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

                //chen cac cot tuong ung
                for (int i = 0; i < listView1.Columns.Count; i++)
                {
                    excelWorksheet.Cells[1, i + 1] = listView1.Columns[i].Text.ToString();
                }

                //ghi du lieu tu listview vao excel
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    for (int j = 0; j < listView1.Columns.Count; j++)
                    {
                        excelWorksheet.Cells[i + 2, j + 1] = listView1.Items[i].SubItems[j].Text.ToString();
                    }
                }

                excelWorkbook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlWorkbookDefault);
                excelWorkbook.Close();
                excelApp.Quit();
                //hien thi thong bao export thanh cong
                MessageBox.Show("Data exported successfully to Excel!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    MessageBox.Show("Successful Delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
            else MessageBox.Show("Delete Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                MessageBox.Show("Successful Delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView1.Items.Clear();
            }
        }
    }

}