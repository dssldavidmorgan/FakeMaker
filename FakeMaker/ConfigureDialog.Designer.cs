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
            saveButton = new Button();
            loadButton = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            tabControl = new TabControl();
            columnsTabPage = new TabPage();
            customDataTypesTabPage = new TabPage();
            configureColumnsTabPage = new ConfigureColumnsTabPage();
            tabControl.SuspendLayout();
            columnsTabPage.SuspendLayout();
            SuspendLayout();
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
            columnsTabPage.Controls.Add(configureColumnsTabPage);
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
            // configureColumnsTabPage
            // 
            configureColumnsTabPage.Dock = DockStyle.Fill;
            configureColumnsTabPage.Location = new Point(3, 3);
            configureColumnsTabPage.Name = "configureColumnsTabPage";
            configureColumnsTabPage.Size = new Size(529, 348);
            configureColumnsTabPage.TabIndex = 0;
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
            tabControl.ResumeLayout(false);
            columnsTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button saveButton;
        private Button loadButton;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private TabControl tabControl;
        private TabPage columnsTabPage;
        private TabPage customDataTypesTabPage;
        private ConfigureColumnsTabPage configureColumnsTabPage;
    }
}