namespace Aircrafts;

public abstract class Aircraft
{
    protected int FlightAltitude;
    protected bool IsNeedRunway;

    protected Aircraft(int flightAltitude, bool isNeedRunway)
    {
        this.FlightAltitude = flightAltitude;
        this.IsNeedRunway = isNeedRunway;
    }

    public abstract bool Takeoff(int runwayLength);

    public abstract bool Boarding(int runwayLength);
}