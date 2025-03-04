namespace FakeMaker
{
    partial class ConfigureDialog
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
            components = new System.ComponentModel.Container();
            columnsGroupBox = new GroupBox();
            columnGroupBox = new GroupBox();
            typeLabel = new Label();
            typeComboBox = new ComboBox();
            typeBindingSource = new BindingSource(components);
            nameTextBox = new TextBox();
            nameLabel = new Label();
            addButton = new Button();
            removeButton = new Button();
            columnsListBox = new ListBox();
            okButton = new Button();
            columnsGroupBox.SuspendLayout();
            columnGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)typeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // columnsGroupBox
            // 
            columnsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            columnsGroupBox.Controls.Add(columnGroupBox);
            columnsGroupBox.Controls.Add(addButton);
            columnsGroupBox.Controls.Add(removeButton);
            columnsGroupBox.Controls.Add(columnsListBox);
            columnsGroupBox.Location = new Point(12, 12);
            columnsGroupBox.Name = "columnsGroupBox";
            columnsGroupBox.Size = new Size(543, 411);
            columnsGroupBox.TabIndex = 0;
            columnsGroupBox.TabStop = false;
            columnsGroupBox.Text = "Columns";
            // 
            // columnGroupBox
            // 
            columnGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            columnGroupBox.Controls.Add(typeLabel);
            columnGroupBox.Controls.Add(typeComboBox);
            columnGroupBox.Controls.Add(nameTextBox);
            columnGroupBox.Controls.Add(nameLabel);
            columnGroupBox.Location = new Point(200, 22);
            columnGroupBox.Name = "columnGroupBox";
            columnGroupBox.Size = new Size(337, 94);
            columnGroupBox.TabIndex = 3;
            columnGroupBox.TabStop = false;
            columnGroupBox.Text = "Column";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(32, 54);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(32, 15);
            typeLabel.TabIndex = 3;
            typeLabel.Text = "Type";
            // 
            // typeComboBox
            // 
            typeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            typeComboBox.DataSource = typeBindingSource;
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(91, 51);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(229, 23);
            typeComboBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(91, 22);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(229, 23);
            nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(25, 25);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.Location = new Point(103, 378);
            addButton.Name = "addButton";
            addButton.Size = new Size(91, 23);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            removeButton.Location = new Point(6, 378);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(91, 23);
            removeButton.TabIndex = 1;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // columnsListBox
            // 
            columnsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            columnsListBox.FormattingEnabled = true;
            columnsListBox.ItemHeight = 15;
            columnsListBox.Location = new Point(6, 22);
            columnsListBox.Name = "columnsListBox";
            columnsListBox.Size = new Size(188, 349);
            columnsListBox.TabIndex = 0;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.Location = new Point(465, 429);
            okButton.Name = "okButton";
            okButton.Size = new Size(90, 33);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // ConfigureDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 466);
            Controls.Add(okButton);
            Controls.Add(columnsGroupBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ConfigureDialog";
            Text = "Configure";
            Load += ConfigureDialog_Load;
            columnsGroupBox.ResumeLayout(false);
            columnGroupBox.ResumeLayout(false);
            columnGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)typeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox columnsGroupBox;
        private Button removeButton;
        private ListBox columnsListBox;
        private Button addButton;
        private GroupBox columnGroupBox;
        private Label typeLabel;
        private ComboBox typeComboBox;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Button okButton;
        private BindingSource typeBindingSource;
    }
}