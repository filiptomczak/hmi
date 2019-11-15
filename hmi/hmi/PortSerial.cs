using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace hmi
{
    class PortSerial
    {
        private string PortName;
        private int BaudRate;
        private SerialPort Serialport;

        public PortSerial()
        {
            this.PortName = "COM5";
            this.BaudRate = 9600;
            this.Serialport = new SerialPort(PortName, BaudRate);
        }
        public PortSerial(string portName, int baudRate)
        {
            this.PortName = portName;
            this.BaudRate = baudRate;
            this.Serialport = new SerialPort(PortName, BaudRate);
        }
        public void sendMessage(string message)
        {
            if (!Serialport.IsOpen)
                Serialport.Open();
            Serialport.Write(message);
            Serialport.Close();
        }
        public void sendMessage(int message)
        {
            /*if (!Serialport.IsOpen)
                Serialport.Open();
            Serialport.Write(message.ToString());
            Serialport.Close();*/
        }
        public string readMessage()
        {
            string message = Serialport.ReadExisting();
            return message;
        }
    }
}
