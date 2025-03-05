using FakeMaker.Core;

namespace FakeMaker;

public partial class ConfigureDialog : Form
{
    public Configuration Configuration { get; private set; }

    public ConfigureDialog(Configuration configuration)
    {
        Configuration = configuration;

        InitializeComponent();
        InitializeDataBindings();
    }

    private void InitializeDataBindings()
    {
        columnsBindingSource.DataSource = Configuration.Columns;
        columnsListBox.DisplayMember = nameof(Column.Name);

        nameTextBox.DataBindings.Clear();
        typeComboBox.DataBindings.Clear();

        nameTextBox.DataBindings.Add(
            nameof(TextBox.Text),
            columnsBindingSource,
            nameof(Column.Name),
            formattingEnabled: false,
            DataSourceUpdateMode.OnPropertyChanged);

        typeComboBox.DataBindings.Add(
            nameof(ComboBox.SelectedItem),
            columnsBindingSource,
            nameof(Column.Type),
            formattingEnabled: false,
            DataSourceUpdateMode.OnPropertyChanged);
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

    private void AddButton_Click(object sender, EventArgs e)
    {
        columnsBindingSource.Add(new Column { Name = "new_column", Type = DataType.FirstName });
    }

    private void RemoveButton_Click(object sender, EventArgs e)
    {
        if (columnsListBox.SelectedIndex >= 0)
            columnsBindingSource.RemoveAt(columnsListBox.SelectedIndex);
    }

    private void LoadButton_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            using var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
            Configuration = ConfigurationSerializer.Load(fileStream);
            InitializeDataBindings();
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
