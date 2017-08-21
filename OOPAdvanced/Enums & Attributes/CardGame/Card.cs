using System;


public class Card : IComparable<Card>
{
    private CardRank rank;
    private CardSuit suit;

    public Card(string rank, string suit)
    {
        
        if(!Enum.TryParse(rank, out this.rank) || !Enum.TryParse(suit, out this.suit))
        {
            throw new Exception("No such card exists.");
        }
    }

    public override bool Equals(object obj)
    {
        var other = (Card)obj;
        return this.rank == other.rank && this.suit == other.suit;
    }

    public int CalcPower()
    {
        return (int)this.rank + (int)this.suit;
    }

    public int CompareTo(Card other)
    {
        return this.CalcPower().CompareTo(other.CalcPower());
    }

    public override string ToString()
    {
        return $"{this.rank} of {this.suit}";
    }
}

