﻿using System.IO;

class CE_Easy_ArmstrongNumbers
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                System.Console.WriteLine(line.Equals(SumOfDigitsToPower(line, line.Length)));
            }
    }

    private static string SumOfDigitsToPower(string num, int power)
    {
        int sum = 0;

        foreach (char d in num)
        {
            sum += (int)System.Math.Pow(d - '0', power);
        }

        return sum.ToString();
    }
}