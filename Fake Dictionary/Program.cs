namespace Fake_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device device1 = new Device("Laptop", "Intel i5", 8);
            Device device2 = new Device("Smartphone", "Snapdragon 888", 6);
            Device device3 = new Device("Tablet", "Apple A12", 4);

            CDictionary<string, Device> customDict = new CDictionary<string, Device>();
            customDict.Add("Device1", device1);
            customDict.Add("Device2", device2);
            customDict.Add("Device3", device3);

            customDict.DisplayAll();

            Device updatedDevice = new Device("Smartphone Pro", "Snapdragon 888+", 8);
            customDict.Update("Device2", updatedDevice);
            customDict.DisplayAll();

            customDict.Remove("Device3");
            customDict.DisplayAll();
        }
    }
}
