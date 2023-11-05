using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Heritage
{
    internal class CompteEpargne : Compte
    {
        private float tauxInteret;
        public CompteEpargne(float tauxInteret, string nom, float solde) : base(nom, solde)
        {
            this.tauxInteret = tauxInteret;
        }
        public void calculInteret()
        {
            float s = solde - (solde * (tauxInteret/100));
            Console.WriteLine($"Le nouveau solde en tenant compte des interet est {s} ");
        }
        public new float getSolde()
        {
            return solde;
        }

    }
}
