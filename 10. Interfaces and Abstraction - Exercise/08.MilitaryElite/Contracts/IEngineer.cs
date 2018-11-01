using System.Collections;
using System.Collections.Generic;
using MilitaryElite.Contracts;

namespace MilitaryElite.Contracts
{
    public interface IEngineer : ISpecialisedSoldier
    {
        ICollection<IRepair> Repairs { get; set; }
    }
}
