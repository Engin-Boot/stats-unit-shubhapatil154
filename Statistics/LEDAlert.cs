using System;
using System.Collections.Generic;

namespace Statistics
{
    //Class to send Led bulb alerts
    public class LEDAlert : IAlerter
    {
        //variable to store the state of the led bulb
        public bool ledBulbGlows;
        //setting flase by default using constructor
        public LEDAlert(){
            ledBulbGlows = false;
        }
            //Changing the state of the led bulb if the value is above the threshold
        public void sendAlerts()
        {
            ledBulbGlows = true;
        }
    }
    
}