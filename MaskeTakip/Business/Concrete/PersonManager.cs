using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
// Concrete Klasoru soyut nesneleri ve ona ait olacak islemleri tutar
namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        //Encapsulation : metodlarin parametrelerinin nesnelere bagli calimasi`
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName,person.LastName, person.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
    