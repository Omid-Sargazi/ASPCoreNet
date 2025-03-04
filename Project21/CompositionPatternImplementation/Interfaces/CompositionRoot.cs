using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionPatternImplementation.Interfaces
{
    public class CompositionRoot
    {
        public static UserService CreateUserService(string environment)
        {
            IRepository repository = environment == "Production" ? new DatabaseRepository() :new InMemoryRepository();

            INotifier notifier = environment == "Production" ?new EmailNotifier() : new ConsoleNotifier();

            return new UserService(repository, notifier);
        } 
    }
}