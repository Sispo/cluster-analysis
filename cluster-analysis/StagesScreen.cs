using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPI7
{
    public partial class StagesScreen : Form
    {

        public TaskService ts;
        public int currentIndex = 0;

        public StagesScreen()
        {
            InitializeComponent();
        }

        public void ShowFirst()
        {
            double[][] m = ts.snapMatrix[0];

            dataGridView.Width = (m.Length + 1) * 100 + 20;
            dataGridView.Height = (m.Length + 1) * 60 + 80;
            this.Width = dataGridView.Width + 40;
            this.Height = dataGridView.Height + 150;
            dataGridView.ColumnCount = m.Length;
            dataGridView.RowHeadersWidth = 100;

            ShowMatrix();
        }

        public void ShowMatrix()
        {
            double[][] m = ts.snapMatrix[currentIndex];
            List<List<double>> clusters = ts.snaps[currentIndex];

            dataGridView.Rows.Clear();
            for (int i = 0; i < m.Length; i++)
            {
                dataGridView.Columns[i].Width = 100;
                dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[i].Name = ts.GetStringForCluster(clusters[i]);
            }

            for (int i = 0; i < m.Length; i++)
            {
                string[] newRow = new string[m.Length];
                dataGridView.Rows.Add(newRow);
                dataGridView.Rows[dataGridView.Rows.Count - 2].Height = 50;
                dataGridView.Rows[dataGridView.Rows.Count - 2].HeaderCell.Value = ts.GetStringForCluster(clusters[i]);
                for (int j = 0; j < m.Length; j++)
                {
                    dataGridView.Rows[dataGridView.Rows.Count - 2].Cells[j].Value = Math.Round(m[i][j], 2);
                    
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {

            if (currentIndex < ts.snapMatrix.Count - 1)
            {
                currentIndex++;
            } else
            {
                currentIndex = 0;
            }
            
            ShowMatrix();
            
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
            }
            else
            {
                currentIndex = ts.snapMatrix.Count - 1;
            }

            ShowMatrix();
        }
    }
}
