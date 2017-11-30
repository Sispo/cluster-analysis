namespace EMPI7
{
    partial class ResultsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsScreen));
            this.listBox = new System.Windows.Forms.ListBox();
            this.clustersLbl = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 21;
            this.listBox.Location = new System.Drawing.Point(18, 57);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(481, 319);
            this.listBox.TabIndex = 8;
            // 
            // clustersLbl
            // 
            this.clustersLbl.AutoSize = true;
            this.clustersLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clustersLbl.Location = new System.Drawing.Point(14, 20);
            this.clustersLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clustersLbl.Name = "clustersLbl";
            this.clustersLbl.Size = new System.Drawing.Size(66, 21);
            this.clustersLbl.TabIndex = 9;
            this.clustersLbl.Text = "Clusters";
            // 
            // goBtn
            // 
            this.goBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.goBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBtn.ForeColor = System.Drawing.Color.White;
            this.goBtn.Location = new System.Drawing.Point(18, 389);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(481, 52);
            this.goBtn.TabIndex = 10;
            this.goBtn.Text = "SHOW STAGES";
            this.goBtn.UseVisualStyleBackColor = false;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // ResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 453);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.clustersLbl);
            this.Controls.Add(this.listBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ResultsScreen";
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label clustersLbl;
        private System.Windows.Forms.Button goBtn;
    }
}