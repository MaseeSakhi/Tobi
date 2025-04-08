// int[] cards = [3, 5, 7, 8, 9];
// int[] cards2 = new int[5000000];
// for (int i = 0; i < cards2.Length; i++)
// {
//     cards2[i] = i + 1;
// }

// // int[] cards = {3, 5, 7, 8, 9};
// int query = 7;

// var result = FindCardLocation(cards, query);
// Console.WriteLine(result);
// Console.WriteLine(cards2[10]);


// int FindCardLocation(int[] cards, int query)
// {
//     /*
//     Definiere Variable "index" und initialisiere mit Wert 0
//     Wiederhole bis "index" gleich "cards" length:
//         Wenn "cards" an "index" gleich "query", dann:
//             Gebe "index" zurück
//     Inkrementiere "index" um 1
//     */
//     int index = 0;
//     while (index < cards.Length)
//     {
//         if (cards[index] == query)
//             return index;
//         index++; // index = index + 1;
//     }
//     return -1;
    
// }














int[] cards = [3, 5, 7, 8, 9,10,15,16];
int[] cards2 = new int[5000000];
for (int i = 0; i < cards2.Length; i++)
{
    cards2[i] = i + 1;
}

// int[] cards = {3, 5, 7, 8, 9};
int query = 16;


var result = FindCardLocationBinarySearch(cards, query);
Console.WriteLine(result);
Console.WriteLine(cards2[10]);
int FindCardLocationBinarySearch(int[] cards, int query)
{
    int min = 0;
    int max = cards.Length - 1;

    while (min <= max)
    {
        int mid = (min + max) / 2;

        if (query == cards[mid])
        {
            return mid;
        }
        else if (query < cards[mid])
        {
            max = mid - 1;
        }
        else
        {
            min = mid + 1;
        }
    }
    return -1;
}