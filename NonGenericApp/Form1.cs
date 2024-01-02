using System.Diagnostics;
using CheckedListBoxExtensionsApp.Classes;
using NonGenericApp.Classes;

namespace NonGenericApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    /*
     * Most novice developers use this event, do not, use Shown
     */
    private void Form1_Load(object sender, EventArgs e)
    {
        List<Company> companies = BogusOperations.Companies();
        Company[] items = Random.Shared.GetItems(companies.ToArray(), 8);

        CompaniesCheckedListBox.DataSource = companies;
    }
    /// <summary>
    /// We only get the name
    /// </summary>
    private void GetCheckedAsStringButton_Click(object sender, EventArgs e)
    {
        List<Company> list = [];
        for (int index = 0; index < CompaniesCheckedListBox.Items.Count; index++)
        {
            if (CompaniesCheckedListBox.GetItemChecked(index))
            {
                list.Add(new Company() { Name = CompaniesCheckedListBox.Items[index].ToString()! });
            }
        }

        Debug.WriteLine(list.Count > 0 ? ObjectDumper.Dump(list) : "Nothing checked");
    }

    /// <summary>
    /// Using a dedicated extension method
    /// </summary>
    private void GetCheckedExtensionMethodButton_Click(object sender, EventArgs e)
    {
        List<Company> list = CompaniesCheckedListBox.CheckedCompanies();
        Debug.WriteLine(list.Count > 0 ? ObjectDumper.Dump(list) : "Nothing checked");
    }
}
