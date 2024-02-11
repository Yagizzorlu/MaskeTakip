using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)  //constructor new'lenme ile çalışır.
        {
            _applicantService = applicantService;  //Bu yüzden alt çizgi ile başlıyor constructorda onu set ediyoruz.
        }
        public void GiveMask(Person person)
        {
            // PersonManager personManager = new PersonManager();  Bu yanlış bir yöntem. PersonManager'a bağımlı olmak zorunda kalırız.

            if(_applicantService.CheckPerson(person)) 
            {
                Console.WriteLine(person.FirstName + person.LastName + " " + "için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + person.LastName + " " + "için maske verilemedi.");
            }
        }
    }
}
