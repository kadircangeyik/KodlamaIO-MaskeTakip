using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PttManager : ISupplierService
{
    private IApplicantService _applicantService;
    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }

    public void GiveMask(Person person)
    {
        throw new NotImplementedException();
    }

    public void GİveMask(Person person)
    {
        if (_applicantService.IsExist(person))
        {
            Console.WriteLine($"Give Mask to this person {person.FirstName} {person.LastName}");
        }
        else
        {
            Console.WriteLine($"Can not give mask to this person {person.FirstName} {person.LastName}");
        }
    }
}
