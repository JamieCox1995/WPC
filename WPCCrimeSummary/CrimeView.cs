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

        public CrimeView()
        {
            InitializeComponent();

            _controller = new CrimeController(this);

            _controller.GetCrimeList("51.44237", "-2.49810", "2021-01");
        }

        public void ClearList()
        {
            throw new NotImplementedException();
        }

        public void UpdateCrimeList(CrimeList _CrimeList)
        {
            throw new NotImplementedException();
        }
    }
}
