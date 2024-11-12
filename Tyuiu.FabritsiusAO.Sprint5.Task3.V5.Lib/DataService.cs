﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.FabritsiusAO.Sprint5.Task3.V5.Lib
{
    public class DataService : ISprint5Task3V5
    {
        public string SaveToFileTextData(int x)
        {
            DataService ds = new();
            string path = Path.GetTempFileName();
            double F = ds.Calculate(x);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(F));
            }
            return path;
        }
        public double Calculate(int x)
        {
            double F = 2 * Math.Pow(x, 3) + (1/2) * Math.Pow(x,2) - 3.5 * x + 2;
            F = Math.Round(F, 3);
            return F;
        }
    }
}
