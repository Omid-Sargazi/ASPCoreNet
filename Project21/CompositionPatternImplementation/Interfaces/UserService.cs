using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompositionPatternImplementation.Models;

namespace CompositionPatternImplementation.Interfaces
{
    public class UserService
    {
        private readonly IRepository _repository;
        private readonly INotifier _notifier;

        public UserService(IRepository repository, INotifier notifier)
        {
            _notifier = notifier;
            _repository = repository;   
        }

        public void RegisterUser(User user)
        {
            _repository.Save(user);
            _notifier.SendNotification(user);
        }
    }
}