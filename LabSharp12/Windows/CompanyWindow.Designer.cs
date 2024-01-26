namespace LabSharp12.Windows
{
    partial class CompanyWindow
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
            label1 = new Label();
            CompanyNameLabel = new Label();
            label2 = new Label();
            WorkersDataGrid = new DataGridView();
            WorkerName = new DataGridViewTextBoxColumn();
            WorkerType = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            CurrentSalary = new DataGridViewTextBoxColumn();
            Действия = new DataGridViewButtonColumn();
            label3 = new Label();
            label4 = new Label();
            DateLabel = new Label();
            DayOfWeekLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            SimulateOneDayWorkBtn = new Button();
            LogTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)WorkersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 11);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 0;
            label1.Text = "Компания:";
            // 
            // CompanyNameLabel
            // 
            CompanyNameLabel.AutoSize = true;
            CompanyNameLabel.Font = new Font("Segoe UI", 13F);
            CompanyNameLabel.Location = new Point(137, 9);
            CompanyNameLabel.Name = "CompanyNameLabel";
            CompanyNameLabel.Size = new Size(20, 25);
            CompanyNameLabel.TabIndex = 1;
            CompanyNameLabel.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 2;
            label2.Text = "Сотрудники:";
            // 
            // WorkersDataGrid
            // 
            WorkersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WorkersDataGrid.Columns.AddRange(new DataGridViewColumn[] { WorkerName, WorkerType, Description, CurrentSalary, Действия });
            WorkersDataGrid.Location = new Point(12, 149);
            WorkersDataGrid.Name = "WorkersDataGrid";
            WorkersDataGrid.Size = new Size(724, 364);
            WorkersDataGrid.TabIndex = 3;
            WorkersDataGrid.CellContentClick += WorkersDataGrid_CellContentClick;
            // 
            // WorkerName
            // 
            WorkerName.HeaderText = "Имя";
            WorkerName.Name = "WorkerName";
            // 
            // WorkerType
            // 
            WorkerType.HeaderText = "Форма оплаты труда";
            WorkerType.Name = "WorkerType";
            WorkerType.Width = 150;
            // 
            // Description
            // 
            Description.HeaderText = "Описание";
            Description.Name = "Description";
            Description.Width = 200;
            // 
            // CurrentSalary
            // 
            CurrentSalary.HeaderText = "Заработано за период";
            CurrentSalary.Name = "CurrentSalary";
            // 
            // Действия
            // 
            Действия.HeaderText = "RemoveAction";
            Действия.Name = "Действия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(66, 44);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 4;
            label3.Text = "День:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 77);
            label4.Name = "label4";
            label4.Size = new Size(122, 23);
            label4.TabIndex = 5;
            label4.Text = "День недели:";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 13F);
            DateLabel.Location = new Point(137, 44);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(20, 25);
            DateLabel.TabIndex = 6;
            DateLabel.Text = "*";
            // 
            // DayOfWeekLabel
            // 
            DayOfWeekLabel.AutoSize = true;
            DayOfWeekLabel.Font = new Font("Segoe UI", 13F);
            DayOfWeekLabel.Location = new Point(137, 77);
            DayOfWeekLabel.Name = "DayOfWeekLabel";
            DayOfWeekLabel.Size = new Size(20, 25);
            DayOfWeekLabel.TabIndex = 7;
            DayOfWeekLabel.Text = "*";
            // 
            // button1
            // 
            button1.Location = new Point(742, 149);
            button1.Name = "button1";
            button1.Size = new Size(207, 43);
            button1.TabIndex = 8;
            button1.Text = "Добавить сотрудника с почасовой формой оплаты труда";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateHourlyWorker;
            // 
            // button2
            // 
            button2.Location = new Point(742, 198);
            button2.Name = "button2";
            button2.Size = new Size(207, 43);
            button2.TabIndex = 9;
            button2.Text = "Добавить сотрудника с комиссионной формой оплаты труда";
            button2.UseVisualStyleBackColor = true;
            button2.Click += CreateComissionWorker;
            // 
            // SimulateOneDayWorkBtn
            // 
            SimulateOneDayWorkBtn.Location = new Point(742, 466);
            SimulateOneDayWorkBtn.Name = "SimulateOneDayWorkBtn";
            SimulateOneDayWorkBtn.Size = new Size(207, 47);
            SimulateOneDayWorkBtn.TabIndex = 10;
            SimulateOneDayWorkBtn.Text = "Работать 1 день";
            SimulateOneDayWorkBtn.UseVisualStyleBackColor = true;
            SimulateOneDayWorkBtn.Click += SimulateOneDay;
            // 
            // LogTB
            // 
            LogTB.Location = new Point(540, 9);
            LogTB.Multiline = true;
            LogTB.Name = "LogTB";
            LogTB.ReadOnly = true;
            LogTB.ScrollBars = ScrollBars.Both;
            LogTB.Size = new Size(409, 129);
            LogTB.TabIndex = 11;
            // 
            // CompanyWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 528);
            Controls.Add(LogTB);
            Controls.Add(SimulateOneDayWorkBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(DayOfWeekLabel);
            Controls.Add(DateLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(WorkersDataGrid);
            Controls.Add(label2);
            Controls.Add(CompanyNameLabel);
            Controls.Add(label1);
            Name = "CompanyWindow";
            Text = "CompanyWindow";
            FormClosing += OnClosing;
            Load += OnLoaded;
            ((System.ComponentModel.ISupportInitialize)WorkersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label CompanyNameLabel;
        private Label label2;
        private DataGridView WorkersDataGrid;
        private Label label3;
        private Label label4;
        private Label DateLabel;
        private Label DayOfWeekLabel;
        private Button button1;
        private Button button2;
        private Button SimulateOneDayWorkBtn;
        private TextBox LogTB;
        private DataGridViewTextBoxColumn WorkerName;
        private DataGridViewTextBoxColumn WorkerType;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn CurrentSalary;
        private DataGridViewButtonColumn Действия;
    }
}