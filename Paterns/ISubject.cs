using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Patern
{
    public interface ISubject
    {
        public void RegistryObserver(IObserver o);

        public void RemoveObserver(IObserver o);

        public void NotifyObserver();

    }
}
