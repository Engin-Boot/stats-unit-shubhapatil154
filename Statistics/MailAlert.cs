using System;
using System.Collections.Generic;

namespace Statistics
{


    //Class to send Mail alerts
    public class MailAlert : IAlertSender
    {
        //Variable to store the state of the mail alert
        public bool emailAlertSent;
        //Setting the default value to false
        public MailAlert(){
            emailAlertSent = false;
        }
        //Changing the state of the mail alert if the value is above the threshold
        public void sendAlerts()
        {
            emailAlertSent = true;
        }
    }
    
}