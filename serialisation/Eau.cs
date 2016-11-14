using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialisation
{
    public class Eau : Item
    {
        #region Propriétés
        public double Poids { get; private set; }
        #endregion

        #region Constructeur
        public Eau(string nom, int magnitude, int duree ) : base(nom, degats)
        {
            this.Poids = poids;
        }
        #endregion
    }
    {
    }
}
