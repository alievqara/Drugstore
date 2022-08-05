﻿using Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Druggist : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public double Enperience { get; set; }
        public List<Drugstore> drugstore { get; set; }
    }
}
