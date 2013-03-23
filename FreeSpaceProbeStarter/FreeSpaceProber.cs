using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using Microsoft.Win32;
using System.Xml;
using System.IO;

namespace FreeSpaceProbeStarter
{
    public partial class FreeSpaceProber : Form
    {
        ServiceController[] freeSpaceProbeServiceCol;
        ServiceController proberService = null;
        string svcStatus = string.Empty;
        XmlDocument doc = new XmlDocument();
        Dictionary<string, string> ISPS = new Dictionary<string, string>();
        public FreeSpaceProber()
        {
            InitializeComponent();
            stopBtn.Enabled = false;
            freeSpaceProbeServiceCol = ServiceController.GetServices();
            foreach (var service in freeSpaceProbeServiceCol)
            {
                if (service.DisplayName == "Prober")
                {
                    proberService = service;
                    break;
                }
            }
            if (proberService != null)
            {
                serviceExistsLbl.Visible = true;
                svcStatus = proberService.Status.ToString();
                if (svcStatus == "Running")
                {
                    stopBtn.Enabled = true;
                    startBtn.Enabled = false;
                    serviceRunLbl.Visible = true;
                }

                if (File.Exists(@"C:\FreeSpaceProber\Details.xml"))
                {
                    doc.Load(@"C:\FreeSpaceProber\Details.xml");

                    nameTxtBox.Text = doc.SelectSingleNode("Person/Name/text()").InnerText;
                    emailTxtBox.Text = doc.SelectSingleNode("Person/Email/text()").InnerText;
                    destinationTxtBox.Text = doc.SelectSingleNode("Person/DestinationEmail/text()").InnerText;
                    sizeTxtBox.Text = doc.SelectSingleNode("Person/MinFreeSpace/text()").InnerText;
                }
            }
            else
                serviceNotExistsLbl.Visible = true;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (proberService != null)
            {
                if (File.Exists(@"C:\FreeSpaceProber\Details.xml"))
                {
                    doc.Load(@"C:\FreeSpaceProber\Details.xml");
                    if (doc.SelectSingleNode("Person/DestinationEmail/text()").InnerText != destinationTxtBox.Text)
                    {
                        doc.SelectSingleNode("Person/DestinationEmail/text()").InnerText = sizeTxtBox.Text;
                        doc.Save(@"C:\FreeSpaceProber\Details.xml");
                    }

                    if (doc.SelectSingleNode("Person/MinFreeSpace/text()").InnerText != sizeTxtBox.Text)
                    {
                        doc.SelectSingleNode("Person/MinFreeSpace/text()").InnerText = sizeTxtBox.Text;
                        doc.Save(@"C:\FreeSpaceProber\Details.xml");
                    }

                }
                else
                {
                    Directory.CreateDirectory(@"C:\FreeSpaceProber");
                    XmlNode Person = doc.AppendChild(doc.CreateElement("Person"));
                    XmlNode Name = Person.AppendChild(doc.CreateElement("Name"));
                    Name.InnerText = nameTxtBox.Text;
                    XmlNode Email = Person.AppendChild(doc.CreateElement("Email"));
                    Email.InnerText = emailTxtBox.Text;
                    XmlNode DestinationEmail = Person.AppendChild(doc.CreateElement("DestinationEmail"));
                    DestinationEmail.InnerText = destinationTxtBox.Text;
                    XmlNode MinFreeSpace = Person.AppendChild(doc.CreateElement("MinFreeSpace"));
                    if (sizeTxtBox.Text != null && sizeTxtBox.Text != string.Empty)
                        MinFreeSpace.InnerText = sizeTxtBox.Text;
                    else
                        MinFreeSpace.InnerText = "2"; ;
                    doc.Save(@"C:\FreeSpaceProber\Details.xml");

                }
                startBtn.Enabled = false;
                stopBtn.Enabled = true;
                serviceRunLbl.Visible = true;
                serviceNotRunLbl.Visible = false;

                if (emailTxtBox.Text != null && emailTxtBox.Text != string.Empty)
                {
                    if (svcStatus == "Stopped")
                    {
                        proberService.Start();
                    }
                }
                else
                    MessageBox.Show("אנא רשמו אי מייל");
            }
            else
                MessageBox.Show("השירות לא רץ ברקע");
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {

            string svcStatus = proberService.Status.ToString();

            if (svcStatus == "Running")
            {
                proberService.Stop();
                stopBtn.Enabled = false;
                startBtn.Enabled = true;
                serviceRunLbl.Visible = false;
                serviceNotRunLbl.Visible = true;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\FreeSpaceProber\Details.xml"))
            {
                doc.SelectSingleNode("Person/Name/text()").InnerText = nameTxtBox.Text;
                doc.SelectSingleNode("Person/Email/text()").InnerText = emailTxtBox.Text;
                doc.SelectSingleNode("Person/DestinationEmail/text()").InnerText = destinationTxtBox.Text;
                doc.SelectSingleNode("Person/MinFreeSpace/text()").InnerText = sizeTxtBox.Text;
                doc.Save(@"C:\FreeSpaceProber\Details.xml");
            }
            else
                MessageBox.Show(".קובץ פרטים לא קיים. נא למלא פרטים וללחוץ על הפעלת שירות");
        }
    }
}
