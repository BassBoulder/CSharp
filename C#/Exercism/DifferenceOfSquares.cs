public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int squareOfSum = 0;
        
        for(int i = 0; i <= max; i++){
            squareOfSum += i;
        }
        return squareOfSum * squareOfSum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sumOfSquares = 0;

        for(int i = 0; i <= max; i++){
            sumOfSquares += i * i;
        }
        return sumOfSquares;
    }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}