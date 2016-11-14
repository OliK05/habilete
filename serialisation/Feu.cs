using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialisation
{
    public class Feu : Item
    {
        #region Propriétés
        public double magnitude { get; private set; }
        #endregion

        #region Constructeur
        public Feu (string nom, int magnitude, int duree, string effet, int cible)
            : base(nom, magnitude)
        {
            this.
        }
        #endregion
    }
    
}
