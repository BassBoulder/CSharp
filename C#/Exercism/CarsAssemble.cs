using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double successRate;
        
        if ( speed >= 10 ){
            successRate = (double)0.77;
        }
        else if ( speed == 9 ){
            successRate = (double)0.80; 
        }
        else if ( speed >= 5 && speed <= 8 ){
            successRate = (double)0.90; 
        }
        else if ( speed >= 1 && speed <= 4 ){
            successRate = (double)1.00; 
        }
        else { successRate = (double)0.00; }
        
        return successRate;
        }
    
    public static double ProductionRatePerHour(int speed)
    {
        return (speed * SuccessRate(speed)) * 221;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
    }
}
