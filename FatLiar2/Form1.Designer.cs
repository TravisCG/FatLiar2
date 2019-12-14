namespace FatLiar2
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPerson = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonListBox = new System.Windows.Forms.ListBox();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersDataSet = new FatLiar2.WorkersDataSet();
            this.tabProject = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectListBox = new System.Windows.Forms.ListBox();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabDates = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.PersonComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateListBox = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.CalendarMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addExtraWorkdayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.festivalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GenerateProjectReport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProjectRiportEndDate = new System.Windows.Forms.DateTimePicker();
            this.ProjectRiportStartDate = new System.Windows.Forms.DateTimePicker();
            this.ProjectComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GeneratePersonRiport = new System.Windows.Forms.Button();
            this.PersonRiportEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PersonRiportStartDate = new System.Windows.Forms.DateTimePicker();
            this.PersonComboBox2 = new System.Windows.Forms.ComboBox();
            this.personsTableAdapter = new FatLiar2.WorkersDataSetTableAdapters.PersonsTableAdapter();
            this.projectsTableAdapter = new FatLiar2.WorkersDataSetTableAdapters.ProjectsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).BeginInit();
            this.tabProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.tabDates.SuspendLayout();
            this.CalendarMenu.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPerson);
            this.tabControl1.Controls.Add(this.tabProject);
            this.tabControl1.Controls.Add(this.tabDates);
            this.tabControl1.Controls.Add(this.tabReport);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPerson
            // 
            this.tabPerson.Controls.Add(this.button4);
            this.tabPerson.Controls.Add(this.button2);
            this.tabPerson.Controls.Add(this.button1);
            this.tabPerson.Controls.Add(this.label1);
            this.tabPerson.Controls.Add(this.PersonListBox);
            this.tabPerson.Location = new System.Drawing.Point(4, 22);
            this.tabPerson.Name = "tabPerson";
            this.tabPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerson.Size = new System.Drawing.Size(523, 305);
            this.tabPerson.TabIndex = 0;
            this.tabPerson.Text = "Persons";
            this.tabPerson.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "Modify person";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add person to project";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add new person";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Persons:";
            // 
            // PersonListBox
            // 
            this.PersonListBox.DataSource = this.personsBindingSource;
            this.PersonListBox.DisplayMember = "name";
            this.PersonListBox.FormattingEnabled = true;
            this.PersonListBox.Location = new System.Drawing.Point(8, 35);
            this.PersonListBox.Name = "PersonListBox";
            this.PersonListBox.Size = new System.Drawing.Size(140, 264);
            this.PersonListBox.TabIndex = 0;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.workersDataSet;
            // 
            // workersDataSet
            // 
            this.workersDataSet.DataSetName = "WorkersDataSet";
            this.workersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabProject
            // 
            this.tabProject.Controls.Add(this.button3);
            this.tabProject.Controls.Add(this.label2);
            this.tabProject.Controls.Add(this.ProjectListBox);
            this.tabProject.Location = new System.Drawing.Point(4, 22);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabProject.Size = new System.Drawing.Size(523, 305);
            this.tabProject.TabIndex = 1;
            this.tabProject.Text = "Projects";
            this.tabProject.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add new project";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Projects:";
            // 
            // ProjectListBox
            // 
            this.ProjectListBox.DataSource = this.projectsBindingSource;
            this.ProjectListBox.DisplayMember = "name";
            this.ProjectListBox.FormattingEnabled = true;
            this.ProjectListBox.Location = new System.Drawing.Point(8, 35);
            this.ProjectListBox.Name = "ProjectListBox";
            this.ProjectListBox.Size = new System.Drawing.Size(140, 264);
            this.ProjectListBox.TabIndex = 0;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.workersDataSet;
            // 
            // tabDates
            // 
            this.tabDates.Controls.Add(this.button5);
            this.tabDates.Controls.Add(this.PersonComboBox);
            this.tabDates.Controls.Add(this.label3);
            this.tabDates.Controls.Add(this.DateListBox);
            this.tabDates.Controls.Add(this.monthCalendar1);
            this.tabDates.Location = new System.Drawing.Point(4, 22);
            this.tabDates.Name = "tabDates";
            this.tabDates.Size = new System.Drawing.Size(523, 305);
            this.tabDates.TabIndex = 2;
            this.tabDates.Text = "Workdays";
            this.tabDates.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 248);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 25);
            this.button5.TabIndex = 4;
            this.button5.Text = "His/her holiday";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PersonComboBox
            // 
            this.PersonComboBox.DataSource = this.personsBindingSource;
            this.PersonComboBox.DisplayMember = "name";
            this.PersonComboBox.FormattingEnabled = true;
            this.PersonComboBox.Location = new System.Drawing.Point(24, 221);
            this.PersonComboBox.Name = "PersonComboBox";
            this.PersonComboBox.Size = new System.Drawing.Size(175, 21);
            this.PersonComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Events:";
            // 
            // DateListBox
            // 
            this.DateListBox.FormattingEnabled = true;
            this.DateListBox.Location = new System.Drawing.Point(237, 51);
            this.DateListBox.Name = "DateListBox";
            this.DateListBox.Size = new System.Drawing.Size(265, 160);
            this.DateListBox.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ContextMenuStrip = this.CalendarMenu;
            this.monthCalendar1.Location = new System.Drawing.Point(22, 52);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // CalendarMenu
            // 
            this.CalendarMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExtraWorkdayToolStripMenuItem,
            this.festivalToolStripMenuItem});
            this.CalendarMenu.Name = "CalendarMenu";
            this.CalendarMenu.Size = new System.Drawing.Size(173, 48);
            // 
            // addExtraWorkdayToolStripMenuItem
            // 
            this.addExtraWorkdayToolStripMenuItem.Name = "addExtraWorkdayToolStripMenuItem";
            this.addExtraWorkdayToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addExtraWorkdayToolStripMenuItem.Text = "Add extra workday";
            this.addExtraWorkdayToolStripMenuItem.Click += new System.EventHandler(this.addExtraWorkdayToolStripMenuItem_Click);
            // 
            // festivalToolStripMenuItem
            // 
            this.festivalToolStripMenuItem.Name = "festivalToolStripMenuItem";
            this.festivalToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.festivalToolStripMenuItem.Text = "Festival";
            this.festivalToolStripMenuItem.Click += new System.EventHandler(this.festivalToolStripMenuItem_Click);
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.groupBox2);
            this.tabReport.Controls.Add(this.groupBox1);
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Size = new System.Drawing.Size(523, 305);
            this.tabReport.TabIndex = 3;
            this.tabReport.Text = "Reports";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GenerateProjectReport);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ProjectRiportEndDate);
            this.groupBox2.Controls.Add(this.ProjectRiportStartDate);
            this.groupBox2.Controls.Add(this.ProjectComboBox);
            this.groupBox2.Location = new System.Drawing.Point(266, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project report";
            // 
            // GenerateProjectReport
            // 
            this.GenerateProjectReport.Location = new System.Drawing.Point(45, 246);
            this.GenerateProjectReport.Name = "GenerateProjectReport";
            this.GenerateProjectReport.Size = new System.Drawing.Size(170, 25);
            this.GenerateProjectReport.TabIndex = 5;
            this.GenerateProjectReport.Text = "Generate";
            this.GenerateProjectReport.UseVisualStyleBackColor = true;
            this.GenerateProjectReport.Click += new System.EventHandler(this.GenerateProjectReport_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "From:";
            // 
            // ProjectRiportEndDate
            // 
            this.ProjectRiportEndDate.Location = new System.Drawing.Point(45, 115);
            this.ProjectRiportEndDate.Name = "ProjectRiportEndDate";
            this.ProjectRiportEndDate.Size = new System.Drawing.Size(170, 20);
            this.ProjectRiportEndDate.TabIndex = 2;
            // 
            // ProjectRiportStartDate
            // 
            this.ProjectRiportStartDate.Location = new System.Drawing.Point(45, 70);
            this.ProjectRiportStartDate.Name = "ProjectRiportStartDate";
            this.ProjectRiportStartDate.Size = new System.Drawing.Size(170, 20);
            this.ProjectRiportStartDate.TabIndex = 1;
            // 
            // ProjectComboBox
            // 
            this.ProjectComboBox.DataSource = this.projectsBindingSource;
            this.ProjectComboBox.DisplayMember = "name";
            this.ProjectComboBox.FormattingEnabled = true;
            this.ProjectComboBox.Location = new System.Drawing.Point(29, 25);
            this.ProjectComboBox.Name = "ProjectComboBox";
            this.ProjectComboBox.Size = new System.Drawing.Size(190, 21);
            this.ProjectComboBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GeneratePersonRiport);
            this.groupBox1.Controls.Add(this.PersonRiportEndDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PersonRiportStartDate);
            this.groupBox1.Controls.Add(this.PersonComboBox2);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person report";
            // 
            // GeneratePersonRiport
            // 
            this.GeneratePersonRiport.Location = new System.Drawing.Point(45, 246);
            this.GeneratePersonRiport.Name = "GeneratePersonRiport";
            this.GeneratePersonRiport.Size = new System.Drawing.Size(170, 25);
            this.GeneratePersonRiport.TabIndex = 5;
            this.GeneratePersonRiport.Text = "Generate";
            this.GeneratePersonRiport.UseVisualStyleBackColor = true;
            this.GeneratePersonRiport.Click += new System.EventHandler(this.GeneratePersonRiport_Click);
            // 
            // PersonRiportEndDate
            // 
            this.PersonRiportEndDate.Location = new System.Drawing.Point(45, 115);
            this.PersonRiportEndDate.Name = "PersonRiportEndDate";
            this.PersonRiportEndDate.Size = new System.Drawing.Size(170, 20);
            this.PersonRiportEndDate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "From:";
            // 
            // PersonRiportStartDate
            // 
            this.PersonRiportStartDate.Location = new System.Drawing.Point(45, 70);
            this.PersonRiportStartDate.Name = "PersonRiportStartDate";
            this.PersonRiportStartDate.Size = new System.Drawing.Size(170, 20);
            this.PersonRiportStartDate.TabIndex = 1;
            // 
            // PersonComboBox2
            // 
            this.PersonComboBox2.DataSource = this.personsBindingSource;
            this.PersonComboBox2.DisplayMember = "name";
            this.PersonComboBox2.FormattingEnabled = true;
            this.PersonComboBox2.Location = new System.Drawing.Point(29, 25);
            this.PersonComboBox2.Name = "PersonComboBox2";
            this.PersonComboBox2.Size = new System.Drawing.Size(190, 21);
            this.PersonComboBox2.TabIndex = 0;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 346);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FatLiar2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPerson.ResumeLayout(false);
            this.tabPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).EndInit();
            this.tabProject.ResumeLayout(false);
            this.tabProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.tabDates.ResumeLayout(false);
            this.tabDates.PerformLayout();
            this.CalendarMenu.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPerson;
        private System.Windows.Forms.ListBox PersonListBox;
        private System.Windows.Forms.TabPage tabProject;
        private System.Windows.Forms.TabPage tabDates;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ProjectListBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private WorkersDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        public WorkersDataSet workersDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private WorkersDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox DateListBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ContextMenuStrip CalendarMenu;
        private System.Windows.Forms.ToolStripMenuItem addExtraWorkdayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem festivalToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox PersonComboBox;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ProjectComboBox;
        private System.Windows.Forms.ComboBox PersonComboBox2;
        private System.Windows.Forms.Button GenerateProjectReport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ProjectRiportEndDate;
        private System.Windows.Forms.DateTimePicker ProjectRiportStartDate;
        private System.Windows.Forms.Button GeneratePersonRiport;
        private System.Windows.Forms.DateTimePicker PersonRiportEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker PersonRiportStartDate;
    }
}

