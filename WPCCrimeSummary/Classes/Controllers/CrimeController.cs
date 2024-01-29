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

        public void GetCrimeList(string _Latitude, string _Longtitude, string _Date)
        {
            CrimeList.ReadCrimes(_Latitude, _Longtitude, _Date);
        }
    }
}
