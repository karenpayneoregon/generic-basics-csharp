using System.Diagnostics;
using CommonLibrary.Mocking;

namespace SerializeSettingsApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void CreateButton_Click(object sender, EventArgs e)
    {
        MockedOperations.Serialize();
    }

    private void ReadButton_Click(object sender, EventArgs e)
    {
        if (File.Exists(MockedOperations.FileName))
        {
            var settings = MockedOperations.Deserialize();
            ResultsTextBox.Text = ObjectDumper.Dump(settings);
        }
        else
        {
            MessageBox.Show("Use create button first");
        }

    }
}
