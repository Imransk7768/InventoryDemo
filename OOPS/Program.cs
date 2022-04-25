using System;

namespace OOPS 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>  Welcome To Inventory  <<<<");
            const string INVENTORY_DATA_PATH = @"H:\Assignments\Object Oriented Programs\OOPS\InventoryManagement\Inventory.json";
            InventoryManagement InData = new InventoryManagement();

            Random random = new Random();
            bool check = true;
            while (check)
            {
                Console.WriteLine("1.Displat Data");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        InData.DisplayInventory(INVENTORY_DATA_PATH);
                        break;
                    case 2:
                        Console.WriteLine("Exited");
                        break;
                }

            }
        }
    }
}