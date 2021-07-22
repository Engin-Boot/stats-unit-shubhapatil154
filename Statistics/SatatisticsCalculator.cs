using System;
using System.Collections.Generic;

namespace Statistics
{  
    public class StatisticsCalculator
    {   
        //Assigning default values to compare the values
        public float averageValue = 0;     
        public float minValue = float.MaxValue;
        public float maxValue = float.MinValue;
        
        public void CalculateStatistics(List<float> listOfValues) {
            
            float sumOfValues = 0;
            for(int i = 0; i < listOfValues.Count; i++)
            {
                //Finding the sum of all the values to calculate the average
                sumOfValues += listOfValues[i];

                 //Finding the Maxvalue value in the list
                if(listOfValues[i] > maxValue){
                    maxValue = listOfValues[i];
                }
                //Finding the Minimum value in the list
                if(listOfValues[i] < minValue)
                {
                    minValue = listOfValues[i];
                }
                
            }
            //Calculating the average of the list values
            averageValue = sumOfValues/listOfValues.Count;

        }
    }

}