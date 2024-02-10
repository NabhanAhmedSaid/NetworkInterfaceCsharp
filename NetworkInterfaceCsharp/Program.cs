using System.Net.NetworkInformation;


NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
foreach (NetworkInterface inter in interfaces)
{
    Console.WriteLine();
    Console.WriteLine("Id: "+ inter.Id);
    Console.WriteLine("Interfaces: "+inter.Name);
    Console.WriteLine("IsReceiveOnly: " + inter.IsReceiveOnly);
    Console.WriteLine("Speed: " + inter.Speed);
    Console.WriteLine("Description: " + inter.Description);
    Console.WriteLine("Status: " + inter.OperationalStatus);
    Console.WriteLine();




}
