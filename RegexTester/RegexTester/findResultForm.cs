using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexTester
{
    public partial class findResultForm : Form
    {
        public findResultForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// to display the dialog of the matching result
        /// </summary>
        /// <param name="matchCol">the matching text passing by Form1</param>
        /// <param name="control">refer to the richtextbox control</param>
        public findResultForm(MatchCollection matchCol, Control control)
        {
            InitializeComponent();            

            //I will add the finding result into DataGridView dynamically
            foreach (Match match in matchCol)
            {
                //DataGridView 动态添加新行
                //dataGridView1.Rows.Add()为DataGridView控件增加新行，兵返回新行索引号，即新行行号
                int index = findDataGridView.Rows.Add();
                /*
                findDataGridView.Rows[index].Cells[0].Value = index;
                findDataGridView.Rows[index].Cells[1].Value = match.ToString();
                findDataGridView.Rows[index].Cells[2].Value = match.Index;
                findDataGridView.Rows[index].Cells[3].Value = match.Length;
                 */
                findDataGridView.Rows[index].Cells["no"].Value = index;
                findDataGridView.Rows[index].Cells["resultTxt"].Value = match.ToString();
                findDataGridView.Rows[index].Cells["pos"].Value = match.Index;
                findDataGridView.Rows[index].Cells["Row"].Value = ((RichTextBox)control).GetLineFromCharIndex(match.Index) + 1;
                //获取所在行号，并转换为int 类型
                int row = Convert.ToInt32(findDataGridView.Rows[index].Cells["Row"].Value) - 1;
                findDataGridView.Rows[index].Cells["Col"].Value = match.Index - ((RichTextBox)control).GetFirstCharIndexFromLine(row) + 1;
                findDataGridView.Rows[index].Cells["len"].Value = match.Length;                
            }           
            
        }

        private void btnFindResultOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
