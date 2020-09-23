using System;

namespace Garden
{
    class Program
    {

        static double FindAreaOfGarden()
        {
            var lengthOfGarden = Convert.ToDouble(Console.ReadLine());
            var lengthOfRope = Convert.ToDouble(Console.ReadLine());
            double areaOfGarden;

            //if rope length >= square diagonal/2 
            if (lengthOfRope >= (lengthOfGarden / 2 * Math.Sqrt(2)))
            {
                areaOfGarden = lengthOfGarden * lengthOfGarden;
            }
            else
            {
                if (lengthOfRope <= lengthOfGarden / 2)
                {
                    areaOfGarden = Math.PI * lengthOfRope * lengthOfRope;
                }
                else
                {
                    var angleOfSector = Math.Acos(Math.Cos(lengthOfGarden / 2 / lengthOfRope * Math.PI / 180)) * 180 / Math.PI;
                    var areaOfFirstSector = lengthOfGarden / 4 * Math.Sqrt((lengthOfRope * lengthOfRope) - (lengthOfGarden * lengthOfGarden / 4));
                    var areaOfSecondSector = Math.PI * lengthOfRope * lengthOfRope * angleOfSector / 360;
                    areaOfGarden = 4 * (areaOfFirstSector + areaOfSecondSector);
                }
            }

            return areaOfGarden;
        }
    }
}
