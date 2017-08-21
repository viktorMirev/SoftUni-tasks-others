public interface IInventory
{
    long TotalStrengthBonus { get; }
    long TotalAgilityBonus { get; }
    long TotalDamageBonus { get; }
    long TotalIntelligenceBonus { get; }
    long TotalHitPointsBonus { get; }
    void AddCommonItem(IItem item);
    void AddRecipeItem(IRecipe recipe);
    
}

