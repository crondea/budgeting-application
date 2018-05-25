using BudgetApplication.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApplication
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void enterExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load the expense entry form for user input
            ExpenseEntry expenseForm = new ExpenseEntry();
            expenseForm.Show();
        }
    }
}
