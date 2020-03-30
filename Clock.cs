namespace ClockV10
{
    public class Clock
    {
      private int timeinmin;
      private int min;
     
      
public void Settime(int hours, int min)
{
timeinmin = 60 * hours + min;
}
public void plus()
{
    min = min + 1;
}
    }
}