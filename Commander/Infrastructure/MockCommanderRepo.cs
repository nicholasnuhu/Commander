using Commander.Models;
using System.Collections.Generic;

namespace Commander.Infrastructure
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommand()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "boil an egg", Line = "Boil water", Platform = "kettle & Pan" },
                new Command { Id = 1, HowTo = "cut bread", Line = "Get a knife", Platform = "Knife & chopping board" },
                new Command { Id = 0, HowTo = "Make a cup of tea", Line = "place a teabag in cup", Platform = "kettle & cup" },

            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "boil an egg", Line = "Boil water", Platform = "kettle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}
