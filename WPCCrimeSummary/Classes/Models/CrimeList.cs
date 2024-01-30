using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPCCrimeSummary.Classes.Utilities;

namespace Classes.Models
{
    public class CrimeList
    {
        public List<Crime> Crimes { get; }

        public Dictionary<string, List<Crime>> CrimeCategorySummary { get; }

        public CrimeList()
        {
            Crimes = new List<Crime>();
            CrimeCategorySummary = new Dictionary<string, List<Crime>>();
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
                    CrimeCategorySummary.Add(cat.Key, cat.ToList());
                }
            }
        }
        
        public static CrimeList ReadCrimes(string _Latitude, string _Longtitude, string _Date)
        {
            CrimeList crimeList = new CrimeList();

            APIClient client = new APIClient();
            string s = client.GetResponse("https://data.police.uk/api/crimes-street", $"all-crime?lat={_Latitude}&lng={_Longtitude}&date={_Date}");

            List<Crime> crimes = JsonConvert.DeserializeObject<List<Crime>>(s);

            if(crimes != null)
            {
                crimeList.AddCrimes(crimes);
            }

            return crimeList;
        }

        #region Validation
        public static bool IsLatitudeValid(string _Latitude, out string _Message)
        {
            // First, check to see if the input is empty or null
            if (string.IsNullOrWhiteSpace(_Latitude))
            {
                _Message = "Latitude cannot be empty.";
                return false;
            }

            // Next, check to see if it is a number
            if(double.TryParse(_Latitude, out double lat))
            {
                // GENERIC: check if lng is between -90 and 90
                if(Math.Abs(lat) > 90)
                {
                    _Message = "Latitude must be between -90 and 90 degrees.";
                    return false;
                }

                // now we check the UK lats, they are generally between: 50.10319 - 60.15456 (https://latitudelongitude.org/gb/)
                if(lat < 50.10319 || lat > 60.15456)
                {
                    _Message = "Enter a latitude within the UK (50.10319 to 60.15456).";
                    return false;
                }
            }
            else
            {
                // not a number
                _Message = "Latitude must be a number.";
                return false;
            }

            _Message = "";
            return true;
        }

        public static bool IsLongitudeValid(string _Longitude, out string _Message) 
        {
            // First, check to see if the input is empty or null
            if (string.IsNullOrWhiteSpace(_Longitude))
            {
                _Message = "Longitude cannot be empty.";
                return false;
            }

            // Next, check to see if it is a number
            if (double.TryParse(_Longitude, out double lng))
            {
                // check if lng is between -180 and 180
                // saving a comparison by removing the negative sign from infront of the number.
                if (Math.Abs(lng) > 180)
                {
                    _Message = "Longitude must be between -180 and 180 degrees.";
                    return false;
                }

                // now we check the UK lats, they are generally between: -7.64133 - 1.75159 (https://latitudelongitude.org/gb/)
                if (lng < -7.64133 || lng > 1.75159)
                {
                    _Message = "Enter a longitude within the UK (-7.64133 to 1.75159).";
                    return false;
                }
            }
            else
            {
                // not a number
                _Message = "Longitude must be a number.";
                return false;
            }

            _Message = "";
            return true;
        }

        public static bool IsDateValid(string _Date, out string _Message)
        {
            // Getting the date 1 year ago from today
            DateTime yearAgo = DateTime.Now.AddYears(-1);
            DateTime now = DateTime.Now;

            if (string.IsNullOrEmpty(_Date))
            {
                _Message = "Please enter a date in the format: \"yyyy-MM\".";
                return false;
            }

            string[] dateParts = _Date.Split("-");
            string day = now.Day.ToString();

            if (int.TryParse(dateParts[0], out int res)) 
            {
            
                if (int.Parse(dateParts[0]) % 400 != 0)
                {
                    if (dateParts[1] == "02")
                    {
                        if (now.Day > 28)
                        {
                            dateParts[1] = "03";
                            day = "01";
                        }
                    }
                }
            }

            // Now that we know the string is not empty, append todays day of month to the end and try to convert to datetime in the format "yyyy-MM-dd"
            string date = $"{_Date}-{day}";

            if(DateTime.TryParse(date, out DateTime result))
            {
                // if it is a valid date, we want to check to see if it is in the future.
                if(result > now)
                {
                    _Message = "Cannot retrieve crimes for a future date.";
                    return false;
                }

                // if it is within the last month
                string thisMonth = now.ToString("yyyy-MM");

                if(thisMonth == _Date)
                {
                    _Message = "Cannot retrieve crimes for this month.";
                    return false;
                }

                // if it is more than a year ago
                if(result < yearAgo)
                {
                    _Message = "Cannot retrieve crimes which are older than a year.";
                    return false;
                }
            }
            else
            {
                // not a valid yyyy-MM format
                _Message = "Please enter a valid Year and Month in the format:  \"yyyy-MM\".";
                return false;
            }

            // no errors
            _Message = "";
            return true;
        }
        #endregion
    }
}
