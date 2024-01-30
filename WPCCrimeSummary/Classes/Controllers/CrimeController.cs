using Classes.Models;
using Classes.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Controllers
{
    public class CrimeController
    {
        private ICrimeView _crimeView;
        private CrimeList _crimes;

        public CrimeController(ICrimeView _CrimeView)
        {
            _crimeView = _CrimeView;
        }

        public void GetCrimeList(string _Latitude, string _Longitude, string _Date)
        {
            // create variable to store any error message
            string message = "";

            // check if any of the validations fail
            if(!CrimeList.IsLatitudeValid(_Latitude, out message) || !CrimeList.IsLongitudeValid(_Longitude, out message) || !CrimeList.IsDateValid(_Date, out message))
            {
                // if fail, show error
                MessageBox.Show(message);

                return;
            }

            // otherwise get list of crimes
            _crimes = CrimeList.ReadCrimes(_Latitude, _Longitude, _Date);

            // update the view.
            _crimeView.UpdateCrimeList(_crimes);
        }
    }
}
