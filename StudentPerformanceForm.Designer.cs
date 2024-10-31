namespace PW5SPP
{
    partial class StudentPerformanceForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SerialNumber = new TextBox();
            FullName = new TextBox();
            AverageMark = new TextBox();
            SerialNumberLabel = new Label();
            FullNameLabel = new Label();
            AverageMarkLabel = new Label();
            SaveButton = new Button();
            ReadButton = new Button();
            SuspendLayout();
            // 
            // SerialNumber
            // 
            SerialNumber.Location = new Point(145, 12);
            SerialNumber.Name = "SerialNumber";
            SerialNumber.Size = new Size(125, 25);
            SerialNumber.TabIndex = 0;
            // 
            // FullName
            // 
            FullName.Location = new Point(145, 54);
            FullName.Name = "FullName";
            FullName.Size = new Size(125, 25);
            FullName.TabIndex = 1;
            // 
            // AverageMark
            // 
            AverageMark.Location = new Point(145, 96);
            AverageMark.Name = "AverageMark";
            AverageMark.Size = new Size(125, 25);
            AverageMark.TabIndex = 2;
            // 
            // SerialNumberLabel
            // 
            SerialNumberLabel.AutoSize = true;
            SerialNumberLabel.Location = new Point(12, 20);
            SerialNumberLabel.Name = "SerialNumberLabel";
            SerialNumberLabel.Size = new Size(127, 17);
            SerialNumberLabel.TabIndex = 3;
            SerialNumberLabel.Text = "Порядковый номер";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(12, 62);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(98, 17);
            FullNameLabel.TabIndex = 4;
            FullNameLabel.Text = "Фамилия И.О.";
            // 
            // AverageMarkLabel
            // 
            AverageMarkLabel.AutoSize = true;
            AverageMarkLabel.Location = new Point(12, 104);
            AverageMarkLabel.Name = "AverageMarkLabel";
            AverageMarkLabel.Size = new Size(94, 17);
            AverageMarkLabel.TabIndex = 5;
            AverageMarkLabel.Text = "Средний балл";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(145, 146);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(125, 31);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(8, 146);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(131, 31);
            ReadButton.TabIndex = 7;
            ReadButton.Text = "Читать";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // StudentPerformanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(281, 188);
            Controls.Add(ReadButton);
            Controls.Add(SaveButton);
            Controls.Add(AverageMarkLabel);
            Controls.Add(FullNameLabel);
            Controls.Add(SerialNumberLabel);
            Controls.Add(AverageMark);
            Controls.Add(FullName);
            Controls.Add(SerialNumber);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "StudentPerformanceForm";
            Text = "Успеваемость студента";
            Load += StudentPerformanceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SerialNumber;
        private TextBox FullName;
        private TextBox AverageMark;
        private Label SerialNumberLabel;
        private Label FullNameLabel;
        private Label AverageMarkLabel;
        private Button SaveButton;
        private Button ReadButton;
    }
}
