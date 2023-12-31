using System.ComponentModel;
using CheckedListBoxExtensionsApp.Classes;
using CommonLibrary.LanguageExtensions;
using CommonLibrary.Models;

#pragma warning disable CS8622

namespace CheckedListBoxExtensionsApp;

public partial class CheckedToDataGridViewForm : Form
{
    private readonly BindingSource _bindingSource = new ();
    private readonly BindingList<Company> _bindingList = new();

    public CheckedToDataGridViewForm()
    {
        InitializeComponent();

        ResultsDataGridView.AutoGenerateColumns = false;

        Shown += OnShown;
    }

    private void OnShown(object sender, EventArgs e)
    {
        _bindingSource.DataSource = _bindingList;
        ResultsDataGridView.DataSource = _bindingSource;

        List<Company> companies = BogusOperations.Companies();
        Company[] items = Random.Shared.GetItems(companies.ToArray(), 8);
        
        CompaniesCheckedListBox.DataSource = companies;

        // check some items and populate them to the DataGridView
        foreach (var company in items)
        {
            CompaniesCheckedListBox.SetChecked<Company>(company.Name, true);
        }
        PushedCheckedItemsToDataGridView();
    }

    private void CopyFromCheckedListBoxToDataGridViewButton_Click(object sender, EventArgs e)
    {
        /*
         * In OnShown we want to process checked items, novice developer would use
         * PerformClick but that sometimes will fail, so we create the method below
         * instead.
         */
        PushedCheckedItemsToDataGridView();
    }

    private void PushedCheckedItemsToDataGridView()
    {
        List<Company> result = CompaniesCheckedListBox.CheckedList<Company>();

        // not used here - does not make sense? set a breakpoint below and peek in the local window
        List<CheckedData<Company>> result1 = CompaniesCheckedListBox.IndexList<Company>();



        if (result.Count == 0)
        {
            _bindingList.Clear();
            return;
        }

        // if item does not exist in DataGridView do not add
        foreach (var company in result)
        {
            if (!_bindingList.Contains(company))
            {
                _bindingList.Add(company);
            }

        }

        ResultsDataGridView.ExpandColumns();
    }

    private void ClearDataGridViewRowsButton_Click(object sender, EventArgs e)
    {
        CompaniesCheckedListBox.UnCheckAll();

        if (_bindingList.Count >0)
        {
            _bindingList.Clear();
        }
    }

}