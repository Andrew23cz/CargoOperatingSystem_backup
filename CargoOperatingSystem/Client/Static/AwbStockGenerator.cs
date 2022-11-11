using System.Collections.Generic;

namespace CargoOperatingSystem.Client.Static
{
    public static class AwbStockGenerator
    {

        public static IList<string> Generator(int awbCount, string firstNumber)
        {
            string awbNumber = firstNumber;

            List<string> awbNumbers = new List<string>();

            awbNumbers.Add(awbNumber);

            for (int i = 1; i < awbCount; i++)
            {
                int firstFour = int.Parse(awbNumber.Substring(0, 4));
                int secondThree = int.Parse(awbNumber.Substring(4, 3));
                int lastOne = int.Parse(awbNumber.Substring(7, 1));

                if (lastOne == 6)
                {
                    lastOne = 0;
                }
                else
                {
                    lastOne++;
                }

                if (secondThree == 999)
                {
                    secondThree = 000;

                    if (firstFour == 9999)
                    {
                        firstFour = 0000;
                    }
                    else
                    {
                        firstFour++;
                    }
                }
                else
                {
                    secondThree++;
                }

                string firstPart = firstFour.ToString();
                string secondPart = secondThree.ToString();
                string lastPart = lastOne.ToString();

                for (int a = firstPart.Length; a < 4; a++)
                {
                    firstPart = "0" + firstPart;
                }

                for (int b = secondPart.Length; b < 3; b++)
                {
                    secondPart = "0" + secondPart;
                }

                string result = firstPart + secondPart + lastPart;

                awbNumbers.Add(result);

                awbNumber = result;
            }


            return awbNumbers;
        }


    }
}
