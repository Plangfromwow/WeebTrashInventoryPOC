using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using WeebTrashInventoryPOC.Models;

string csvPath = ".\\CSVs";
string newCsv = csvPath + "\\testOutput.csv"; 

List<WhatNotItem> list = new List<WhatNotItem>();
//Reading from a CSV 
using (var reader = new StreamReader($"{csvPath}\\Copy_of_Whatnot_quick_add_CSV_format_-_Template_2.csv"))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    try
    {
        var records = csv.GetRecords<WhatNotItem>();
        list.AddRange(records);

    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.WriteLine($"List started:");
foreach (var item in list)
{
    Console.WriteLine(item.ToString());
}



// Writing to a CSV 

using(var writer = new StreamWriter(newCsv))
using(var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
{
    csv.WriteRecords(list);
}

//Append to an existing file 

var appendConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    //Don't write the headers again.
    HasHeaderRecord = false,
};


using (var stream = File.Open(newCsv, FileMode.Append))
using (var writer = new StreamWriter(stream))
using (var csv = new CsvWriter(writer, appendConfig))
{
    csv.WriteRecords(list);
}


