namespace LabSharp12.Windows
{
    partial class CreateCompanyWindow
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
            Label label2;
            label1 = new Label();
            NameTB = new TextBox();
            CreateBtn = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 30);
            label1.TabIndex = 0;
            label1.Text = "Создание компании";
            // 
            // NameTB
            // 
            NameTB.Location = new Point(12, 79);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(349, 23);
            NameTB.TabIndex = 2;
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(12, 141);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(349, 35);
            CreateBtn.TabIndex = 3;
            CreateBtn.Text = "Создать";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += OnSubmit;
            // 
            // CreateCompanyWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 194);
            Controls.Add(CreateBtn);
            Controls.Add(NameTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateCompanyWindow";
            Text = "CreateCompanyWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameTB;
        private Button CreateBtn;
    }
}