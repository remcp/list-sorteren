void PrintNames(List<string> friends)
{
    foreach (string friend in friends)
    {
        Console.WriteLine(friend);
    }
}
List<string> friends = new List<string>();



friends.Add("Stijn");
friends.Add("Tijl");
friends.Add("Yermo");
friends.Add("Max");
friends.Add("Tijs");
friends.Add("Ralf");
friends.Add("Andrei");
friends.Add("Michele");



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
