using CommonLibrary.LanguageExtensions;

namespace DescendantsExamplesApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void GetSelectedFruitButton_Click(object sender, EventArgs e)
    {
        SelectedFruitTextBox.Text = FruitsGroupBox.RadioButtonChecked().Text;
    }
}
