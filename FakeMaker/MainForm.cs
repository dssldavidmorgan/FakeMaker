using FakeMaker.Core;
using System.Data;

namespace FakeMaker;

public partial class MainForm : Form
{
    private readonly Configuration configuration = new();
    private readonly Generator generator = new();
    private readonly Exporter exporter = new();

    private IEnumerable<Record>? records = null;

    public MainForm()
    {
        InitializeComponent();
    }

    private void ConfigureButton_Click(object sender, EventArgs e)
    {
        using var configureDialog = new ConfigureDialog(configuration);
        configureDialog.ShowDialog();
    }

    private void GenerateButton_Click(object sender, EventArgs e)
    {
        using var generateDialog = new GenerateDialog();

        if (generateDialog.ShowDialog() == DialogResult.OK)
        {
            records = generator.Generate(generateDialog.Count, configuration);

            LoadDataGridView(records);
        }
    }

    private void LoadDataGridView(IEnumerable<Record> records)
    {
        var dataTable = new DataTable();

        foreach (var column in configuration.Columns)
            dataTable.Columns.Add(column.Name);

        foreach (var record in records)
            dataTable.Rows.Add(record.Fields);

        dataGridView.DataSource = dataTable;
    }

    private void ExportButton_Click(object sender, EventArgs e)
    {
        if (records is null)
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
            using var file = new FileStream(exportFileDialog.FileName, FileMode.OpenOrCreate);

            exporter.Export(file, records, configuration);
        }
    }
}
