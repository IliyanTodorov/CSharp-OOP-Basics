using System.Collections;
using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface ICommando : ISoldier
    {
        ICollection<IMission> Missions { get; set; }
    }
}