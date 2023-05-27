/**************************************************************************
 *                                                                        *
 *  Description: Task Management Tool                    		          *
 *  Website Mihnea: https://github.com/Mihnea1711               	      *
 *  Website Robert: https://github.com/cioocan               	          *
 *  Copyright:   (c) 2023, Mihnea Bejinaru, Robert Ciocan                 *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using View;

namespace Project.Views.Controls.Dialogs.Tests
{
    [TestClass]
    public class HelperDialogControlTests
    {
        private HelperDialogControl helperDialogControl;

        [TestInitialize]
        public void Setup()
        {
            helperDialogControl = new HelperDialogControl();
        }

        [TestMethod]
        public void ButtonRun_Click_TimeStartedNotSet_StartTimeUpdated()
        {
            helperDialogControl.buttonRun_Click(null, EventArgs.Empty);
            DateTime expectedStartTime = DateTime.Now;
            DateTime actualStartTime = DateTime.Parse(helperDialogControl.textBoxStarted.Text);
            Assert.AreEqual(expectedStartTime.ToString("HH:mm:ss"), actualStartTime.ToString("HH:mm:ss"));
        }

        [TestMethod]
        public void ButtonRun_Click_TimeStartedNotSet_LabelTimeVisibleAndRunning()
        {
            helperDialogControl.buttonRun_Click(null, EventArgs.Empty);
            Assert.IsTrue(helperDialogControl.labelTime.Visible);
            Assert.AreEqual("\t\t\tRunning...", helperDialogControl.labelTime.Text);
        }

        [TestMethod]
        public void ButtonStop_Click_TimeStartedSet_TimeStoppedUpdated()
        {
            DateTime expectedStartTime = DateTime.Now;
            helperDialogControl.buttonRun_Click(null, EventArgs.Empty);
            helperDialogControl.buttonStop_Click(null, EventArgs.Empty);
            DateTime expectedStopTime = DateTime.Now;
            DateTime actualStopTime = DateTime.Parse(helperDialogControl.textBoxStopped.Text);
            Assert.AreEqual(expectedStopTime.ToString("HH:mm:ss"), actualStopTime.ToString("HH:mm:ss"));
        }

        // this should be false because it is expecting 1h and instead we sleep 1 sec.
        [TestMethod]
        public void ButtonStop_Click_TimeStartedSet_CorrectTimeSpanDisplayed()
        {
            DateTime startTime = DateTime.Now.AddHours(-1);
            DateTime stopTime = DateTime.Now;
            TimeSpan expectedTimeSpan = stopTime - startTime;
            helperDialogControl.buttonRun_Click(null, EventArgs.Empty);
            Thread.Sleep(1000);
            helperDialogControl.buttonStop_Click(null, EventArgs.Empty);
            string expectedTimeSpanString = $"Time passed: {expectedTimeSpan.Hours} hours, {expectedTimeSpan.Minutes} minutes, and {expectedTimeSpan.Seconds} seconds.";
            Assert.AreEqual(expectedTimeSpanString, helperDialogControl.labelTime.Text);
        }

        [TestMethod]
        public void ButtonReset_Click_TimeStartedNotSet_TimeStartedUpdated()
        {
            helperDialogControl.buttonReset_Click(null, EventArgs.Empty);
            DateTime expectedStartTime = DateTime.Now;
            DateTime actualStartTime = helperDialogControl.timeStarted;
            Assert.AreEqual(expectedStartTime.ToString("HH:mm:ss"), actualStartTime.ToString("HH:mm:ss"));
        }

        [TestMethod]
        public void ButtonReset_Click_TimeStartedNotSet_TextBoxesCleared()
        {
            helperDialogControl.buttonReset_Click(null, EventArgs.Empty);
            Assert.IsTrue(string.IsNullOrEmpty(helperDialogControl.textBoxStarted.Text));
            Assert.IsTrue(string.IsNullOrEmpty(helperDialogControl.textBoxStopped.Text));
        }

        [TestMethod]
        public void CalculateTimeSpan_ValidTimeValues_CorrectTimeSpanCalculated()
        {
            DateTime startTime = DateTime.Now.AddHours(-1);
            DateTime stopTime = DateTime.Now;
            TimeSpan expectedTimeSpan = stopTime - startTime;
            TimeSpan actualTimeSpan = helperDialogControl.CalculateTimeSpan(startTime, stopTime);
            Assert.AreEqual(expectedTimeSpan, actualTimeSpan);
        }

        [TestMethod]
        public void Initialization_TimeStartedInitializedWithNewDateTime()
        {
            Assert.AreEqual(new DateTime(), helperDialogControl.timeStarted);
        }

        [TestMethod]
        public void Initialization_TimeStoppedInitializedWithNewDateTime()
        {
            Assert.AreEqual(new DateTime(), helperDialogControl.timeStopped);
        }

        [TestMethod]
        public void ButtonRun_Click_TimeStartedAlreadySet_StartTimeNotUpdated()
        {
            DateTime startTime = DateTime.Now.AddHours(-1);
            helperDialogControl.timeStarted = startTime;
            helperDialogControl.buttonRun_Click(null, EventArgs.Empty);
            DateTime expectedStartTime = startTime;
            DateTime actualStartTime = DateTime.Parse(helperDialogControl.textBoxStarted.Text);
            Assert.AreEqual(expectedStartTime.ToString("HH:mm:ss"), actualStartTime.ToString("HH:mm:ss"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ButtonStop_Click_TimeStartedNotSet_StopTimeNotUpdated()
        {
            helperDialogControl.buttonStop_Click(null, EventArgs.Empty);
            Assert.IsFalse(string.IsNullOrEmpty(helperDialogControl.textBoxStopped.Text));
        }

        
        [TestMethod]
        public void ButtonRun_ClickAndButtonStop_Click_TimeStartedAndTimeStoppedUpdated()
        {
            helperDialogControl.buttonRun_Click(null, EventArgs.Empty);
            DateTime expectedStartTime = DateTime.Now;
            DateTime actualStartTime = DateTime.Parse(helperDialogControl.textBoxStarted.Text);
            Assert.AreEqual(expectedStartTime.ToString("HH:mm:ss"), actualStartTime.ToString("HH:mm:ss"));

            helperDialogControl.buttonStop_Click(null, EventArgs.Empty);
            DateTime expectedStopTime = DateTime.Now;
            DateTime actualStopTime = DateTime.Parse(helperDialogControl.textBoxStopped.Text);
            Assert.AreEqual(expectedStopTime.ToString("HH:mm:ss"), actualStopTime.ToString("HH:mm:ss"));
        }

        [TestMethod]
        public void ButtonRun_ClickAndButtonReset_Click_TimeStartedUpdatedAndTextBoxesCleared()
        {
            helperDialogControl.buttonRun_Click(null, EventArgs.Empty);
            DateTime expectedStartTime = DateTime.Now;
            DateTime actualStartTime = DateTime.Parse(helperDialogControl.textBoxStarted.Text);
            Assert.AreEqual(expectedStartTime.ToString("HH:mm:ss"), actualStartTime.ToString("HH:mm:ss"));

            helperDialogControl.buttonReset_Click(null, EventArgs.Empty);
            DateTime expectedResetStartTime = DateTime.Now;
            DateTime actualResetStartTime = helperDialogControl.timeStarted;
            Assert.AreEqual(expectedResetStartTime.ToString("HH:mm:ss"), actualResetStartTime.ToString("HH:mm:ss"));
            Assert.IsTrue(string.IsNullOrEmpty(helperDialogControl.textBoxStarted.Text));
            Assert.IsTrue(string.IsNullOrEmpty(helperDialogControl.textBoxStopped.Text));
        }

        [TestMethod]
        public void ButtonStop_ClickAndButtonReset_Click_TimeStartedUpdatedAndTextBoxesCleared()
        {
            DateTime startTime = DateTime.Now.AddHours(-1);
            helperDialogControl.timeStarted = startTime;

            helperDialogControl.buttonStop_Click(null, EventArgs.Empty);
            DateTime expectedStopTime = DateTime.Now;
            DateTime actualStopTime = DateTime.Parse(helperDialogControl.textBoxStopped.Text);
            Assert.AreEqual(expectedStopTime.ToString("HH:mm:ss"), actualStopTime.ToString("HH:mm:ss"));

            helperDialogControl.buttonReset_Click(null, EventArgs.Empty);
            DateTime expectedResetStartTime = DateTime.Now;
            DateTime actualResetStartTime = helperDialogControl.timeStarted;
            Assert.AreEqual(expectedResetStartTime.ToString("HH:mm:ss"), actualResetStartTime.ToString("HH:mm:ss"));
            Assert.IsTrue(string.IsNullOrEmpty(helperDialogControl.textBoxStarted.Text));
            Assert.IsTrue(string.IsNullOrEmpty(helperDialogControl.textBoxStopped.Text));
        }

        [TestMethod]
        public void CalculateTimeSpan_TimeStartedGreaterThanTimeStopped_ExceptionThrown()
        {
            DateTime timeStarted = DateTime.Parse("2023-05-25 10:00:00");
            DateTime timeStopped = DateTime.Parse("2023-05-25 09:00:00");
            Assert.ThrowsException<Exception>(() => helperDialogControl.CalculateTimeSpan(timeStarted, timeStopped));
        }

        [TestMethod]
        public void CalculateTimeSpan_TimeStartedEqualsTimeStopped_ZeroTimeSpanReturned()
        {
            DateTime timeStarted = DateTime.Parse("2023-05-25 10:00:00");
            DateTime timeStopped = DateTime.Parse("2023-05-25 10:00:00");
            TimeSpan expectedTimeSpan = TimeSpan.Zero;
            TimeSpan actualTimeSpan = helperDialogControl.CalculateTimeSpan(timeStarted, timeStopped);
            Assert.AreEqual(expectedTimeSpan, actualTimeSpan);
        }

        [TestMethod]
        public void CalculateTimeSpan_TimeStartedBeforeTimeStopped_PositiveTimeSpanReturned()
        {
            DateTime timeStarted = DateTime.Parse("2023-05-25 10:00:00");
            DateTime timeStopped = DateTime.Parse("2023-05-25 11:00:00");
            TimeSpan expectedTimeSpan = TimeSpan.FromHours(1);
            TimeSpan actualTimeSpan = helperDialogControl.CalculateTimeSpan(timeStarted, timeStopped);
            Assert.AreEqual(expectedTimeSpan, actualTimeSpan);
        }

        [TestMethod]
        public void CalculateTimeSpan_TimeStartedAndTimeStoppedWithDifferentDates_PositiveTimeSpanReturned()
        {
            DateTime timeStarted = DateTime.Parse("2023-05-25 23:59:00");
            DateTime timeStopped = DateTime.Parse("2023-05-26 00:01:00");
            TimeSpan expectedTimeSpan = TimeSpan.FromMinutes(2);
            TimeSpan actualTimeSpan = helperDialogControl.CalculateTimeSpan(timeStarted, timeStopped);
            Assert.AreEqual(expectedTimeSpan, actualTimeSpan);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CalculateTimeSpan_TimeStartedNotSet_ExceptionThrown()
        {
            DateTime timeStopped = DateTime.Parse("2023-05-25 10:00:00");
            helperDialogControl.CalculateTimeSpan(helperDialogControl.timeStarted, timeStopped);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CalculateTimeSpan_TimeDifferenceExceedsThreshold_ExceptionThrown()
        {
            DateTime timeStarted = DateTime.Parse("2023-05-25 10:00:00");
            DateTime timeStopped = DateTime.Parse("2023-05-25 10:30:00");
            TimeSpan timeSpan = helperDialogControl.CalculateTimeSpan(timeStarted, timeStopped);

            int thresholdMinutes = 15;
            if (timeSpan.TotalMinutes > thresholdMinutes)
            {
                throw new Exception($"Time difference exceeds the threshold of {thresholdMinutes} minutes.");
            }
        }
    }
}