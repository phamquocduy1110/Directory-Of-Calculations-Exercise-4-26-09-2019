using System;

namespace UnitTest_Exercise2
{
    public class Average
    {
        public float average(int[] value, int minnum, int maxnum)
        {
            int i = 0;
            int inputNumber = 0;
            int validNumber = 0;
            int sum = 0;
            float my_average = 0;

            while ((value[i] != -999) && (inputNumber < 100))
            {
                inputNumber++;
                if ((value[i] >= minnum) && (value[i] <= maxnum))
                {
                    validNumber++;
                    sum += value[i];
                }
                else break;
                i++;
            }

            if (validNumber > 0)
                my_average = sum / validNumber;
            else
                my_average = -999;

            return my_average;
        }
    }
}