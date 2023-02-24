/***********************************************************************
 * Module:  PregledService.cs
 * Purpose: Definition of the Class PregledService
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Repository;
using Service;
using Model;

namespace Service
{
   public class PregledService
   {
        Repository.PregledRepository pregledRepository;

        public PregledService()
        {
            pregledRepository = new PregledRepository();
        }


        public List<Pregled> IzlistajPreglede()
        {
            List<Pregled> lista_pregleda = new List<Pregled>();
            lista_pregleda = pregledRepository.GetPregledi();
            return lista_pregleda;
        }

        public List<Pregled> ZakaziPregled(String ime_pacijenta, String prezime_pacijenta, String datum_pregleda, String vreme_pregleda)
        {
            List<Pregled> lista_pregleda = new List<Pregled>();
            lista_pregleda = pregledRepository.SavePregled(ime_pacijenta,prezime_pacijenta,datum_pregleda,vreme_pregleda);
            return lista_pregleda;
        }

        public /*Model.Pregled*/void OtkaziPregled()
        {
            // TODO: implement
            // return null;
        }

    }
}