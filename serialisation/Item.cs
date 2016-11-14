using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialisation
{
    public abstract class Item
    {
        #region Propriétés
        public string Nom { get; private set; }

        public int magnitude { get; private set; }
        #endregion

        #region Constructeur
        public Item (string nom, int magnitude)
        {
            this.Nom = nom;
            this.magnitude = magnitude;
        }
        #endregion
    }
    
    
}
