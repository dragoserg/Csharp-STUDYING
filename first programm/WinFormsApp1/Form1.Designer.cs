namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12 });
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            resources.ApplyResources(Column1, "Column1");
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            resources.ApplyResources(Column2, "Column2");
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            resources.ApplyResources(Column3, "Column3");
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            resources.ApplyResources(Column4, "Column4");
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            resources.ApplyResources(Column5, "Column5");
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            resources.ApplyResources(Column6, "Column6");
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            resources.ApplyResources(Column7, "Column7");
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            resources.ApplyResources(Column8, "Column8");
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            resources.ApplyResources(Column9, "Column9");
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            resources.ApplyResources(Column10, "Column10");
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            resources.ApplyResources(Column11, "Column11");
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            resources.ApplyResources(Column12, "Column12");
            Column12.Name = "Column12";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(dataGridView1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
    }
}
