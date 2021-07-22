using System;
using System.Collections.Generic;

namespace Statistics
{   
    //Class to validate threshold
    public class StatsAlerter
    {
        //value to store the threshold value
        public float maxThresholdValue;
        IAlerter[] alertsToBeSent;
        //setting values of max threshold and the list of alerts to be sent 
        public StatsAlerter(float maxThresholdValue, IAlerter[] alerts)
        {
            this.maxThresholdValue = maxThresholdValue;
            this.alertsToBeSent = alerts;
        }

        //function to check the values and if values are greater than threshol send alerts
        public void checkAndSendAlert(List<float> thresholdValues)
        {
            for(int i = 0; i < thresholdValues.Count; ++i){
                if(thresholdValues[i] > maxThresholdValue){
                    for(int j = 0; j < alertsToBeSent.Length; ++j){
                        //sending alert if values is greater
                        alertsToBeSent[j].sendAlerts();
                    }
                    break;
                }
            }
        }
    }
    
}