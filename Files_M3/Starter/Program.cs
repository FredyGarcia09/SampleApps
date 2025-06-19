
using Files_M3;

using System;
using System.IO;
using System.Text;
using System.Text.Json;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Create a performance baseline by loading data synchronously.");

        // Create Bank objects
        Bank bank1 = new Bank(); // Bank object to load data synchronously
        Bank bank2 = new Bank(); // Bank object to load data asynchronously
        Bank bank3 = new Bank(); // Bank object to load data asynchronously and in parallel

        // get the time before loading the data
        DateTime timeBeforeLoadCall = DateTime.Now;

        // Load the customer data from the file
        LoadCustomerLogs.ReadCustomerData(bank1);

        // get the time after loading the data
        DateTime timeAfterLoadCall = DateTime.Now;

        // calculate the time taken to load the data
        TimeSpan timeTakenToReturn = timeAfterLoadCall - timeBeforeLoadCall;
        Console.WriteLine($"\nPerformance baseline: time taken to return to Main: {timeTakenToReturn.TotalSeconds} seconds");

    }
}
