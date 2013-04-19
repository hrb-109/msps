using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CycloComputer
{
    public interface ICidloData
    {
        float GetKadence();

        float GetTeplota();

        float GetVzdalenostOdPoslednihoMereni();
    }
}
