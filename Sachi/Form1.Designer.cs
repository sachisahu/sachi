
namespace Sachi
{
    partial class Form1
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(29, 175);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(749, 237);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "sachi",
            "don",
            "sahu",
            "delhi"});
            this.comboBox.Location = new System.Drawing.Point(99, 47);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(305, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(488, 49);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(120, 22);
            this.txtAmount.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(636, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(383, 122);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(75, 23);
            this.btnData.TabIndex = 7;
            this.btnData.Text = "Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // dgv2
            // 
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(29, 456);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(749, 237);
            this.dgv2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 788);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dgvData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.DataGridView dgv2;
    }
}

