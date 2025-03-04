namespace FakeMaker;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void ConfigureButton_Click(object sender, EventArgs e)
    {
        using var configureDialog = new ConfigureDialog();
        configureDialog.ShowDialog();
    }

    private void GenerateButton_Click(object sender, EventArgs e)
    {

    }

    private void ExportButton_Click(object sender, EventArgs e)
    {

    }
}
