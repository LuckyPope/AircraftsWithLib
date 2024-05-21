namespace Aircrafts;

public class Plane : Aircraft
{
    private int _runwayLength;
    
    public Plane(int runwayLength, int flightAltitude, bool isNeedRunway = true) : base(flightAltitude, isNeedRunway)
    {
        this._runwayLength = runwayLength;
    }
    
    public override bool Boarding(int runwayLength)
    {
        return IsNeedRunway && runwayLength >= _runwayLength;
    }

    public override bool Takeoff(int runwayLength)
    {
        return IsNeedRunway && runwayLength >= _runwayLength;
    }
}