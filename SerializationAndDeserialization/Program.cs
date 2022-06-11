using System;
namespace SerializationAndDeserialization;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome To the Program\n");
        Console.WriteLine("1.Serialization in xml\n2.Deserialization in xml");
        Serialization serializeDeserialize = new Serialization();

        bool check = true;
        while (check)
        {
            Console.WriteLine("\nEnter Above option");
            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:

                    serializeDeserialize.Serializedata();
                    break;
                case 2:

                    Deserialization deserialization = new Deserialization();
                    deserialization.Deserialize();
                    break; ;
            }
        }
    }
}