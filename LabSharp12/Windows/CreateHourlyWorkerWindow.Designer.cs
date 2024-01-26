namespace LabSharp12.Windows
{
    partial class CreateHourlyWorkerWindow
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
            SubmitBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            StandardWorkHoursTB = new TextBox();
            SalaryPerHourTB = new TextBox();
            label3 = new Label();
            WorkerNameTB = new TextBox();
            WorkerNameLabel = new Label();
            OvertimeMultiplierTB = new TextBox();
            label4 = new Label();
            SexPanel = new Panel();
            label5 = new Label();
            SexMaleRadio = new RadioButton();
            SexFemaleRadio = new RadioButton();
            SexPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(12, 395);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(230, 43);
            SubmitBtn.TabIndex = 0;
            SubmitBtn.Text = "Добавить";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += OnSubmit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 1;
            label1.Text = "Добавление работника";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 225);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 2;
            label2.Text = "Норма отработаных часов в день";
            // 
            // StandardWorkHoursTB
            // 
            StandardWorkHoursTB.Location = new Point(12, 243);
            StandardWorkHoursTB.Name = "StandardWorkHoursTB";
            StandardWorkHoursTB.Size = new Size(230, 23);
            StandardWorkHoursTB.TabIndex = 3;
            // 
            // SalaryPerHourTB
            // 
            SalaryPerHourTB.Location = new Point(12, 190);
            SalaryPerHourTB.Name = "SalaryPerHourTB";
            SalaryPerHourTB.Size = new Size(230, 23);
            SalaryPerHourTB.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 4;
            label3.Text = "Ставка в час";
            // 
            // WorkerNameTB
            // 
            WorkerNameTB.Location = new Point(12, 72);
            WorkerNameTB.Name = "WorkerNameTB";
            WorkerNameTB.Size = new Size(230, 23);
            WorkerNameTB.TabIndex = 7;
            // 
            // WorkerNameLabel
            // 
            WorkerNameLabel.AutoSize = true;
            WorkerNameLabel.Location = new Point(12, 54);
            WorkerNameLabel.Name = "WorkerNameLabel";
            WorkerNameLabel.Size = new Size(31, 15);
            WorkerNameLabel.TabIndex = 6;
            WorkerNameLabel.Text = "Имя";
            // 
            // OvertimeMultiplierTB
            // 
            OvertimeMultiplierTB.Location = new Point(12, 294);
            OvertimeMultiplierTB.Name = "OvertimeMultiplierTB";
            OvertimeMultiplierTB.Size = new Size(230, 23);
            OvertimeMultiplierTB.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 276);
            label4.Name = "label4";
            label4.Size = new Size(146, 15);
            label4.TabIndex = 8;
            label4.Text = "Множитель переработки";
            // 
            // SexPanel
            // 
            SexPanel.Controls.Add(SexFemaleRadio);
            SexPanel.Controls.Add(SexMaleRadio);
            SexPanel.Location = new Point(12, 116);
            SexPanel.Name = "SexPanel";
            SexPanel.Size = new Size(230, 36);
            SexPanel.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 98);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 11;
            label5.Text = "Пол";
            // 
            // SexMaleRadio
            // 
            SexMaleRadio.AutoSize = true;
            SexMaleRadio.Location = new Point(3, 3);
            SexMaleRadio.Name = "SexMaleRadio";
            SexMaleRadio.Size = new Size(77, 19);
            SexMaleRadio.TabIndex = 0;
            SexMaleRadio.TabStop = true;
            SexMaleRadio.Text = "Мужской";
            SexMaleRadio.UseVisualStyleBackColor = true;
            // 
            // SexFemaleRadio
            // 
            SexFemaleRadio.AutoSize = true;
            SexFemaleRadio.Location = new Point(152, 3);
            SexFemaleRadio.Name = "SexFemaleRadio";
            SexFemaleRadio.Size = new Size(75, 19);
            SexFemaleRadio.TabIndex = 1;
            SexFemaleRadio.TabStop = true;
            SexFemaleRadio.Text = "Женский";
            SexFemaleRadio.UseVisualStyleBackColor = true;
            // 
            // CreateHourlyWorkerWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 450);
            Controls.Add(label5);
            Controls.Add(SexPanel);
            Controls.Add(OvertimeMultiplierTB);
            Controls.Add(label4);
            Controls.Add(WorkerNameTB);
            Controls.Add(WorkerNameLabel);
            Controls.Add(SalaryPerHourTB);
            Controls.Add(label3);
            Controls.Add(StandardWorkHoursTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SubmitBtn);
            Name = "CreateHourlyWorkerWindow";
            Text = "CreateHourlyWorkerWindow";
            SexPanel.ResumeLayout(false);
            SexPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitBtn;
        private Label label1;
        private Label label2;
        private TextBox StandardWorkHoursTB;
        private TextBox SalaryPerHourTB;
        private Label label3;
        private TextBox WorkerNameTB;
        private Label WorkerNameLabel;
        private TextBox OvertimeMultiplierTB;
        private Label label4;
        private Panel SexPanel;
        private RadioButton SexMaleRadio;
        private Label label5;
        private RadioButton SexFemaleRadio;
    }
}