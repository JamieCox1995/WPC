using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Crime
    {
        public string Category { get; }
        public string LocationType { get; }
        public Location Location { get; }
        public string Context { get; }
        public string OutcomeStatus { get; }
        public string PersistentID { get; }
        public string ID { get; }
        public string LocationSubtype { get; }
        public string Month { get; }

        public Crime(string category, string locationType, Location location, string context, string outcomeStatus, string persistentID, string iD, string locationSubtype, string month)
        {
            Category = category;
            LocationType = locationType;
            Location = location;
            Context = context;
            OutcomeStatus = outcomeStatus;
            PersistentID = persistentID;
            ID = iD;
            LocationSubtype = locationSubtype;
            Month = month;
        }
    }
}
