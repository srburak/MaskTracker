using Business.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicanteService _applicanteService;

        public PttManager(IApplicanteService applicanteService)
        {
            _applicanteService = applicanteService;
        }

        public void GiveMask(Person person)
        {

            if(_applicanteService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "  için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + "  için maske VERİLEMEDİ");
            }
        }
    }
}
