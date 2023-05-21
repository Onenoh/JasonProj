using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace JasonProj
{
    internal class WriteToJson
    {
        public void WriteToJsons(List<User> user)
        {
            //string fileName = "data.json";
            //string currentDir = Environment.CurrentDirectory;
            //DirectoryInfo directory = new DirectoryInfo(
            //    Path.GetFullPath(Path.Combine(currentDir, @"..\..\..\" + fileName)));

            string newpath = JsonHelper.GetPath("data.json");
            string jsonString = JsonSerializer.Serialize(user);
            using (StreamWriter writer = new StreamWriter(newpath))
            {
                writer.Write(jsonString);
            }
            Console.WriteLine("Json is written");
        }
    }
}
