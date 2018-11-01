using System.Collections.Generic;
using System.Linq;
using MilitaryElite.Contracts;
using MilitaryElite.Enums;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private ICollection<IRepair> repairs;

        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<IRepair>();
        }

        public ICollection<IRepair> Repairs
        {
            get;
            set;
        }

        public override string ToString()
        {
            var result = base.ToString() + "\nRepairs:";

            foreach (var r in Repairs)
            {
                result += $"\n{r}";
            }
            return result;
        }
    }
}