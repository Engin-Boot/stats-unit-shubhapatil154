using System;
using System.Collections.Generic;

namespace Statistics
{  
    public class StatisticsCalculator
    {        
        public float minValue;
        public float maxValue;
        public float averageValue;
        public void CalculateStatistics(List<float> listOfValues) {
            //Assigning default values to compare the values
            float  minValue = float.MaxValue, maxValue = float.MinValue, averageValue = 0;
            float sumOfValues = 0;
            for(int i = 0; i < listOfValues.Count; ++i)
            {
                //Finding the sum of all the values to calculate the average
                sumOfValues += listOfValues[i];

                //Finding the Minimum value in the list
                if(listOfValues[i] < minValue)
                {
                    minValue = listOfValues[i];
                }

                //Finding the Maxvalue value in the list
                if(listOfValues[i] > maxValue){
                    maxValue = listOfValues[i];
                }
                
            }
            //Calculating the average of the list values
            averageValue = sumOfValues/listOfValues.Count;

        }
    }

}