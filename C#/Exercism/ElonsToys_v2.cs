using System;

class RemoteControlCar
{

    private int meters = 0;
    private float percentage = 100;
    
    
    public static RemoteControlCar Buy() =>  new RemoteControlCar();

    public string DistanceDisplay()
    {
        return $"Driven {meters} meters";
    }

    public string BatteryDisplay()
    {
        return percentage > 0 ? $"Battery at {percentage}%" : "Battery empty";
    }

    public void Drive()
    {
        if (this.percentage > 0){
            this.meters += 20;
            this.percentage -= 1;
        }
    }
}
