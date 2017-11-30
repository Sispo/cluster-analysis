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
    public partial class ResultsScreen : Form
    {
        public TaskService ts;
        public ResultsScreen()
        {
            InitializeComponent();
        }

        public void ShowResults()
        {
            listBox.Items.Clear();

            List<List<List<double>>> snaps = ts.Run();

            foreach (List<List<double>> snap in snaps)
            {
                listBox.Items.Add(ts.GetStringForClusters(snap));
            }
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            StagesScreen st = new StagesScreen();
            st.ts = ts;
            st.ShowFirst();
            st.Show();
        }
    }
}
