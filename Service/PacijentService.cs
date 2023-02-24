/***********************************************************************
 * Module:  PacijentService.cs
 * Purpose: Definition of the Class PacijentService
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model;
using Repository;
namespace Service
{
   public class PacijentService
   {
        public Repository.PacijentRepository pacijentRepository;

        public PacijentService()
        {
            pacijentRepository = new PacijentRepository();
        }

        public List<Feedback> PrikaziKomentare()
        {
            List<Feedback> uneti_komentari = new List<Feedback>();
            uneti_komentari = pacijentRepository.GetKomentari();
            return uneti_komentari;
        }

        public List<Feedback> DodajKomentar(String uneti_komentar)
        {
            List<Feedback> uneti_komentari = new List<Feedback>();
            uneti_komentari = pacijentRepository.AddKomentar(uneti_komentar);
            return uneti_komentari;
        }

        public void RegistrujPacijenta(String ime,String prezime,String email,String korisnicko_ime,String lozinka)
      {
            pacijentRepository.SetPacijent(ime, prezime, email, korisnicko_ime, lozinka);
      }

        public List<Pacijent> IzlistajPacijente()
        {
            List<Pacijent> lista_pacijenata = new List<Pacijent>();
            lista_pacijenata = pacijentRepository.GetPacijenti();
            return lista_pacijenata;
        }

        public List<Pacijent> ZakaziOperaciju(String ime, String prezime, String datumoperacije, String vremeoperacije, String oznaka)
        {
            List<Pacijent> lista_pacijenata = new List<Pacijent>();
            lista_pacijenata = pacijentRepository.SetPacijente(ime, prezime, datumoperacije, vremeoperacije, oznaka);
            return lista_pacijenata;
        }

    }
}