using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoullette
{
    public static class BulletLooping
    {
        public static int LoadingProcess { get; set; }//This is for loading the gun
        public static int SpinChamber { get; set; }//This is for spin the gun

        public static int ShootTime(int shootSkip)
        {
            if (shootSkip == 6)
            {
                shootSkip = 1;
            }
            else
            {
                shootSkip++;
            }
            return shootSkip;
        }
    }
}
