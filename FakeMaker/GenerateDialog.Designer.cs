namespace FakeMaker
{
    partial class GenerateDialog
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
            numberOfRecordsSpinner = new NumericUpDown();
            numberOfRecordsLabel = new Label();
            generateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numberOfRecordsSpinner).BeginInit();
            SuspendLayout();
            // 
            // numberOfRecordsSpinner
            // 
            numberOfRecordsSpinner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numberOfRecordsSpinner.Location = new Point(125, 12);
            numberOfRecordsSpinner.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numberOfRecordsSpinner.Name = "numberOfRecordsSpinner";
            numberOfRecordsSpinner.Size = new Size(104, 23);
            numberOfRecordsSpinner.TabIndex = 0;
            // 
            // numberOfRecordsLabel
            // 
            numberOfRecordsLabel.AutoSize = true;
            numberOfRecordsLabel.Location = new Point(12, 14);
            numberOfRecordsLabel.Name = "numberOfRecordsLabel";
            numberOfRecordsLabel.Size = new Size(107, 15);
            numberOfRecordsLabel.TabIndex = 1;
            numberOfRecordsLabel.Text = "Number of records";
            // 
            // generateButton
            // 
            generateButton.Anchor = AnchorStyles.Bottom;
            generateButton.Location = new Point(81, 60);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(75, 23);
            generateButton.TabIndex = 2;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += GenerateButton_Click;
            // 
            // GenerateDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 94);
            Controls.Add(generateButton);
            Controls.Add(numberOfRecordsLabel);
            Controls.Add(numberOfRecordsSpinner);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "GenerateDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Generate";
            ((System.ComponentModel.ISupportInitialize)numberOfRecordsSpinner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numberOfRecordsSpinner;
        private Label numberOfRecordsLabel;
        private Button generateButton;
    }
}