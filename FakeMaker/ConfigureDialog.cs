using FakeMaker.Core;

namespace FakeMaker;

public partial class ConfigureDialog : Form
{
    public ConfigureDialog(Configuration configuration)
    {
        InitializeComponent();
        InitializeDataBindings(configuration);
    }

    private void InitializeDataBindings(Configuration configuration)
    {
        columnsBindingSource.DataSource = configuration.Columns;
        columnsListBox.DisplayMember = nameof(Column.Name);

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
}
