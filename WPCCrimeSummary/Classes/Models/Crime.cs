using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Crime
    {
        public string Category { get; set; }
        public string Location_type { get; set; }
        public Location Location { get; set; }
        public string Context { get; set; }
        public OutcomeStatus Outcome_status { get; set; }
        public string Persistent_id { get; set; }
        public string ID { get; set; }
        public string Location_subtype { get; set; }
        public string Month { get; set; }

        public Crime(string category, string locationType, Location location, string context, OutcomeStatus outcomeStatus, string persistentID, string iD, string locationSubtype, string month)
        {
            Category = category;
            Location_type = locationType;
            Location = location;
            Context = context;
            Outcome_status = outcomeStatus;
            Persistent_id = persistentID;
            ID = iD;
            Location_subtype = locationSubtype;
            Month = month;
        }
    }
}
