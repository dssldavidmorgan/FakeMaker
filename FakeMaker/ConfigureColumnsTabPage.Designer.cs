namespace FakeMaker
{
    partial class ConfigureColumnsTabPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            columnGroupBox = new GroupBox();
            typeLabel = new Label();
            typeComboBox = new ComboBox();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            columnsListBox = new ListBox();
            addButton = new Button();
            removeButton = new Button();
            columnsBindingSource = new BindingSource(components);
            typeBindingSource = new BindingSource(components);
            columnGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)columnsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // columnGroupBox
            // 
            columnGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            columnGroupBox.Controls.Add(typeLabel);
            columnGroupBox.Controls.Add(typeComboBox);
            columnGroupBox.Controls.Add(nameTextBox);
            columnGroupBox.Controls.Add(nameLabel);
            columnGroupBox.Location = new Point(197, 3);
            columnGroupBox.Name = "columnGroupBox";
            columnGroupBox.Size = new Size(311, 94);
            columnGroupBox.TabIndex = 7;
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
            typeComboBox.Size = new Size(214, 23);
            typeComboBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(91, 22);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(214, 23);
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
            // columnsListBox
            // 
            columnsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            columnsListBox.DataSource = columnsBindingSource;
            columnsListBox.FormattingEnabled = true;
            columnsListBox.ItemHeight = 15;
            columnsListBox.Location = new Point(3, 3);
            columnsListBox.Name = "columnsListBox";
            columnsListBox.Size = new Size(188, 304);
            columnsListBox.TabIndex = 4;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.Location = new Point(100, 313);
            addButton.Name = "addButton";
            addButton.Size = new Size(91, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            removeButton.Location = new Point(3, 313);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(91, 23);
            removeButton.TabIndex = 5;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += RemoveButton_Click;
            // 
            // ConfigureColumnsTabPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(columnGroupBox);
            Controls.Add(columnsListBox);
            Controls.Add(addButton);
            Controls.Add(removeButton);
            Name = "ConfigureColumnsTabPage";
            Size = new Size(511, 339);
            Load += ConfigureColumnsTabPage_Load;
            columnGroupBox.ResumeLayout(false);
            columnGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)columnsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox columnGroupBox;
        private Label typeLabel;
        private ComboBox typeComboBox;
        private TextBox nameTextBox;
        private Label nameLabel;
        private ListBox columnsListBox;
        private Button addButton;
        private Button removeButton;
        private BindingSource columnsBindingSource;
        private BindingSource typeBindingSource;
    }
}
