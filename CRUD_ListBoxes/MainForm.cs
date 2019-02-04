using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_ListBoxes
{
    public partial class MainForm : Form
    {
        private int lastMatch = 0;
        List<string> result = new List<string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text.Trim();
            if (input != "")
            {
                result.Add(input);
                lbResult.Items.Clear();
                lbResult.Items.AddRange(result.ToArray());
                tbInput.Text = "";
            }
            else
            {
                MessageBox.Show("Enter valid data!");
            }
        }

        private void btnRemoveElement_Click(object sender, EventArgs e)
        {
            try
            {
                int currentIndex = lbResult.SelectedIndex;
                result.RemoveAt(currentIndex);
                lbResult.Items.RemoveAt(currentIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Enter data before removing one!");
            }
            
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            result.Clear();
            lbResult.Items.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string edit = tbInput.Text;
                int currentIndex = lbResult.SelectedIndex;
                lbResult.Items[currentIndex] = edit;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Why not enter something and select it first ????");

            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbSearch.Text;
            if (lbResult.Items.Contains(search))
            {
                MessageBox.Show("Yes you have that element in here");
            }
            else
            {
                MessageBox.Show("Nope, you don't have this element");
            }

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lbResult.Sorted = true;
        }
    }
}
