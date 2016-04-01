
/*https://gist.github.com/adrenalinehit/a4e2684a0b3b0a49b48e#file-mqtt-publisher-cs*/
/*https://code.msdn.microsoft.com/windowsapps/M2Mqtt-MQTT-client-library-ac6d3858*/
/*https://www.symantec.com/content/en/us/enterprise/verisign/roots/VeriSign-Class%203-Public-Primary-Certification-Authority-G5.pem*/
/*http://docs.aws.amazon.com/iot/latest/developerguide/verify-pub-sub.html*/
/*https://m2mqtt.wordpress.com/m2mqtt-and-amazon-aws-iot/*/
using MQTT.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTT
{
    public partial class Form1 : Form
    {
        MqttClient mqttclient = null;
        byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE };
        byte qosLevel = MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE;
        //string rootCA = "MQTT-Server.pem";
        bool go = true;

        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void SetText(string text)
        {
            try
            {
                if (this.Messages.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { text });
                }
                else
                    Messages.AppendText(text + "\r\n");
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message, "Urgh!", MessageBoxButtons.OK);
            }
        }

        private void Go_Click(object sender, EventArgs e)
        {
            try
            {

                if (go)
                {
                    Go.Text = "Unsubscribe";
                    go = false;
                    //var clientCert = new X509Certificate2("0a949dec83.pfx", "xxx");
                    //var caCert = X509Certificate.CreateFromSignedFile(rootCA);
                    // create the client
                    //mqttclient = new MqttClient(Broker.Text, int.Parse(Port.Text), true, caCert, clientCert, MqttSslProtocols.TLSv1_2);
                    mqttclient = new MqttClient(Broker.Text);

                    // Set the message receive event
                    mqttclient.MqttMsgPublishReceived +=
                        client_MqttMsgPublishReceived;

                    // Connect to the broker
                    string clientId = Guid.NewGuid().ToString();
                    mqttclient.Connect(clientId);

                    // Subscribe messages
                    mqttclient.Subscribe(new string[] { Subscribe.Text },
                        new byte[] { qosLevel });
                }
                else
                {
                    Go.Text = "Subscribe";
                    go = true;
                    mqttclient.Unsubscribe(new string[] { Subscribe.Text });
                    mqttclient.Disconnect();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Urgh!", MessageBoxButtons.OK);
            }
        }

        void client_MqttMsgPublishReceived(object sender,
            MqttMsgPublishEventArgs e)
        {
            // The MQTT lib engine runs in another tread, so it´s necessary 
            // to do some trick to update Messages.Text property.
            // See SetText above.
            SetText(e.Topic + "/" + System.Text.Encoding.Default.GetString(e.Message));
        }



        private void Publish_Click(object sender, EventArgs e)
        {
            try
            {
                //var clientCert = new X509Certificate2("0a949dec83.pfx", "xxx");
                //var caCert = X509Certificate.CreateFromSignedFile(rootCA);
                // create the client
                //var client = new MqttClient(Broker.Text, int.Parse(Port.Text), true, caCert, clientCert, MqttSslProtocols.TLSv1_2);
                var client = new MqttClient(Broker.Text);

                // Connect to the broker
                string clientId = Guid.NewGuid().ToString();
                client.Connect(clientId);

                // publish a message on topic with QoS 2 
                //client.Publish(Subscribe.Text, Encoding.UTF8.GetBytes(Message.Text), qosLevel, true);
                client.Publish(Subscribe.Text.Replace("#", string.Empty), Encoding.UTF8.GetBytes(Message.Text));
                client.Unsubscribe(new string[] { Subscribe.Text });
                //client.Disconnect();
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message, "Urgh!", MessageBoxButtons.OK);
            }
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            Messages.Text = string.Empty;
        }

        private void Port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&&
             (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }

        }

    }
}
