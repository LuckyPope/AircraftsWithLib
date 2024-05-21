namespace Aircrafts;

public class Helicopter(int flightAltitude, bool isNeedRunway = false) : Aircraft(flightAltitude, isNeedRunway)
{
    public override bool Boarding(int runwayLength)
    {
        return true;
    }

    public override bool Takeoff(int runwayLength)
    {
        return true;
    }
}