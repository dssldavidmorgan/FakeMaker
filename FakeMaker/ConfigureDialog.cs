using FakeMaker.Core;

namespace FakeMaker;

public partial class ConfigureDialog : Form
{
    public ConfigureDialog()
    {
        InitializeComponent();
    }

    private void ConfigureDialog_Load(object sender, EventArgs e)
    {
        LoadTypeComboBox();
    }

    private void LoadTypeComboBox()
    {
        foreach (var value in typeof(DataType).GetEnumValues())
        {
            typeBindingSource.Add(value);
        }
    }
}
