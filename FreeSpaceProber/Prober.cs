using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Net.Mail;
using System.Management;
using System.IO;
using System.Timers;
using Microsoft.Win32;
using System.Xml;

namespace FreeSpaceProber
{
    public partial class Prober : ServiceBase
    {
        private static Timer time;
        SmtpClient client = new SmtpClient();
        string email;
        string size;
        string name;
        string destinationEmail;

        public Prober()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (File.Exists(@"C:\FreeSpaceProber\Details.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\FreeSpaceProber\Details.xml");
                name = doc.SelectSingleNode("Person/Name/text()").InnerText;
                email = doc.SelectSingleNode("Person/Email/text()").InnerText;
                destinationEmail = doc.SelectSingleNode("Person/DestinationEmail/text()").InnerText;
                size = doc.SelectSingleNode("Person/MinFreeSpace/text()").InnerText;
                

                try
                {
                    SendEmail();
                    time = new Timer(10000);
                    time.Elapsed += new ElapsedEventHandler(time_Elapsed);
                    time.Interval = 43200000; // Which 12 Hours
                    time.Enabled = true;
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry(ex.Message);
                }
            }
        }

        protected override void OnStop()
        {
            time.Stop();
            time.Dispose();
        }

        void time_Elapsed(object sender, ElapsedEventArgs e)
        {
            SendEmail();
        }

        #region Method Helpers
        void SendEmail()
        {
            if (CheckFreeSpace().Count > 0)
            {
                MailMessage msg = new MailMessage(email, destinationEmail);
                msg.Subject = "Email from customer: " + name;
                msg.IsBodyHtml = true;

                foreach (string item in CheckFreeSpace())
                {
                    msg.Body = msg.Body + item + " and Minimum threshold for warning is " + size + "GB" + "<br/>";
                }
                //client.Host = "out.bezeqint.net";
                //client.Credentials = new System.Net.NetworkCredential("talvv", "2407tw");
                client.Host = "smtpcorp.com";
                client.Port = 2525;
                client.Send(msg);
            }
        }

        List<string> CheckFreeSpace()
        {
            List<string> freeSpace = new List<string>();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady && drive.Name.Contains(@"C:\") && Convert.ToInt32(drive.AvailableFreeSpace / 1073741824) < Convert.ToInt32(size)) // 1073741824 is 1GB
                    freeSpace.Add("Drive: " + drive.Name + " has " + (drive.AvailableFreeSpace / 1073741824).ToString() + "GB of free space");
            }

            return freeSpace;
        }
        #endregion

    }
}
