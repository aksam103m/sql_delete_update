namespace sqlKomutları
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kUTUPHANEDataSet1 = new sqlKomutları.KUTUPHANEDataSet1();
            this.yazarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazarTableAdapter = new sqlKomutları.KUTUPHANEDataSet1TableAdapters.yazarTableAdapter();
            this.yazarnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazaradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumtarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kUTUPHANEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yazarnoDataGridViewTextBoxColumn,
            this.yazaradDataGridViewTextBoxColumn,
            this.dogumtarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yazarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // kUTUPHANEDataSet1
            // 
            this.kUTUPHANEDataSet1.DataSetName = "KUTUPHANEDataSet1";
            this.kUTUPHANEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yazarBindingSource
            // 
            this.yazarBindingSource.DataMember = "yazar";
            this.yazarBindingSource.DataSource = this.kUTUPHANEDataSet1;
            // 
            // yazarTableAdapter
            // 
            this.yazarTableAdapter.ClearBeforeFill = true;
            // 
            // yazarnoDataGridViewTextBoxColumn
            // 
            this.yazarnoDataGridViewTextBoxColumn.DataPropertyName = "yazarno";
            this.yazarnoDataGridViewTextBoxColumn.HeaderText = "yazarno";
            this.yazarnoDataGridViewTextBoxColumn.Name = "yazarnoDataGridViewTextBoxColumn";
            this.yazarnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yazaradDataGridViewTextBoxColumn
            // 
            this.yazaradDataGridViewTextBoxColumn.DataPropertyName = "yazarad";
            this.yazaradDataGridViewTextBoxColumn.HeaderText = "yazarad";
            this.yazaradDataGridViewTextBoxColumn.Name = "yazaradDataGridViewTextBoxColumn";
            this.yazaradDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dogumtarihDataGridViewTextBoxColumn
            // 
            this.dogumtarihDataGridViewTextBoxColumn.DataPropertyName = "dogumtarih";
            this.dogumtarihDataGridViewTextBoxColumn.HeaderText = "dogumtarih";
            this.dogumtarihDataGridViewTextBoxColumn.Name = "dogumtarihDataGridViewTextBoxColumn";
            this.dogumtarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kUTUPHANEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KUTUPHANEDataSet1 kUTUPHANEDataSet1;
        private System.Windows.Forms.BindingSource yazarBindingSource;
        private KUTUPHANEDataSet1TableAdapters.yazarTableAdapter yazarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazaradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumtarihDataGridViewTextBoxColumn;
    }
}