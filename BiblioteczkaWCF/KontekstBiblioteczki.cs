using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BiblioteczkaWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KontekstBiblioteczki" in both code and config file together.
    public class KontekstBiblioteczki : IKontekstBiblioteczki
    {
        private List<Ksiazka> kolekcjaKsiazek;
        public KontekstBiblioteczki()
        {
            kolekcjaKsiazek = new List<Ksiazka>();
            ZaladujDane();
        }
        private void ZaladujDane()
        {
            this.Dodaj("Pan Tadeusz", "Adam Mickiewicz", 800);
            this.Dodaj("Agile. Programowanie zwinne", "Robert C. Martin", 700);
            this.Dodaj("Czysty kod", "Robert C. Martin", 400);
        }

        public void Dodaj(string tytul, string autor, int iloscStron)
        {
            int id = this.kolekcjaKsiazek.Count + 1;
            this.kolekcjaKsiazek.Add(new Ksiazka(id, tytul, autor, iloscStron));
        }

        public void Edytuj(int id, string tytul, string autor, int iloscStron)
        {
            Ksiazka ks = Pobierz(id);
            ks.Tytul = tytul;
            ks.Autor = autor;
            ks.IloscStron = iloscStron;
        }

        public void Usun(int id)
        {
            Ksiazka ks = this.Pobierz(id);
            if (ks != null)
                this.kolekcjaKsiazek.Remove(ks);
        }

        public Ksiazka Pobierz(int id)
        {
            var ksiazka = (from k in this.kolekcjaKsiazek where k.ID == id select k).FirstOrDefault();
            return ksiazka as Ksiazka;
        }

        public Ksiazka GetKsiazkaById(int id)
        {
            return kolekcjaKsiazek.FirstOrDefault(k => k.ID == id);
        }


        public List<Ksiazka> PobierzWszystkie()
        {
            return this.kolekcjaKsiazek;
        }
    }
}
