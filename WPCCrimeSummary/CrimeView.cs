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

            _controller = new CrimeController(this);
        }

        public void ClearList()
        {
            throw new NotImplementedException();
        }

        public void UpdateCrimeList(CrimeList _CrimeList)
        {
            _selectedCategory = "";

            _list = _CrimeList;

            BindCategorySummary();
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
            if(lvSummary.SelectedIndices.Count == 0)
            {
                return;
            }

            _selectedCategory = _list.CrimeCategorySummary.ElementAt((int)(lvSummary.SelectedIndices[0])).Key;

            BindBreakdown();
        }

        private void BindBreakdown()
        {
            lvBreakdown.Items.Clear();

            if(string.IsNullOrWhiteSpace(_selectedCategory))
            {
                return;
            }

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
