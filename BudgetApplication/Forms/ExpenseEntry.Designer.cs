namespace BudgetApplication.Forms
{
    partial class ExpenseEntry
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
            this.components = new System.ComponentModel.Container();
            this.labelExpenseName = new System.Windows.Forms.Label();
            this.labelExpenseAmount = new System.Windows.Forms.Label();
            this.labelAssosciatedReport = new System.Windows.Forms.Label();
            this.comboBoxAssociatedReport = new System.Windows.Forms.ComboBox();
            this.textBoxExpenseName = new System.Windows.Forms.TextBox();
            this.textBoxExpenseAmount = new System.Windows.Forms.TextBox();
            this.labelExpenseInstructions = new System.Windows.Forms.Label();
            this.buttonExpenseConfirm = new System.Windows.Forms.Button();
            this.buttonExpenseCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExpenseName
            // 
            this.labelExpenseName.AutoSize = true;
            this.labelExpenseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpenseName.Location = new System.Drawing.Point(15, 35);
            this.labelExpenseName.Name = "labelExpenseName";
            this.labelExpenseName.Size = new System.Drawing.Size(117, 16);
            this.labelExpenseName.TabIndex = 0;
            this.labelExpenseName.Text = "Expense Name:";
            // 
            // labelExpenseAmount
            // 
            this.labelExpenseAmount.AutoSize = true;
            this.labelExpenseAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpenseAmount.Location = new System.Drawing.Point(15, 70);
            this.labelExpenseAmount.Name = "labelExpenseAmount";
            this.labelExpenseAmount.Size = new System.Drawing.Size(127, 16);
            this.labelExpenseAmount.TabIndex = 1;
            this.labelExpenseAmount.Text = "Expense Amount:";
            // 
            // labelAssosciatedReport
            // 
            this.labelAssosciatedReport.AutoSize = true;
            this.labelAssosciatedReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssosciatedReport.Location = new System.Drawing.Point(15, 101);
            this.labelAssosciatedReport.Name = "labelAssosciatedReport";
            this.labelAssosciatedReport.Size = new System.Drawing.Size(141, 16);
            this.labelAssosciatedReport.TabIndex = 2;
            this.labelAssosciatedReport.Text = "Associated Report:";
            // 
            // comboBoxAssociatedReport
            // 
            this.comboBoxAssociatedReport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAssociatedReport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAssociatedReport.FormattingEnabled = true;
            this.comboBoxAssociatedReport.Location = new System.Drawing.Point(163, 100);
            this.comboBoxAssociatedReport.Name = "comboBoxAssociatedReport";
            this.comboBoxAssociatedReport.Size = new System.Drawing.Size(147, 21);
            this.comboBoxAssociatedReport.TabIndex = 3;
            // 
            // textBoxExpenseName
            // 
            this.textBoxExpenseName.Location = new System.Drawing.Point(163, 34);
            this.textBoxExpenseName.Name = "textBoxExpenseName";
            this.textBoxExpenseName.Size = new System.Drawing.Size(100, 20);
            this.textBoxExpenseName.TabIndex = 4;
            this.textBoxExpenseName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxExpenseName_Validating);
            this.textBoxExpenseName.Validated += new System.EventHandler(this.textBoxExpenseName_Validated);
            // 
            // textBoxExpenseAmount
            // 
            this.textBoxExpenseAmount.Location = new System.Drawing.Point(163, 69);
            this.textBoxExpenseAmount.Name = "textBoxExpenseAmount";
            this.textBoxExpenseAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxExpenseAmount.TabIndex = 5;
            // 
            // labelExpenseInstructions
            // 
            this.labelExpenseInstructions.AutoSize = true;
            this.labelExpenseInstructions.Location = new System.Drawing.Point(12, 9);
            this.labelExpenseInstructions.Name = "labelExpenseInstructions";
            this.labelExpenseInstructions.Size = new System.Drawing.Size(384, 13);
            this.labelExpenseInstructions.TabIndex = 6;
            this.labelExpenseInstructions.Text = "Please enter the expense, the amount, and the report you would like to add it to." +
    "";
            // 
            // buttonExpenseConfirm
            // 
            this.buttonExpenseConfirm.Location = new System.Drawing.Point(133, 141);
            this.buttonExpenseConfirm.Name = "buttonExpenseConfirm";
            this.buttonExpenseConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonExpenseConfirm.TabIndex = 7;
            this.buttonExpenseConfirm.Text = "Confirm";
            this.buttonExpenseConfirm.UseVisualStyleBackColor = true;
            this.buttonExpenseConfirm.Click += new System.EventHandler(this.buttonExpenseConfirm_Click);
            // 
            // buttonExpenseCancel
            // 
            this.buttonExpenseCancel.Location = new System.Drawing.Point(235, 141);
            this.buttonExpenseCancel.Name = "buttonExpenseCancel";
            this.buttonExpenseCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonExpenseCancel.TabIndex = 8;
            this.buttonExpenseCancel.Text = "Cancel";
            this.buttonExpenseCancel.UseVisualStyleBackColor = true;
            this.buttonExpenseCancel.Click += new System.EventHandler(this.buttonExpenseCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ExpenseEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 186);
            this.Controls.Add(this.buttonExpenseCancel);
            this.Controls.Add(this.buttonExpenseConfirm);
            this.Controls.Add(this.labelExpenseInstructions);
            this.Controls.Add(this.textBoxExpenseAmount);
            this.Controls.Add(this.textBoxExpenseName);
            this.Controls.Add(this.comboBoxAssociatedReport);
            this.Controls.Add(this.labelAssosciatedReport);
            this.Controls.Add(this.labelExpenseAmount);
            this.Controls.Add(this.labelExpenseName);
            this.MaximumSize = new System.Drawing.Size(423, 225);
            this.MinimumSize = new System.Drawing.Size(423, 225);
            this.Name = "ExpenseEntry";
            this.Text = "Expense Entry";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExpenseName;
        private System.Windows.Forms.Label labelExpenseAmount;
        private System.Windows.Forms.Label labelAssosciatedReport;
        private System.Windows.Forms.ComboBox comboBoxAssociatedReport;
        private System.Windows.Forms.TextBox textBoxExpenseName;
        private System.Windows.Forms.TextBox textBoxExpenseAmount;
        private System.Windows.Forms.Label labelExpenseInstructions;
        private System.Windows.Forms.Button buttonExpenseConfirm;
        private System.Windows.Forms.Button buttonExpenseCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}