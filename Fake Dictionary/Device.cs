using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake_Dictionary
{
    public class Device
    {
        private string Name { get; set; }
        private int Ram { get; set; }
        private string Cpu { get; set; }

        public Device(string name, string cpu, int ram)
        {
            this.Name = name;
            this.Ram = ram; 
            this.Cpu = cpu;
        }

        public override string ToString()
        {
            return $"Device(Name: {Name}, CPU: {Cpu}, RAM: {Ram} GB)";
        }
    }
}
