using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

//Çıplak class kalmasın 
public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {
        throw new NotImplementedException();
    }

    public bool CheckPerson(Person person)
    {
        return true;
    }

    public List<Person> GetList()
    {
        return null;
    }
}
