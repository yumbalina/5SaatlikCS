using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Interface nedir?
//Bagimliligi cozmek icin kullanilir
namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GetList();


        bool CheckPerson(Person person);
    }
}
