using System;
using Xunit;
using System.Collections.Generic;
using Statistics;

namespace Statistics.Test
{
    public class StatisticsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            #region Arrange
            var statsComputer  = new StatisticsCalculator();
            var computedStats  = new List<float>{1.5f, 8.9f, 3.2f, 4.5f};
            float epsilon = 0.001F;
            #endregion

            #region Act
            statsComputer.CalculateStatistics(computedStats);            
            #endregion

            #region Assert
            Assert.True(Math.Abs(statsComputer.averageValue - 4.525) <= epsilon);
            Assert.True(Math.Abs(statsComputer.maxValue - 8.9) <= epsilon);
            Assert.True(Math.Abs(statsComputer.minValue - 1.5) <= epsilon);
            #endregion
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            #region Arrange
            var _calculateStatsObj = new StatisticsCalculator();
            var calculatedVals = new List<float>{};
            #endregion

            _calculateStatsObj.CalculateStatistics(calculatedVals);
            
            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
        }
        [Fact]
        public void RaisesAlertsIfMaxIsMoreThanThreshold()
        {
            #region Arrange
            var mailAlert = new MailAlert();
            var ledBulbAlert = new LEDBulbAlert();
            IAlertSender[] alerts = {mailAlert, ledBulbAlert};
            const float maxThreshold = 10.2f;
            var statsAlerter = new StatisticsAlerter(maxThreshold, alerts);
            #endregion

            #region Act
            statsAlerter.checkAndSendAlert(new List<float>{0.2f, 11.9f, 4.3f, 8.5f});
            #endregion

            #region Assert
            Assert.True(mailAlert.emailAlertSent);
            Assert.True(ledBulbAlert.ledBulbGlows);
            #endregion
        }
    }
}