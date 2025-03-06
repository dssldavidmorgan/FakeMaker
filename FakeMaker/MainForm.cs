using FakeMaker.Core;
using System.Data;

namespace FakeMaker;

public partial class MainForm : Form
{
    private Configuration configuration = new();

    private readonly GenerateDialog generateDialog = new();

    public MainForm()
    {
        InitializeComponent();
    }

    private void ConfigureButton_Click(object sender, EventArgs e)
    {
        using var configureDialog = new ConfigureDialog(configuration);
        configureDialog.ShowDialog();
        configuration = configureDialog.Configuration;
    }

    private void GenerateButton_Click(object sender, EventArgs e)
    {
        if (generateDialog.ShowDialog(owner: this) == DialogResult.OK)
        {
            var dataTable = Generator.Generate(generateDialog.Count, configuration);
            dataGridView.DataSource = dataTable;
        }
    }

    private void ExportButton_Click(object sender, EventArgs e)
    {
        if (dataGridView.DataSource is null)
        {
            MessageBox.Show(
                owner: this,
                text: "Records have not yet been generated",
                caption: "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }

        if (exportFileDialog.ShowDialog() == DialogResult.OK)
        {
            using var file = new FileStream(exportFileDialog.FileName, FileMode.Create, FileAccess.Write);

            Exporter.Export(file, (DataTable)dataGridView.DataSource);
        }
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        generateDialog.Dispose();
    }
}
