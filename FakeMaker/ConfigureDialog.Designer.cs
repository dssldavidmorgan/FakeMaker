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
            columnGroupBox = new GroupBox();
            typeLabel = new Label();
            typeComboBox = new ComboBox();
            typeBindingSource = new BindingSource(components);
            nameTextBox = new TextBox();
            nameLabel = new Label();
            addButton = new Button();
            removeButton = new Button();
            columnsListBox = new ListBox();
            columnsBindingSource = new BindingSource(components);
            saveButton = new Button();
            loadButton = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            tabControl = new TabControl();
            columnsTabPage = new TabPage();
            customDataTypesTabPage = new TabPage();
            columnGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)typeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)columnsBindingSource).BeginInit();
            tabControl.SuspendLayout();
            columnsTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // columnGroupBox
            // 
            columnGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            columnGroupBox.Controls.Add(typeLabel);
            columnGroupBox.Controls.Add(typeComboBox);
            columnGroupBox.Controls.Add(nameTextBox);
            columnGroupBox.Controls.Add(nameLabel);
            columnGroupBox.Location = new Point(200, 6);
            columnGroupBox.Name = "columnGroupBox";
            columnGroupBox.Size = new Size(329, 94);
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
            typeComboBox.Size = new Size(221, 23);
            typeComboBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(91, 22);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(221, 23);
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
            addButton.Location = new Point(103, 328);
            addButton.Name = "addButton";
            addButton.Size = new Size(91, 23);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            removeButton.Location = new Point(6, 328);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(91, 23);
            removeButton.TabIndex = 1;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += RemoveButton_Click;
            // 
            // columnsListBox
            // 
            columnsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            columnsListBox.DataSource = columnsBindingSource;
            columnsListBox.FormattingEnabled = true;
            columnsListBox.ItemHeight = 15;
            columnsListBox.Location = new Point(6, 6);
            columnsListBox.Name = "columnsListBox";
            columnsListBox.Size = new Size(188, 319);
            columnsListBox.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(480, 400);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // loadButton
            // 
            loadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            loadButton.Location = new Point(399, 400);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 23);
            loadButton.TabIndex = 2;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += LoadButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.DefaultExt = "xml";
            openFileDialog.Filter = "XML files|*.xml|All files|*.*";
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.Filter = "XML Files|*.xml|All files|*.*";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(columnsTabPage);
            tabControl.Controls.Add(customDataTypesTabPage);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(543, 382);
            tabControl.TabIndex = 3;
            // 
            // columnsTabPage
            // 
            columnsTabPage.Controls.Add(columnGroupBox);
            columnsTabPage.Controls.Add(columnsListBox);
            columnsTabPage.Controls.Add(addButton);
            columnsTabPage.Controls.Add(removeButton);
            columnsTabPage.Location = new Point(4, 24);
            columnsTabPage.Name = "columnsTabPage";
            columnsTabPage.Padding = new Padding(3);
            columnsTabPage.Size = new Size(535, 354);
            columnsTabPage.TabIndex = 0;
            columnsTabPage.Text = "Columns";
            columnsTabPage.UseVisualStyleBackColor = true;
            // 
            // customDataTypesTabPage
            // 
            customDataTypesTabPage.Location = new Point(4, 24);
            customDataTypesTabPage.Name = "customDataTypesTabPage";
            customDataTypesTabPage.Padding = new Padding(3);
            customDataTypesTabPage.Size = new Size(535, 354);
            customDataTypesTabPage.TabIndex = 1;
            customDataTypesTabPage.Text = "Custom Data Types";
            customDataTypesTabPage.UseVisualStyleBackColor = true;
            // 
            // ConfigureDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 433);
            Controls.Add(tabControl);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ConfigureDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configure";
            Load += ConfigureDialog_Load;
            columnGroupBox.ResumeLayout(false);
            columnGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)typeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)columnsBindingSource).EndInit();
            tabControl.ResumeLayout(false);
            columnsTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button removeButton;
        private ListBox columnsListBox;
        private Button addButton;
        private GroupBox columnGroupBox;
        private Label typeLabel;
        private ComboBox typeComboBox;
        private TextBox nameTextBox;
        private Label nameLabel;
        private BindingSource typeBindingSource;
        private BindingSource columnsBindingSource;
        private Button saveButton;
        private Button loadButton;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private TabControl tabControl;
        private TabPage columnsTabPage;
        private TabPage customDataTypesTabPage;
    }
}