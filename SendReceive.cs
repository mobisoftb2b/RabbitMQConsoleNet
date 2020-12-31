using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using NLog;
using RabbitMQManager;


namespace RabbitMQConsoleNet
{
    class SendReceive
    {
        RabbitMQManagersApprove m;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public SendReceive() {
            m = new RabbitMQManagersApprove();

            
            // Set up a timer that triggers every minute.
            //Timer timer = new Timer();
            //timer.Interval = 10000; // 10 seconds
            //timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            //timer.Start();
            
        }

        public void Init() {
            try
            {
                if (m.Init("") == true)
                {
                    m.ReceiveMessage();
                }
            }
            catch (Exception ex) {
                logger.Error(ex);
            }
            //m.TestFCMMessage("fqxC25wkSniw96m5i99gxD:APA91bFKbgpBNoDE2JsPn7BCaCKzNP8G5NjsUhQBLE1BerTI3gBozW1fqnEgYY1ER1Rb3ou64LyCRZii6WLHsC4nmd8cJD-XpOKhwIY49snLkQ-6PQ4_kgiKCp-4wDxfNm8diI4qXePC", "from console 2");
        }

        public void Close() {
            m.Close();
        }
        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            //m.SendMessage(System.DateTime.Now.Second.ToString());
            m.ReceiveMessage();
        }

    }

}
