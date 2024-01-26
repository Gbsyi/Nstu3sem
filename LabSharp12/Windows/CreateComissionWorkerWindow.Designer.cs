namespace LabSharp12.Windows
{
    partial class CreateComissionWorkerWindow
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
            label5 = new Label();
            WorkerNameTB = new TextBox();
            WorkerNameLabel = new Label();
            label1 = new Label();
            SexMaleRadio = new RadioButton();
            SexPanel = new Panel();
            SexFemaleRadio = new RadioButton();
            BaseSalaryTB = new TextBox();
            label2 = new Label();
            ComissionTB = new TextBox();
            label3 = new Label();
            SubmitBtn = new Button();
            SexPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 98);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 16;
            label5.Text = "Пол";
            // 
            // WorkerNameTB
            // 
            WorkerNameTB.Location = new Point(15, 72);
            WorkerNameTB.Name = "WorkerNameTB";
            WorkerNameTB.Size = new Size(230, 23);
            WorkerNameTB.TabIndex = 14;
            // 
            // WorkerNameLabel
            // 
            WorkerNameLabel.AutoSize = true;
            WorkerNameLabel.Location = new Point(15, 54);
            WorkerNameLabel.Name = "WorkerNameLabel";
            WorkerNameLabel.Size = new Size(31, 15);
            WorkerNameLabel.TabIndex = 13;
            WorkerNameLabel.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 12;
            label1.Text = "Добавление работника";
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
            // SexPanel
            // 
            SexPanel.Controls.Add(SexFemaleRadio);
            SexPanel.Controls.Add(SexMaleRadio);
            SexPanel.Location = new Point(15, 116);
            SexPanel.Name = "SexPanel";
            SexPanel.Size = new Size(230, 36);
            SexPanel.TabIndex = 15;
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
            // BaseSalaryTB
            // 
            BaseSalaryTB.Location = new Point(15, 173);
            BaseSalaryTB.Name = "BaseSalaryTB";
            BaseSalaryTB.Size = new Size(230, 23);
            BaseSalaryTB.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 155);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 17;
            label2.Text = "Оклад";
            // 
            // ComissionTB
            // 
            ComissionTB.Location = new Point(15, 217);
            ComissionTB.Name = "ComissionTB";
            ComissionTB.Size = new Size(230, 23);
            ComissionTB.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 199);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 19;
            label3.Text = "Процент с продаж";
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(15, 265);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(230, 43);
            SubmitBtn.TabIndex = 21;
            SubmitBtn.Text = "Добавить";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += OnSubmit;
            // 
            // CreateComissionWorkerWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 328);
            Controls.Add(SubmitBtn);
            Controls.Add(ComissionTB);
            Controls.Add(label3);
            Controls.Add(BaseSalaryTB);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(WorkerNameTB);
            Controls.Add(WorkerNameLabel);
            Controls.Add(label1);
            Controls.Add(SexPanel);
            Name = "CreateComissionWorkerWindow";
            Text = "CreateComissionWorkerWindow";
            SexPanel.ResumeLayout(false);
            SexPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox WorkerNameTB;
        private Label WorkerNameLabel;
        private Label label1;
        private RadioButton SexMaleRadio;
        private Panel SexPanel;
        private RadioButton SexFemaleRadio;
        private TextBox BaseSalaryTB;
        private Label label2;
        private TextBox ComissionTB;
        private Label label3;
        private Button SubmitBtn;
    }
}