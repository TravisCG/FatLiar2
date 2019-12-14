namespace FatLiar2
{
    partial class AddToProjectForm
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
            this.PersonCombo = new System.Windows.Forms.ComboBox();
            this.workersDataSet = new FatLiar2.WorkersDataSet();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new FatLiar2.WorkersDataSetTableAdapters.PersonsTableAdapter();
            this.ProjectCombo = new System.Windows.Forms.ComboBox();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new FatLiar2.WorkersDataSetTableAdapters.ProjectsTableAdapter();
            this.AddToProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonCombo
            // 
            this.PersonCombo.DataSource = this.personsBindingSource;
            this.PersonCombo.DisplayMember = "name";
            this.PersonCombo.FormattingEnabled = true;
            this.PersonCombo.Location = new System.Drawing.Point(68, 26);
            this.PersonCombo.Name = "PersonCombo";
            this.PersonCombo.Size = new System.Drawing.Size(186, 21);
            this.PersonCombo.TabIndex = 0;
            // 
            // workersDataSet
            // 
            this.workersDataSet.DataSetName = "WorkersDataSet";
            this.workersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.workersDataSet;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // ProjectCombo
            // 
            this.ProjectCombo.DataSource = this.projectsBindingSource;
            this.ProjectCombo.DisplayMember = "name";
            this.ProjectCombo.FormattingEnabled = true;
            this.ProjectCombo.Location = new System.Drawing.Point(68, 63);
            this.ProjectCombo.Name = "ProjectCombo";
            this.ProjectCombo.Size = new System.Drawing.Size(186, 21);
            this.ProjectCombo.TabIndex = 1;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.workersDataSet;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // AddToProject
            // 
            this.AddToProject.Location = new System.Drawing.Point(68, 129);
            this.AddToProject.Name = "AddToProject";
            this.AddToProject.Size = new System.Drawing.Size(186, 25);
            this.AddToProject.TabIndex = 2;
            this.AddToProject.Text = "Add";
            this.AddToProject.UseVisualStyleBackColor = true;
            this.AddToProject.Click += new System.EventHandler(this.AddToProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Person:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Project:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Money:";
            // 
            // MoneyTextBox
            // 
            this.MoneyTextBox.Location = new System.Drawing.Point(68, 99);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.Size = new System.Drawing.Size(186, 20);
            this.MoneyTextBox.TabIndex = 6;
            // 
            // AddToProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 185);
            this.Controls.Add(this.MoneyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddToProject);
            this.Controls.Add(this.ProjectCombo);
            this.Controls.Add(this.PersonCombo);
            this.Name = "AddToProjectForm";
            this.Text = "Add Person to Project";
            this.Load += new System.EventHandler(this.AddToProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PersonCombo;
        private WorkersDataSet workersDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private WorkersDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private System.Windows.Forms.ComboBox ProjectCombo;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private WorkersDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.Button AddToProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MoneyTextBox;
    }
}