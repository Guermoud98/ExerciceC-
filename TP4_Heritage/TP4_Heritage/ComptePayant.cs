using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Heritage
{
    internal class ComptePayant : Compte
    {
        private float comission;
        public ComptePayant(float comission, string nom,float solde):base(nom,solde)
        {
            this.comission = comission;
        }
        public new void Depot(float montant)
        {
            base.Depot(montant);
            solde -= comission;
            Console.WriteLine($"le nouveau solde apres le depot et la comission est {solde}");
        }
        public new void Retrait(float montant)
        {
            base.Depot(montant);
            solde -= comission;
            Console.WriteLine($"le nouveau solde apres le retrait et la comission est {solde}");
        }
        public new float getSolde()
        {
            return solde;
        }
    }
}
