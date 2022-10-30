using Structural.Composite.FileSystem.Models;

MyDirectory rootDir = new MyDirectory("/root");

MyDirectory devDir = new MyDirectory("Dev", rootDir);
MyDirectory serviceDir = new MyDirectory("Serivce", devDir);
MyFile file1 = new MyFile("service1.cs", serviceDir);    
MyFile file2 = new MyFile("service2.cs", serviceDir);   
MyFile file3 = new MyFile("service3.cs", serviceDir);

MyDirectory testDir = new MyDirectory("Test", devDir);
MyFile file4 = new MyFile("test1.cs", testDir);
MyFile file5 = new MyFile("test2.cs", testDir);

MyDirectory webDir = new MyDirectory("Web", devDir);
MyDirectory jsDir = new MyDirectory("Js", webDir);
MyDirectory cssDir = new MyDirectory("Css", webDir);
MyFile file6 = new MyFile("index1.js", jsDir);
MyFile file7 = new MyFile("index2.js", jsDir);
MyFile file8 = new MyFile("style1.css", cssDir);
MyFile file9 = new MyFile("style2.css", cssDir);

Console.WriteLine("########## List Root Folder #############");
rootDir.ListContainer();

Console.WriteLine("########## List Dev Folder ##############");
devDir.ListContainer();

Console.WriteLine("########## List Service Folder ##########\n");
serviceDir.ListContainer();

Console.WriteLine("########## List Test Folder #############\n");
testDir.ListContainer();

Console.WriteLine("########## List Css Folder ##############\n");
cssDir.ListContainer();

Console.WriteLine("########## List Js Folder ###############\n");
jsDir.ListContainer();

Console.WriteLine("########## MOVING #######################");
cssDir.Move(rootDir);
rootDir.ListContainer();
cssDir.ListContainer();

Console.WriteLine("########## DELETING #####################");
webDir.DeleteContainer(jsDir);
webDir.ListContainer();

Console.ReadLine();