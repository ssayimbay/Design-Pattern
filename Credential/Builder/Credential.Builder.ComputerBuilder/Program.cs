using Credential.Builder.ComputerBuilder.Models;

var computerBuilder = Computer.GetBuilder();

var computer = computerBuilder.SetCpu("4 CORE")
                              .SetGpu("8 GB 256 bit")
                              .SetRam("8 GM RAM")
                              .SetMonitor("24' Monitor")
                              .SetPrice(9000)
                              .Build();

Console.WriteLine(computer);

Console.ReadLine();
