using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credential.Builder.ComputerBuilder.Models
{
    public partial class Computer
    {
        public string? Cpu { get; set; }
        public string? Gpu { get; set; }
        public string? Ram { get; set; }
        public string? Monitor { get; set; }
        public double Price { get; set; }

        private Computer()
        {

        }

        public override string ToString()
        {
            return $" GPU : {Gpu}\n CPU : {Cpu}\n RAM : {Ram}\n Monitor : {Monitor}\n Price : {Price}";
        }

        public static ComputerBuilder GetBuilder()
        {
            return new ComputerBuilder();
        }

        public class ComputerBuilder
        {
            private Computer _computer;
            public ComputerBuilder()
            {
                _computer = new Computer();
            }
            public ComputerBuilder SetCpu(string cpu)
            {
                _computer.Cpu = cpu;
                return this;
            }

            public ComputerBuilder SetGpu(string gpu)
            {
                _computer.Gpu = gpu;
                return this;
            }

            public ComputerBuilder SetRam(string ram)
            {
                _computer.Ram = ram;
                return this;
            }

            public ComputerBuilder SetMonitor(string monitor)
            {
                _computer.Monitor = monitor;
                return this;
            }

            public ComputerBuilder SetPrice(double price)
            {
                _computer.Price = price;
                return this;
            }

            public Computer Build()
            {
                return _computer ?? new Computer();
            }
        }
    }
}
