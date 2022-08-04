using Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Drugstore : IEntity
    {
        public int ID { get; set; }
        public string NameDrugstore { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        //public Drug Drugs { get; set; }

        // public Druggist Druggists { get; set; }
        public Owner ownerDrugstore { get; set; }
    }
}
