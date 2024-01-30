using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Views
{
    public interface ICrimeView
    {
        public void UpdateCrimeList(CrimeList _CrimeList);
    }
}
