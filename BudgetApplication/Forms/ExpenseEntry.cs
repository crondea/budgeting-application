﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApplication.Forms
{
    public partial class ExpenseEntry : Form
    {
        public ExpenseEntry()
        {
            InitializeComponent();
        }

        private void buttonExpenseConfirm_Click(object sender, EventArgs e)
        {
            // We need to save the values given in the form, but only if they are all given
            string expenseName = string.Empty;
            decimal expenseAmount = decimal.Zero;
            string reportName = string.Empty;

            if((this.textBoxExpenseName.Text == string.Empty) && (this.textBoxExpenseAmount.Text == string.Empty) && (this.comboBoxAssociatedReport.Text == string.Empty))
            {
                MessageBox.Show("All values must be provided.");
                return;
            }
            else
            {
                // Save the values
                expenseName = this.textBoxExpenseName.Text;
                expenseAmount = Convert.ToDecimal(this.textBoxExpenseAmount.Text);
                reportName = this.comboBoxAssociatedReport.Text;



            }
        }

        private void buttonExpenseCancel_Click(object sender, EventArgs e)
        {
            // Cancelling the form, so close it
            this.Close();
        }
    }
}
