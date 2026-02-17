public class Activity
{
    protected string _date;
    protected int _activityLength;

    public Activity(string date, int minutes)
    {
        _date = date;
        _activityLength = minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string Getsummary()
    {
        return $"{_date} {this.GetType().Name} ({_activityLength})- Distance {GetDistance()}km, Speed: {GetSpeed()}kph, Pace: {GetPace()}min per km";
    }
}