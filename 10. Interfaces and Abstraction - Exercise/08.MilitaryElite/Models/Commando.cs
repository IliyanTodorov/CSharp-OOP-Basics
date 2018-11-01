using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private ICollection<IMission> _missions;

        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public ICollection<IMission> Missions { get; set; }

        public override string ToString()
        {
            var result = base.ToString() + "\nMissions:";
            foreach (var m in Missions)
            {
                result += $"\n{m}";
            }
            return result;
        }
    }
}