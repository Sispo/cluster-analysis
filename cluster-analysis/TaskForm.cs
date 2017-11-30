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
    public partial class TaskForm : Form
    {
        public int objectsCount, parametersCount;
        public TaskForm()
        {
            InitializeComponent();
        }

        int[,] defaultMatrix = { { 190,200,185,120,156 }, { 157,180,180,145,176 }, { 160,188,195,125,180} };
        string[] defaultStudentNames = { "John", "Michael", "Leon", "Steve", "Eve"};

        public void InitDefaults()
        {
            parametersCount = 3;
            objectsCount = 5;

            SetSettings();
            FillGrid();

            dataGridView.TopLeftHeaderCell.Value = "Student/Test";
            dataGridView.Columns[0].Name = "Ukrainian";
            dataGridView.Columns[1].Name = "Math";
            dataGridView.Columns[2].Name = "English";

            for (int j = 0; j < objectsCount; j++)
            {
                dataGridView.Rows[j].HeaderCell.Value = defaultStudentNames[j];
            }

            for (int i = 0; i < parametersCount; i++)
            {
                for(int j = 0; j < objectsCount; j++)
                {
                    dataGridView.Rows[j].Cells[i].Value = defaultMatrix[i,j];
                }
            }
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            int[][] matrix = GetData();
            int clBound = 0;
            if (clustersTextBox.Text != "")
            {
                clBound = Convert.ToInt32(clustersTextBox.Text);
                clBound = matrix.Length >= clBound ? clBound : 0;
            }
            int prBound = 0;
            if (parametersTextBox.Text != "")
            {
                prBound = Convert.ToInt32(parametersTextBox.Text);
            }

            bool toMax = extrComboBox.SelectedIndex == 0;
            bool isEuclidDistanceUsual = euclidComboBox.SelectedIndex == 0;

            TaskService ts = new TaskService();
            ts.initialMatrix = matrix;
            ts.GetDistanceMatrix();
            ts.clustersBound = clBound;
            ts.parametersBound = prBound;
            ts.toMax = toMax;
            ts.isEuclidDistanceUsual = isEuclidDistanceUsual;

            ResultsScreen rs = new ResultsScreen();
            rs.ts = ts;
            rs.Show();
            rs.ShowResults();
        }

        int[][] GetData()
        {
            try
            {
                int[][] matrix = new int[parametersCount][];
                for (int i = 0; i < parametersCount; i++)
                {
                    matrix[i] = new int[objectsCount];
                    for (int j = 0; j < objectsCount; j++)
                    {
                        matrix[i][j] = Convert.ToInt32(dataGridView.Rows[j].Cells[i].Value.ToString());
                    }
                }
                return matrix;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return null;
            }
        }

        public void SetSettings()
        {
            extrComboBox.SelectedIndex = 1;
            euclidComboBox.SelectedIndex = 0;
        }

        public void FillGrid()
        {
            dataGridView.Width = (parametersCount + 1) * 120 + 20 > 780 ? (parametersCount + 1) * 120 + 20 : 780;
            dataGridView.Height = (objectsCount + 1) * 50 + 80;
            this.Width = dataGridView.Width + 40 > 780 ? dataGridView.Width + 40 : 780;
            this.Height = dataGridView.Height + 150;
            dataGridView.ColumnCount = parametersCount;
            dataGridView.RowHeadersWidth = 150;
            for (int i = 0; i < parametersCount; i++)
            {
                dataGridView.Columns[i].Width = 120;
                dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[i].Name = "Parameter " + (i + 1).ToString();
            }

            for (int i = 0; i < objectsCount; i++)
            {
                string[] row = new string[parametersCount];
                dataGridView.Rows.Add(row);
                dataGridView.Rows[i].HeaderCell.Value = "Object " + (i + 1).ToString();
                dataGridView.Rows[i].Height = 50;
            }
        }
    }
}
