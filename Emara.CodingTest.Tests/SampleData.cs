using Emara.CustomTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emara.CodingTest.Tests
{
    static class SampleDataHelper
    {
        public static int[][] GetDataFromFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);

            int[][] data = new int[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                data[i] = Array.ConvertAll(lines[i].Split(' '), int.Parse);
            }
            return data;
        }
    }
}
