namespace RegexTester
{
    partial class findResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.findDataGridView = new System.Windows.Forms.DataGridView();
            this.btnFindResultOk = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.len = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.findDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // findDataGridView
            // 
            this.findDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.findDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.resultTxt,
            this.pos,
            this.Row,
            this.Col,
            this.len});
            this.findDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.findDataGridView.Location = new System.Drawing.Point(0, 0);
            this.findDataGridView.Name = "findDataGridView";
            this.findDataGridView.RowTemplate.Height = 27;
            this.findDataGridView.Size = new System.Drawing.Size(644, 150);
            this.findDataGridView.TabIndex = 0;
            // 
            // btnFindResultOk
            // 
            this.btnFindResultOk.Location = new System.Drawing.Point(242, 220);
            this.btnFindResultOk.Name = "btnFindResultOk";
            this.btnFindResultOk.Size = new System.Drawing.Size(75, 23);
            this.btnFindResultOk.TabIndex = 1;
            this.btnFindResultOk.Text = "Ok";
            this.btnFindResultOk.UseVisualStyleBackColor = true;
            this.btnFindResultOk.Click += new System.EventHandler(this.btnFindResultOk_Click);
            // 
            // no
            // 
            this.no.HeaderText = "序号";
            this.no.Name = "no";
            // 
            // resultTxt
            // 
            this.resultTxt.HeaderText = "String";
            this.resultTxt.Name = "resultTxt";
            // 
            // pos
            // 
            this.pos.HeaderText = "Position";
            this.pos.Name = "pos";
            // 
            // Row
            // 
            this.Row.HeaderText = "Row 行";
            this.Row.Name = "Row";
            // 
            // Col
            // 
            this.Col.HeaderText = "Col 列";
            this.Col.Name = "Col";
            // 
            // len
            // 
            this.len.HeaderText = "Length";
            this.len.Name = "len";
            // 
            // findResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 255);
            this.Controls.Add(this.btnFindResultOk);
            this.Controls.Add(this.findDataGridView);
            this.Name = "findResultForm";
            this.Text = "find Result";
            ((System.ComponentModel.ISupportInitialize)(this.findDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView findDataGridView;
        private System.Windows.Forms.Button btnFindResultOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn len;
    }
}