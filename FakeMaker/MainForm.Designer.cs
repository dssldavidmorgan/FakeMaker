namespace FakeMaker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip = new ToolStrip();
            configureButton = new ToolStripButton();
            generateButton = new ToolStripButton();
            exportButton = new ToolStripButton();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Items.AddRange(new ToolStripItem[] { configureButton, generateButton, exportButton });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(800, 25);
            toolStrip.TabIndex = 0;
            toolStrip.Text = "toolStrip";
            // 
            // configureButton
            // 
            configureButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            configureButton.Image = (Image)resources.GetObject("configureButton.Image");
            configureButton.ImageTransparentColor = Color.Magenta;
            configureButton.Name = "configureButton";
            configureButton.Size = new Size(64, 22);
            configureButton.Text = "Configure";
            configureButton.Click += ConfigureButton_Click;
            // 
            // generateButton
            // 
            generateButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            generateButton.Image = (Image)resources.GetObject("generateButton.Image");
            generateButton.ImageTransparentColor = Color.Magenta;
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(58, 22);
            generateButton.Text = "Generate";
            generateButton.Click += GenerateButton_Click;
            // 
            // exportButton
            // 
            exportButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            exportButton.Image = (Image)resources.GetObject("exportButton.Image");
            exportButton.ImageTransparentColor = Color.Magenta;
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(44, 22);
            exportButton.Text = "Export";
            exportButton.Click += ExportButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip);
            Name = "MainForm";
            Text = "FakeMaker";
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip;
        private ToolStripButton configureButton;
        private ToolStripButton generateButton;
        private ToolStripButton exportButton;
    }
}
