using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CycloComputer
{
    public class Tachometr: ICidloData
    {
        public int intervalZiskavaniDat = 2000;

        public AktualniData AktualniData
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {

            }
        }

        public ICidloData CidloData
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                
            }
        }

        public NastaveniData NastaveniData
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {

            }
        }

        public TrvalaData TrvalaData
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void InitPristroj()
        {
            throw new System.NotImplementedException();
        }

        public void NactiData()
        {
            throw new System.NotImplementedException();
        }

        public void UlozNastaveni()
        {
            throw new System.NotImplementedException();
        }

        public void UlozTrvalaData()
        {
            throw new System.NotImplementedException();
        }

        public void VypisData()
        {
            throw new System.NotImplementedException();
        }

        public void ZiskavejData()
        {
            throw new System.NotImplementedException();
        }

        public void ZiskejDataZCidla()
        {
            throw new System.NotImplementedException();
        }

        public float GetKadence()
        {
            System.Random ran = new System.Random();
            float kadence = ran.Next(20, 70);

            return kadence;
        }

        public float GetTeplota()
        {
            System.Random ran = new System.Random();
            float teplota = ran.Next(10, 30);

            return teplota;
        }

        public float GetVzdalenostOdPoslednihoMereni()
        {
            throw new NotImplementedException();
        }
    }
}
