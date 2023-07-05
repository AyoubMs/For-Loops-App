


//for (int i = 0; i < length; i++)
//{

//}

//string data = "Tim,Sue,Bob,Jane,Frank";
//List<string> firstNames = data.Split(',').ToList();

//for (int i = 0; i < firstNames.Count; i++)
//{
//    Console.WriteLine(firstNames[i]);
//}


List<decimal> charges = new();

charges.Add(13.5m);
charges.Add(13.25m);
charges.Add(13.5m);
charges.Add(13.5m);

decimal total = 0;

for (int i = 0; i < charges.Count; i++)
{
    total += charges[i];
}

Console.WriteLine($"Our total charge is {total}");
