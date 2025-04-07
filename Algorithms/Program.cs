int[] cards = [3,5,7,8,9];
int querry =7;

var result = FindcardLocation(cards,querry);
Console.WriteLine(result);
int FindcardLocation(int[]cards,int querry)
{
   /* 
    Definiere Variable "index" und initialisiere mit Wert 0
    Wiederhole bis "index" gleich "cards" length:
        Wenn "cards" an "index" gleich "query", dann:
            Gebe "index" zurück
    Inkrementiere "index" um 1
    */
    int index=0;
    while (index<cards.Length)
    {
      if (cards[index] == querry)
            return index;
        index++;  //index =index +1
    }
    return -1;

}