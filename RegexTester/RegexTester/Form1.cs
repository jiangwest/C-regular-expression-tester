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
    public partial class Form1 : Form
    {
        MatchCollection mc; //to store the matching result
        int curPos; //the current pointer to mc structure

        public Form1()
        {
            InitializeComponent();
            //initialize Prev and Next button 
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
        }

        /// <summary>
        /// the process function of button Find, its main function includes
        /// 1. to ensure find pattern and the finding text both aren't empty
        /// 2. use Regular expression to match
        /// 3. to show the dialog of finding result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            string pattern = @txtPattern.Text; //为要查找的字符串
            string searchTxt = richTxtInput.Text;

            //if searchTxt or pattern is empty string
            if (String.IsNullOrEmpty(searchTxt) || String.IsNullOrEmpty(pattern))
            {
                MessageBox.Show("please input string in pattern and search Text!", "Notice");
                return;
            }
                

            //I use Regular Exprression to realize find or replace function
            //满足pattern的匹配集合
            mc = Regex.Matches(searchTxt, pattern);

            //RichTextBox中匹配集合着色
            addMatchColor();

            //active the find result form to display the result of find
            findResultForm findDlg = new findResultForm(mc, richTxtInput);
            findDlg.ShowDialog();

            //设置current Position
            curPos = 0;
            btnNext.Enabled = true;
        }

        /// <summary>
        /// to emphasize the matching text with different color and font
        /// </summary>
        private void addMatchColor(){

            foreach (Match m in mc)
            {
                richTxtInput.SelectionStart = m.Index;
                richTxtInput.SelectionLength = m.Length;
                richTxtInput.SelectionColor = Color.Red;
                richTxtInput.SelectionFont = new Font("Times New Roman", (float)12, FontStyle.Bold);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// to fire a about dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            myAboutBox about = new myAboutBox();         
            about.Show();
        }

        /// <summary>
        /// to intercept Ctrl+C signal, 
        /// if user choose no style, it clear up the style of text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            //is no checked, paste() doesn't alter old style 
            if (checkTxtStyle.Checked == false)                
                return;            

            if (e.Control && e.KeyCode == Keys.V)
            {
                richTxtInput.Clear();   //清空 RichTextBox

                IDataObject dataObj = Clipboard.GetDataObject();
                if (dataObj.GetDataPresent(DataFormats.StringFormat))
                {
                    e.Handled = true; //去掉格式文本的格式 
                    var txt = (string)Clipboard.GetData(DataFormats.StringFormat);
                    Clipboard.Clear();
                    Clipboard.SetData(DataFormats.StringFormat, txt);
                    richTxtInput.Paste();
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (curPos == mc.Count-1 && btnNext.Enabled == false)
                btnNext.Enabled = true;

            if (curPos > 0)
            {
                curPos--;
                richTxtInput.Select(mc[curPos].Index, 0);

                Cursor = Cursors.Hand;
                
                richTxtInput.Focus();
            }
            else
            {
                btnPrev.Enabled = false;
            }                
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //activate Next button
            if (curPos == 0 && btnPrev.Enabled == false)
                btnPrev.Enabled = true;

            if (curPos < mc.Count-1)
            {
                curPos++;
                richTxtInput.Select(mc[curPos].Index, 0);
                
                Cursor = Cursors.Hand;
                richTxtInput.Focus();

            }
            else
            {
                btnNext.Enabled = false;
            }
        }

        /// <summary>
        /// to fire replace function by using regular expression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplace_Click(object sender, EventArgs e)
        {
            foreach (Match m in mc)
            {
                richTxtInput.Text = richTxtInput.Text.Replace(m.ToString(), txtReplace.Text);
            }
        }
    }
}
