using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.ADT
{
    internal class Pokemon
    {
        private string Name {  get; set; }
        private int Ext {  get; set; }

        public bool IsPokemon() { return Name.Length > 0; }
    }
}
