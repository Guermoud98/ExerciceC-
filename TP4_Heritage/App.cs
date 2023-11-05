using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Heritage
{
    internal class App
    {
        static void Main(string[] args)
        {
            Compte c = new Compte("maria", 2000);
            CompteEpargne compteE = new CompteEpargne(15, "manal", 1500);
            ComptePayant compteP = new ComptePayant(5, "annie", 4000);
            c.Depot(200);
            compteE.Depot(100);
            compteP.Depot(200);
            compteE.calculInteret();
            Console.WriteLine($"Le solde du compte est: {c.getSolde()}");
            Console.WriteLine($"Le solde du compte Epargne est: {compteE.getSolde()}");
            Console.WriteLine($"Le solde du compte Payant est: {compteP.getSolde()}");
        }
    }
}
