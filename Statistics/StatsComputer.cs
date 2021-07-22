using System;
using System.Collections.Generic;

namespace Statistics
{  
    public class StatsComputer
    {          
        
        //Assigning default values to compare the values
        public double averageValue = 0;     
        public double minValue = float.MaxValue;
        public double maxValue = float.MinValue;
        public void CalculateStatistics(List<float> listOfValues) {
            
            double sumOfValues = 0;
            

            if(listOfValues.Count == 0){
                averageValue = Double.NaN;
                maxValue = Double.NaN;
                minValue = Double.NaN;
            }
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