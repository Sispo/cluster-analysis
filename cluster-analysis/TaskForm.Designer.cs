namespace EMPI7
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.goBtn = new System.Windows.Forms.Button();
            this.clustersTextBox = new System.Windows.Forms.TextBox();
            this.parametersTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prLbl = new System.Windows.Forms.Label();
            this.extrComboBox = new System.Windows.Forms.ComboBox();
            this.euclidComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 88);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(764, 505);
            this.dataGridView.TabIndex = 0;
            // 
            // goBtn
            // 
            this.goBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.goBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBtn.ForeColor = System.Drawing.Color.White;
            this.goBtn.Location = new System.Drawing.Point(632, 18);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(145, 52);
            this.goBtn.TabIndex = 5;
            this.goBtn.Text = "GO";
            this.goBtn.UseVisualStyleBackColor = false;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // clustersTextBox
            // 
            this.clustersTextBox.Location = new System.Drawing.Point(12, 31);
            this.clustersTextBox.Name = "clustersTextBox";
            this.clustersTextBox.Size = new System.Drawing.Size(40, 33);
            this.clustersTextBox.TabIndex = 8;
            // 
            // parametersTextBox
            // 
            this.parametersTextBox.Location = new System.Drawing.Point(143, 31);
            this.parametersTextBox.Name = "parametersTextBox";
            this.parametersTextBox.Size = new System.Drawing.Size(40, 33);
            this.parametersTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Clusters";
            // 
            // prLbl
            // 
            this.prLbl.AutoSize = true;
            this.prLbl.Location = new System.Drawing.Point(192, 34);
            this.prLbl.Name = "prLbl";
            this.prLbl.Size = new System.Drawing.Size(106, 25);
            this.prLbl.TabIndex = 11;
            this.prLbl.Text = "Parameters";
            // 
            // extrComboBox
            // 
            this.extrComboBox.FormattingEnabled = true;
            this.extrComboBox.Items.AddRange(new object[] {
            "Max",
            "Min"});
            this.extrComboBox.Location = new System.Drawing.Point(312, 31);
            this.extrComboBox.Name = "extrComboBox";
            this.extrComboBox.Size = new System.Drawing.Size(86, 33);
            this.extrComboBox.TabIndex = 12;
            // 
            // euclidComboBox
            // 
            this.euclidComboBox.FormattingEnabled = true;
            this.euclidComboBox.Items.AddRange(new object[] {
            "Usual",
            "Scaled By Variance"});
            this.euclidComboBox.Location = new System.Drawing.Point(419, 31);
            this.euclidComboBox.Name = "euclidComboBox";
            this.euclidComboBox.Size = new System.Drawing.Size(193, 33);
            this.euclidComboBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Group by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Euclidean distance";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 617);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.euclidComboBox);
            this.Controls.Add(this.extrComboBox);
            this.Controls.Add(this.prLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parametersTextBox);
            this.Controls.Add(this.clustersTextBox);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TaskForm";
            this.Text = "Task Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.TextBox clustersTextBox;
        private System.Windows.Forms.TextBox parametersTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prLbl;
        private System.Windows.Forms.ComboBox extrComboBox;
        private System.Windows.Forms.ComboBox euclidComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}