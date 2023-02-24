/***********************************************************************
 * Module:  PacijentController.cs
 * Purpose: Definition of the Class Controller.PacijentController
 ***********************************************************************/

using Model;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class PacijentController
   {
        public Service.PacijentService pacijentService;
        public PacijentController()
        {
            pacijentService = new PacijentService();
        }

        public List<Feedback> PrikaziKomentare()
        {
            List<Feedback> uneti_komentari = new List<Feedback>();
            uneti_komentari = pacijentService.PrikaziKomentare();
            return uneti_komentari;
        }
        public List<Feedback>  DodajKomentar(String uneti_komentar)
        {
            List<Feedback> uneti_komentari = new List<Feedback>();
            uneti_komentari = pacijentService.DodajKomentar(uneti_komentar);
            return uneti_komentari;
        }

        public void RegistrujPacijenta(String ime,String prezime,String email,String korisnicko_ime,String lozinka)
      {
            pacijentService.RegistrujPacijenta(ime, prezime, email, korisnicko_ime, lozinka);
        // return null;
      }

        public List<Pacijent> IzlistajPacijente()
        {
            List<Pacijent> lista_pacijenata = new List<Pacijent>();
            lista_pacijenata = pacijentService.IzlistajPacijente();
            return lista_pacijenata;
        }

        public List<Pacijent> ZakaziOperaciju(String ime, String prezime, String datumoperacije, String vremeoperacije, String oznaka)
        {
            List<Pacijent> lista_pacijenata = new List<Pacijent>();
            lista_pacijenata = pacijentService.ZakaziOperaciju(ime, prezime, datumoperacije, vremeoperacije, oznaka);
            return lista_pacijenata;
        }


    }
}