﻿using System.Linq; // Enumerable
using Packt.Shared; // Recorder

using static System.Console; // WriteLine()

namespace MonitoringApp
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      WriteLine("Processing. Please wait...");
      Recorder.Start();

      // simulate a process that requires some memory resources...
      int[] largeArrayOfInts = Enumerable.Range(
        start: 1, count: 10_000).ToArray();

      // ...and takes some time to complete
      System.Threading.Thread.Sleep(
        new Random().Next(5, 10) * 1000);

      Recorder.Stop();
      */

      int[] numbers = Enumerable.Range(
        start: 1, count: 50_000).ToArray();

      WriteLine("Using string with +");
      Recorder.Start();
      string s = "";
      for (int i = 0; i < numbers.Length; i++)
      {
        s += numbers[i] + ", ";
      }
      Recorder.Stop();

      WriteLine("Using StringBuilder");
      Recorder.Start();
      var builder = new System.Text.StringBuilder();
      for (int i = 0; i < numbers.Length; i++)
      {
        builder.Append(numbers[i]); builder.Append(", ");
      }
      Recorder.Stop();
    }
  }
}