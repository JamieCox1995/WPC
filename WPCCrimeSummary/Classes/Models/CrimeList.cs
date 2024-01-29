using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using WPCCrimeSummary.Classes.Utilities;

namespace Classes.Models
{
    public class CrimeList
    {
        public List<Crime> Crimes { get; }

        public Dictionary<string, int> CrimeCategorySummary { get; }

        public CrimeList()
        {
            Crimes = new List<Crime>();
            CrimeCategorySummary = new Dictionary<string, int>();
        }

        public void AddCrime(Crime _Crime)
        {
            if(_Crime != null)
            {
                Crimes.Add(_Crime);
            }
        }

        public void AddCrimes(List<Crime> _Crimes)
        {
            CrimeCategorySummary.Clear();

            if(_Crimes.Count > 0)
            {
                Crimes.AddRange(_Crimes);

                var grp = Crimes.GroupBy(i => i.Category);

                foreach(var cat in grp)
                {
                    CrimeCategorySummary.Add(cat.Key, cat.Count());
                }
            }
        }
        
        public static CrimeList ReadCrimes(string _Latitude, string _Longtitude, string _Date)
        {
            CrimeList crimeList = new CrimeList();

            APIClient client = new APIClient();
            string s = client.GetResponse("https://data.police.uk/api/crimes-street", $"all-crime?lat={_Latitude}&lng={_Longtitude}&date={_Date}");

            List<Crime> crimes = JsonConvert.DeserializeObject<List<Crime>>(s);

            crimeList.AddCrimes(crimes);

            return crimeList;
        }

        public void RemoveCrime(Crime _Crime)
        {
            if(Crimes.Contains(_Crime))
            {
                Crimes.Remove(_Crime);
            }
        }

        public bool IsLatitudeValid(string _Latitude)
        {
            return true;
        }

        public bool IsLongtitudeValid(string _Longtitude) 
        {
            return true;
        }

        public bool IsDateValid(string _Date)
        {
            return true;
        }
    }
}
