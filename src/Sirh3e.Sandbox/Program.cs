using System;
using Sirh3e.Pattern.Pipeline.Test.Pipeline.Converter;

namespace Sirh3e.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var converterPipeline = new ConverterPipeline();

            var number = converterPipeline.Process("aA");

            Console.WriteLine(number);
        }
    }
}