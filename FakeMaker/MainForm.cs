using FakeMaker.Core;

namespace FakeMaker;

public partial class MainForm : Form
{
    private readonly Configuration configuration = new();

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
        generateDialog.ShowDialog();
    }

    private void ExportButton_Click(object sender, EventArgs e)
    {

    }
}
