using MilitaryElite.Contracts;
using MilitaryElite.Enums;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        private string codeName;
        private State state;

        public Mission(string codeName, State state)
        {
            this.codeName = codeName;
            this.state = state;
        }

        public string CodeName
        {
            get => codeName;
            private set => codeName = value;
        }

        public State State
        {
            get => state;
            private set => state = value;
        }

        public void CompleteMission()
        {
            this.State = State.Finished;
        }

        public override string ToString()
        {
            return $"   Code Name: {this.CodeName} State: {this.State}";
        }
    }
}