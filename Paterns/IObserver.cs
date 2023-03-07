using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Patern
{
    public interface IObserver
    {
       void Update(float temp, float humidity, float pressure);
    }
}
