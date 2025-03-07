using FakeMaker.Core;

namespace FakeMaker;

public partial class ConfigureDialog : Form
{
    public Configuration Configuration { get; private set; }

    public ConfigureDialog(Configuration configuration)
    {
        Configuration = configuration;

        InitializeComponent();
        configureColumnsTabPage.InitializeDataBindings(configuration);
    }

    private void LoadButton_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            using var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
            Configuration = ConfigurationDeserializer.Load(fileStream);
            configureColumnsTabPage.InitializeDataBindings(Configuration);
        }
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            using var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
            ConfigurationSerializer.Save(Configuration, fileStream);
        }
    }
}
