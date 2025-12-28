using System;
using System.Windows.Forms;

namespace LabelTextBoxButtonTest
{
    public partial class LabelTextBoxButtonTestForm : Form
    {
        public LabelTextBoxButtonTestForm()
        {
            InitializeComponent();
        }

        private void displayPasswordButton_Click(object sender, EventArgs e)
        {
            displayPasswordLabel.Text = inputPasswordTextBox.Text;
        }
    }
}
