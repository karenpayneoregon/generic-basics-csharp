using System.ComponentModel;
using System.Diagnostics;
using Bogus;
using CheckedListBoxExtensionsApp.Classes;
using CommonLibrary.LanguageExtensions;
using CommonLibrary.Models;


namespace CheckedListBoxExtensionsApp;
public partial class CheckedToListForm : Form
{
    private readonly BindingSource _bindingSourceRight = new();
    protected BindingList<Product> _bindingListRight = new();
    public CheckedToListForm()
    {
        InitializeComponent();
        Shown += OnShown;
    }

    private void OnShown(object? sender, EventArgs e)
    {
        _bindingSourceRight.DataSource = _bindingListRight;
        ResultsListBox.DataSource = _bindingListRight;
        ProductsCheckedListBox.DataSource = BogusOperations.Products();
    }

    private void MoveLeftButton_Click(object sender, EventArgs e)
    {
        /*
        * The list box sorted property is set to true
        */
        List<CheckedData<Product>> result = ProductsCheckedListBox.IndexList<Product>();
        if (result.Count == 0)
        {
            _bindingListRight.Clear();
            return;
        }

        foreach (var data in result)
        {
            if (_bindingListRight.Contains(data.Model)) continue;
            _bindingListRight.Add(data.Model);
            ProductsCheckedListBox.SetItemCheckState(data.Index, CheckState.Unchecked);

        }
    }

    private void PeekButton_Click(object sender, EventArgs e)
    {
        if (_bindingListRight.Count > 0)
        {
            // Using a NuGet package dump the list to Visual Studio's output window rather than a foreach
            var personsDump = ObjectDumper.Dump(_bindingSourceRight, DumpStyle.CSharp);
            Debug.WriteLine(personsDump);
        }
    }

    private void ClearCheckedButton_Click(object sender, EventArgs e)
    {
        ProductsCheckedListBox.UnCheckAll();
    }
    private void ClearListBoxButton_Click(object sender, EventArgs e)
    {
        if (_bindingListRight.Count > 0)
        {
            _bindingListRight.Clear();
        }
    }


}
