using System;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class

    private int speed;
    private int batteryDrain;
    private int distance;
    private int battery;

    public RemoteControlCar(int carSpeed, int carBatteryDrain){
        speed = carSpeed;
        batteryDrain = carBatteryDrain;
        battery = 100;
    }

    public bool BatteryDrained() => battery < batteryDrain;

    public int DistanceDriven() => distance;

    public void Drive() {
        if (!BatteryDrained() && battery >= batteryDrain){
            distance += speed;
            battery -= batteryDrain;
        }
    }
    
    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class

    private int distance;

    public RaceTrack (int raceTrackDistance){
        distance = raceTrackDistance;
    }

    public bool TryFinishTrack(RemoteControlCar car){
        while (!car.BatteryDrained()){
            car.Drive();
        }
        return car.DistanceDriven() >= distance;
    }
}