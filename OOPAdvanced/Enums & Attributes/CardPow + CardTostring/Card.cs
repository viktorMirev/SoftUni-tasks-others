using System;

public class Card
{
    private CardRank rank;
    private CardSuit suit;

    public Card(string rank, string suit)
    {
        Enum.TryParse(rank, out this.rank);
        Enum.TryParse(suit, out this.suit);
    }

    public int CalcPower()
    {
        return (int)this.rank + (int)this.suit;
    }

    public override string ToString()
    {
        return $"Card name: {this.rank} of {this.suit}; Card power: {this.CalcPower()}";
    }
}

