namespace BudgetApplication
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.budgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savingPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetPlanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.savingPlanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.budgetToolStripMenuItem,
            this.enterExpenseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // budgetToolStripMenuItem
            // 
            this.budgetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.budgetToolStripMenuItem.Name = "budgetToolStripMenuItem";
            this.budgetToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.budgetToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.budgetPlanToolStripMenuItem,
            this.savingPlanToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // budgetPlanToolStripMenuItem
            // 
            this.budgetPlanToolStripMenuItem.Name = "budgetPlanToolStripMenuItem";
            this.budgetPlanToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.budgetPlanToolStripMenuItem.Text = "Budget plan";
            // 
            // savingPlanToolStripMenuItem
            // 
            this.savingPlanToolStripMenuItem.Name = "savingPlanToolStripMenuItem";
            this.savingPlanToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.savingPlanToolStripMenuItem.Text = "Saving plan";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.budgetPlanToolStripMenuItem1,
            this.savingPlanToolStripMenuItem1});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // budgetPlanToolStripMenuItem1
            // 
            this.budgetPlanToolStripMenuItem1.Name = "budgetPlanToolStripMenuItem1";
            this.budgetPlanToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.budgetPlanToolStripMenuItem1.Text = "Budget plan";
            // 
            // savingPlanToolStripMenuItem1
            // 
            this.savingPlanToolStripMenuItem1.Name = "savingPlanToolStripMenuItem1";
            this.savingPlanToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.savingPlanToolStripMenuItem1.Text = "Saving plan";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentToolStripMenuItem,
            this.allToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.currentToolStripMenuItem.Text = "Current";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentTabToolStripMenuItem,
            this.allTabsToolStripMenuItem});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // currentTabToolStripMenuItem
            // 
            this.currentTabToolStripMenuItem.Name = "currentTabToolStripMenuItem";
            this.currentTabToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.currentTabToolStripMenuItem.Text = "Current tab";
            // 
            // allTabsToolStripMenuItem
            // 
            this.allTabsToolStripMenuItem.Name = "allTabsToolStripMenuItem";
            this.allTabsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.allTabsToolStripMenuItem.Text = "All tabs";
            // 
            // enterExpenseToolStripMenuItem
            // 
            this.enterExpenseToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.enterExpenseToolStripMenuItem.Name = "enterExpenseToolStripMenuItem";
            this.enterExpenseToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.enterExpenseToolStripMenuItem.Text = "Enter Expense";
            this.enterExpenseToolStripMenuItem.Click += new System.EventHandler(this.enterExpenseToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(509, 462);
            this.tabControl.TabIndex = 22;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(509, 486);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(525, 525);
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem budgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem budgetPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savingPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetPlanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem savingPlanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterExpenseToolStripMenuItem;
    }
}

