using Classes.Controllers;
using Classes.Models;
using Classes.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPCCrimeSummary
{
    public partial class CrimeView : Form, ICrimeView
    {
        private CrimeController _controller;
        private CrimeList _list;

        private string _selectedCategory;

        public CrimeView()
        {
            InitializeComponent();

            // initalize a new instance of the controller.
            _controller = new CrimeController(this);
        }

        public void UpdateCrimeList(CrimeList _CrimeList)
        {
            // reset the selected index, as we want nothing selected.
            _selectedCategory = "";

            // set our local version of the list to the one we have received from the controller.
            _list = _CrimeList;

            // binding summary section
            BindCategorySummary();
            // binding breakdown, but this will just clear it for the moment until somthing is selected.
            BindBreakdown();
        }

        private void BindCategorySummary()
        {
            // clear previous items
            lvSummary.Items.Clear();

            // iterating over all of the crime cateogries and adding them + count to list
            foreach(KeyValuePair<string, List<Crime>> kvp in _list.CrimeCategorySummary)
            {
                lvSummary.Items.Add(new ListViewItem($"{kvp.Key} ({kvp.Value.Count} Crimes)"));
            }

            gbCategorySummary.Text = $"Category Summary ({_list.Crimes.Count} Total Crimes)";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // grabbing user inputs
            string lat = txtLatitude.Text;
            string lng = txtLongitude.Text;
            string date = $"{txtYear.Text}-{txtMonth.Text}";

            // telling the controller to search
            _controller.GetCrimeList(lat, lng, date);
        }

        private void lvSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if there are no selected indices, do nothing
            if(lvSummary.SelectedIndices.Count == 0)
            {
                return;
            }

            // get the name of the selected category
            _selectedCategory = _list.CrimeCategorySummary.ElementAt((int)(lvSummary.SelectedIndices[0])).Key;

            // bind breakdown
            BindBreakdown();
        }

        private void BindBreakdown()
        {
            // clear items
            lvBreakdown.Items.Clear();

            // if the selected category is null or empty, do not continue
            if(string.IsNullOrWhiteSpace(_selectedCategory))
            {
                return;
            }

            // iterate over all the crimes for the category and add an item to the list view.
            foreach(Crime crime in _list.CrimeCategorySummary[_selectedCategory])
            {
                ListViewItem item = new ListViewItem();
                item.Text = $"{crime.ID} - {crime.Location.Street.Name} ({crime.Location_type})";
                item.BackColor = crime.Outcome_status == null ? Color.Red : Color.Green;

                lvBreakdown.Items.Add(item);
            }
        }
    }
}
