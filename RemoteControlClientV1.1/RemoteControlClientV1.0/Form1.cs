using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SlimDX.DirectInput;
using System.Runtime.InteropServices;

namespace RemoteControlClientV1._0
{
    public partial class RCC : Form
    {
        //Create Threads
        Thread Server_Thread;
        Thread Controller_Thread;

        //Create Client
        TcpClient client;
        NetworkStream stream;

        //Variables
        public String DatenZuClient; //Puts together throttle and steering value in one string
        public String responseData = String.Empty;
        public bool connected = false; //Is going true once connected succesfully

        //Variables for the gamepad
        DirectInput Input = new DirectInput();
        SlimDX.DirectInput.Joystick stick;
        Joystick[] Sticks;
        public int yValue = 0;
        public int xValue = 0;
        public int zValue = 0;

        public string datenvor = null;
        public string datenjetzt = null;

        public RCC()
        {
            InitializeComponent();

            //Needed for the gamepad
            GetSticks();
            Sticks = GetSticks();
        }

        private void btc_connect_Click(object sender, EventArgs e)
        {
            //Starts server thread
            Server_Thread = new Thread(ClientTask);
            Server_Thread.Start();
        }

        private void ClientTask()
        {
            string message = "Hello from Client";
            string server;

            try
            {
                // Create a TcpClient.
                Int32 port = Int32.Parse(tb_port.Text);
                server = tb_ip.Text;
                client = new TcpClient(server, port);

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                stream = client.GetStream();

                //Change button to green to show connection status
                btc_connect.Invoke(new MethodInvoker(color_green));
                btc_connect.Invoke(new MethodInvoker(enableElements));
                connected = true;

                // Receive the TcpServer.response.
                // Buffer to store the response bytes.
                data = new Byte[256];

                // String to store the response ASCII representation.
                responseData = String.Empty;

                Int32 bytes;

                //Do send data and never stop
                while (true)
                {
                    try
                    {
                        if ((bytes = stream.Read(data, 0, data.Length)) != 0)
                        {
                            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                            //Output the data over two threads
                            tb_output.Invoke(new MethodInvoker(writeoutput));
                            this.Invoke(new MethodInvoker(refresher));
                        }
                    }
                    catch (System.IO.IOException)
                    {
                        //System.Diagnostics.Debug.WriteLine("Client disconnected!");
                        client.Close();
                        MessageBox.Show("Disconnected from server!\r\n\r\n", "System.IO.IOException", MessageBoxButtons.OK);
                    }
                    catch (SocketException) //unnecessary?
                    {
                        //MessageBox.Show("SocketException", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            catch (ArgumentNullException ee)
            {
                System.Diagnostics.Debug.WriteLine("ERROR");
            }
            catch (SocketException ee)
            {
                System.Diagnostics.Debug.WriteLine("ERROR");
            }
        }

        private void SendToClient(string message)
        {
            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

            // Get a client stream for reading and writing.
            try
            {
                stream = client.GetStream();
            }
            catch (System.ObjectDisposedException)
            {
                MessageBox.Show("No answer from server.", "Error", MessageBoxButtons.OK);
                //exit = true;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("No answer from server.", "Error", MessageBoxButtons.OK);
                //exit = true;
            }

            stream.Write(data, 0, data.Length);
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            SendToClient("LIGHTON");
        }

        //Anonymously methods for change data between two threads
        private void color_green()
        {
            btc_connect.BackColor = Color.DarkOliveGreen;
        }

        private void color_red()
        {
            btc_connect.BackColor = Color.IndianRed;
        }

        private void btn_test2_Click(object sender, EventArgs e)
        {
            SendToClient("LIGHTOFF");
        }

        private void btn_calesc_Click(object sender, EventArgs e)
        {
            SendToClient("CALESC");
        }

        private void writeoutput()
        {
            //tb_output.Text += responseData + "\r\n";
            //tb_output.ScrollToCaret();
            tb_output.AppendText(responseData + "\r\n");
        }

        //Show text
        private void refresher()
        {
            this.Refresh();
        }

        private void writex()
        {
            tb_x.Text = xValue.ToString();
        }

        private void writey()
        {
            tb_y.Text = yValue.ToString();
        }

        private void writez()
        {
            tb_z.Text = zValue.ToString();
        }

        private void enableElements()
        {
            btn_test.Enabled = true;
            btn_test2.Enabled = true;
            btn_calesc.Enabled = true;
        }

        //End Anonym | Begin Controller

        //Own mapping function
        private static int map(int value, int fromLow, int fromHigh, int toLow, int toHigh)
        {
            return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
        }

        private void RCC_Load(object sender, EventArgs e)
        {
            Joystick[] joystick = GetSticks();
        }

        public Joystick[] GetSticks()
        {
            List<SlimDX.DirectInput.Joystick> sticks = new List<SlimDX.DirectInput.Joystick>();
            foreach (DeviceInstance device in Input.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly))
            {
                try
                {
                    stick = new SlimDX.DirectInput.Joystick(Input, device.InstanceGuid);
                    stick.Acquire();

                    foreach (DeviceObjectInstance deviceObject in stick.GetObjects())
                    {
                        if ((deviceObject.ObjectType & ObjectDeviceType.Axis) != 0)
                        {
                            stick.GetObjectPropertiesById((int)deviceObject.ObjectType).SetRange(-100, 100);
                        }
                    }
                    sticks.Add(stick);
                }
                catch (DirectInputException)
                {

                }
            }
            return sticks.ToArray();
        }

        void stickHandle(Joystick stick, int id)
        {
            JoystickState state = new JoystickState();
            state = stick.GetCurrentState();

            yValue = state.Y;
            xValue = state.X;
            zValue = state.Z;
            

            bool[] buttons = state.GetButtons();

            if (id == 0)
            {
                if (buttons[0])
                {
                    //Do stuff
                }
            }

        }

        private void btn_controllerconnect_Click(object sender, EventArgs e)
        {
            //Start server Thread
            Controller_Thread = new Thread(ControllerTask);
            Controller_Thread.Start();
            btn_controllerconnect.Enabled = false;
            btn_controllerconnect.BackColor = Color.DarkOliveGreen;
        }


        private void ControllerTask()
        {
            while (true)
            {
                int writesteering;
                int writethrottle;

                //Update the textboxes
                this.Invoke(new MethodInvoker(writex));
                this.Invoke(new MethodInvoker(writey));
                this.Invoke(new MethodInvoker(writez));

                //Translates the gampad inputy -100/100 to 10 to 90 (better to read for raspi xx|xx, can cut the string in half, first steering angle second throttle value)
                writesteering = map(xValue, -100, 100, 10, 90);
                writethrottle = map(zValue, -100, 0, 90, 10);

                //Sends data to the server if connected and changes are made (saves some overhead)
                //System.Diagnostics.Debug.WriteLine(writesteering.ToString() + writethrottle.ToString());
                if (connected)
                {
                    if (writesteering >= 10 && writesteering <= 90 && writethrottle >= 10 && writethrottle <= 90)
                    {
                        datenjetzt = writesteering.ToString() + writethrottle.ToString();
                        if (!String.Equals(datenvor, datenjetzt))
                        {
                            datenvor = writesteering.ToString() + writethrottle.ToString();
                            SendToClient(datenvor);
                            System.Diagnostics.Debug.WriteLine(writesteering.ToString() + writethrottle.ToString());
                        }
                        else
                        {
                            //datenvor = writesteering.ToString() + writethrottle.ToString();
                        }
                    }
                }

                for (int i = 0; i < Sticks.Length; i++)
                {
                    stickHandle(Sticks[i], i);
                }
            }
        }

        private void RCC_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Shut down server savely
            try
            {
                client.Close();
            }
            catch (System.NullReferenceException)
            { }
        }
    }
}
