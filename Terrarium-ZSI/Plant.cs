using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrarium_ZSI
{
    public class Plant
    {
        public int MinimalnaTemperatura;
        public int MaksymalnaTemperatura;
        public int SredniaTemperatura;
        public int Wilgotnosc;

        public void SetSredniaTemperatura()
        {
            SredniaTemperatura = (MinimalnaTemperatura + MaksymalnaTemperatura) / 2;
        }
    }
}
