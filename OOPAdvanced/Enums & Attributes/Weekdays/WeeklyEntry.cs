using System;

public class WeeklyEntry : IComparable<WeeklyEntry>
{
    private WeekDay weekDay;

    public WeeklyEntry(string weekday, string notes)
    {
        Enum.TryParse(weekday, out this.weekDay);

        this.Notes = notes;

    }
   
    public WeekDay WeekDay
    {
        get
        {
            return this.weekDay;
        }
        private set
        {
            this.weekDay = value;
        }
    }

    private string notes;
    public string Notes
    {
        get
        {
            return this.notes;
        }
        private set
        {
            this.notes = value;
        }
    }

    public override string ToString()
    {
        return $"{this.WeekDay} - {this.Notes}";
    }

    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }
        if(ReferenceEquals(null, other))
        {
            return 1;
        }
        var weekDayComp = this.WeekDay.CompareTo(other.WeekDay);
        if(weekDayComp == 0)
        {
            weekDayComp = string.Compare(Notes, other.notes, StringComparison.Ordinal);
        }
        return weekDayComp;
    }
}