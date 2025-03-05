namespace FakeMaker;

public partial class GenerateDialog : Form
{
    public int Count => (int)numberOfRecordsSpinner.Value;

    public GenerateDialog()
    {
        InitializeComponent();
    }

    private void GenerateButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }
}
