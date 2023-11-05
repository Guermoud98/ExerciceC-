using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Heritage
{
    internal class Compte
    {
        protected string nom;
        protected float solde = 0;
        protected static int code;
        public Compte(string nom, float solde)
        {
            this.nom = nom;
            this.solde = solde;
            code++;
        }
        public void Depot(float montant)
        {
            solde += montant;
            Console.WriteLine($"votre solde après le depot est {solde}");
        }
        public void Retrait(float montant)
        {
            solde -= montant;
            Console.WriteLine($"votre solde après le retrait est {solde}");
        }public override string ToString()
        {
            return $"votre solde est: {solde}";
        }
        public override bool Equals(Object obj)
        {
            if (obj == null || this.GetType() != obj.GetType()) return false;
            Compte c = (Compte)obj;
            return (this.solde == c.solde && this.nom == c.nom);
        }
        public float getSolde()
        {
            return solde;
        }
    }
}
