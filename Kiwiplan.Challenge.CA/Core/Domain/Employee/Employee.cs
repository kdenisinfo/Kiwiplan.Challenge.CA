using Kiwiplan.Challenge.CA.Core.Domain.Individual;

namespace Kiwiplan.Challenge.CA.Core.Domain
{
    public class Employee : IndividualBase
    {
        public uint ManagerId { get; set; }
    }
}
