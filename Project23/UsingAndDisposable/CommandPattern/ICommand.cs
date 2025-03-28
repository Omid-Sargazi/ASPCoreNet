using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.CommandPattern
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}