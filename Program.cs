void PrintNames(List<string> friends)
{
    foreach (string friend in friends)
    {
        Console.WriteLine(friend);
    }
}
List<string> vrienden = new List<string>();



vrienden.Add("Stijn");
vrienden.Add("Antony");
vrienden.Add("Manon");
vrienden.Add("Erik");
vrienden.Add("Noah");
vrienden.Add("Steff");
vrienden.Add("Robin");
vrienden.Add("Mariska");
vrienden.Add("Lotte");
vrienden.Add("Gijs");
vrienden.Add("Max");
vrienden.Add("Samantha");
vrienden.Add("Bo");



Console.WriteLine("\nFriendHighToLow");

// De lengtes van de strings in de list worden vergeleken met elkaar, Deze worden van de hoogste lengte naar de laasgte lengte in de list gezet.
// Hierna wordt de lijst met de nieuwe volgorde uitgeprint.
vrienden.Sort((a, b) => b.Length.CompareTo(a.Length));
PrintNames(vrienden);



Console.WriteLine("\nFriendLowToHigh");
// De lengtes van de strings in de list worden vergeleken met elkaar, Deze worden van de laagste lengte naar de hoogste lengte in de list gezet.
// Hierna wordt de lijst met de nieuwe volgorde uitgeprint.
vrienden.Sort((a, b) => a.Length.CompareTo(b.Length));
PrintNames(vrienden);



Console.ReadLine();