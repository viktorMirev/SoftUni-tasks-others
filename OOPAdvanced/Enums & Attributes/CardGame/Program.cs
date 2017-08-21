using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        var suits = Enum.GetNames(typeof(CardSuit));
        var ranks = Enum.GetNames(typeof(CardRank));

        var deck = new List<Card>();

        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                deck.Add(new Card(rank, suit));
            }
        }

        var firstPlName = Console.ReadLine();
        var secondPlName = Console.ReadLine();

        var firstCards = new List<Card>();
        var secondCards = new List<Card>();

        while (firstCards.Count!=5)
        {
            var tokens = Console.ReadLine().Split();
            var rank = tokens[0];
            var suit = tokens[2];
            Card currCard = null;
            try
            {
                currCard = new Card(rank, suit);
                if (deck.Any(a => a.CalcPower() == currCard.CalcPower()))
                {
                    firstCards.Add(currCard);
                    deck.Remove(currCard);
                }
                else
                {
                    Console.WriteLine("Card is not in the deck.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            

        }


        while (secondCards.Count != 5)
        {
            var tokens = Console.ReadLine().Split();
            var rank = tokens[0];
            var suit = tokens[2];
            Card currCard = null;
            try
            {
                currCard = new Card(rank, suit);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (deck.Contains(currCard))
            {
                secondCards.Add(currCard);
                deck.Remove(currCard);
            }
            else
            {
                Console.WriteLine("Card is not in the deck.");
            }

        }

        var firstMax = firstCards.Max<Card>();
        var secondMax = secondCards.Max<Card>();

        if(firstMax.CompareTo(secondMax) > 0)
        {
            Console.WriteLine($"{firstPlName} wins with {firstMax}.");
        }
        else
        {
            Console.WriteLine($"{secondPlName} wins with {secondMax}.");
        }


    }
}