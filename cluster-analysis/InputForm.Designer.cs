namespace EMPI7
{
    partial class InputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.objectsTextBox = new System.Windows.Forms.TextBox();
            this.parametersTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.proceedBtn = new System.Windows.Forms.Button();
            this.defaultBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // objectsTextBox
            // 
            this.objectsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.objectsTextBox.Location = new System.Drawing.Point(242, 19);
            this.objectsTextBox.Name = "objectsTextBox";
            this.objectsTextBox.Size = new System.Drawing.Size(35, 33);
            this.objectsTextBox.TabIndex = 0;
            // 
            // parametersTextBox
            // 
            this.parametersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.parametersTextBox.Location = new System.Drawing.Point(242, 66);
            this.parametersTextBox.Name = "parametersTextBox";
            this.parametersTextBox.Size = new System.Drawing.Size(35, 33);
            this.parametersTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Objects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Parameters";
            // 
            // proceedBtn
            // 
            this.proceedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proceedBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.proceedBtn.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedBtn.ForeColor = System.Drawing.Color.White;
            this.proceedBtn.Location = new System.Drawing.Point(12, 116);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(265, 54);
            this.proceedBtn.TabIndex = 4;
            this.proceedBtn.Text = "PROCEED";
            this.proceedBtn.UseVisualStyleBackColor = false;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // defaultBtn
            // 
            this.defaultBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultBtn.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultBtn.Location = new System.Drawing.Point(12, 176);
            this.defaultBtn.Name = "defaultBtn";
            this.defaultBtn.Size = new System.Drawing.Size(265, 54);
            this.defaultBtn.TabIndex = 5;
            this.defaultBtn.Text = "DEFAULT";
            this.defaultBtn.UseVisualStyleBackColor = true;
            this.defaultBtn.Click += new System.EventHandler(this.defaultBtn_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 242);
            this.Controls.Add(this.defaultBtn);
            this.Controls.Add(this.proceedBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parametersTextBox);
            this.Controls.Add(this.objectsTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InputForm";
            this.Text = "Input Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox objectsTextBox;
        private System.Windows.Forms.TextBox parametersTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button proceedBtn;
        private System.Windows.Forms.Button defaultBtn;
    }
}

