using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class OutcomeStatus
    {
        public string Category { get; }
        public string Date { get; }

        public OutcomeStatus(string category, string date)
        {
            Category = category;
            Date = date;
        }
    }
}
