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
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TaskForm taskScreen = new TaskForm();
                taskScreen.objectsCount = Convert.ToInt32(objectsTextBox.Text);
                taskScreen.parametersCount = Convert.ToInt32(parametersTextBox.Text);
                taskScreen.FillGrid();
                taskScreen.SetSettings();
                taskScreen.Show();
            } catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void defaultBtn_Click(object sender, EventArgs e)
        {
            TaskForm taskScreen = new TaskForm();
            taskScreen.InitDefaults();
            taskScreen.Show();
        }
    }
}
