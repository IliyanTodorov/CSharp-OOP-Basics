using System.Collections.Generic;
using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<IPrivate>();
        }

        public ICollection<IPrivate> Privates
        {
            get;
            set;
        }

        public override string ToString()
        {
            string result = base.ToString() + "\nPrivates:";
            foreach (var p in Privates)
            {
                result += $"\n{p}";
            }
            return result;
        }
    }
}
