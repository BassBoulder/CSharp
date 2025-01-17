class Lasagna
{
    public int ExpectedMinutesInOven(){
        return 40;
    }
    public int RemainingMinutesInOven(int minutes){
        return ExpectedMinutesInOven() - minutes;
    }
    public int PreparationTimeInMinutes(int layers){
        return layers * 2;
    }
    public int ElapsedTimeInMinutes(int layers, int minutesSoFar){
        return (PreparationTimeInMinutes(layers) + minutesSoFar);
    }
}
