using FakeMaker.Core;

namespace FakeMaker;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void ConfigureButton_Click(object sender, EventArgs e)
    {
        var configuration = new Configuration
        {
            Columns =
            [
                new Column { Name = "col1", Type = DataType.FirstName },
                new Column { Name = "col2", Type = DataType.LastName },
            ]
        };

        using var configureDialog = new ConfigureDialog(configuration);
        configureDialog.ShowDialog();
    }

    private void GenerateButton_Click(object sender, EventArgs e)
    {

    }

    private void ExportButton_Click(object sender, EventArgs e)
    {

    }
}
