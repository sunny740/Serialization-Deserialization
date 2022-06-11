﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization
{
    public class Deserialization
    {
        public void Deserialize()
        {
            FileStream fileStream = new FileStream(@"E:\BridgeLabzProject\Serialization&Deserialization\Serialization-Deserialization\SerializationAndDeserialization\Example.txt", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserialization = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"AppName:-{deserialization.AppName}--AppId:-{deserialization.AppId}");
        }
    }
    [Serializable]
    public class Demos
    {
        public string AppName { get; set; } = "Binary Deserialize";
        public int AppId { get; set; } = 1001;
    }

}

