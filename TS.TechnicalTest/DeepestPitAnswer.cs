namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        //check for invalid inpu

        if (points.Length < 3)
        {
            return -1;
        }

        int deepestPitDepth = -1;
        int currentIndex = 0;

        while (currentIndex < points.Length - 2)
        {


            //find potential pit start(decreasing sequence)
            int potentialPitStartValue = points[currentIndex];
            int potentialPitEndIndex = currentIndex + 1;

            while (potentialPitEndIndex < points.Length - 1 && points[potentialPitEndIndex] < points[potentialPitEndIndex - 1])
            {
                potentialPitEndIndex++;
            }

            //skip if the sequence length is less than 2
            if (potentialPitEndIndex - currentIndex < 2)
            { 
                currentIndex++;
                continue;
            }

            //find potential pit bottom equal to consecutive values
            int potentialPitBottomValue = points[potentialPitEndIndex -1];

            //find potential pit end 
            int potentialPitRightEdgeindex = potentialPitEndIndex;
            while (potentialPitRightEdgeindex < points.Length && points[potentialPitRightEdgeindex] > points[potentialPitRightEdgeindex -1])
            {
                potentialPitRightEdgeindex++;
            }

            //skip if sequence length is less than 2
            if (potentialPitRightEdgeindex - potentialPitEndIndex < 2)
            {
                currentIndex++;
                continue;
            }

            //find the right edge
            int potentialPitEndValue = points[potentialPitRightEdgeindex - 1];

            //calculate depth 
            deepestPitDepth = Math.Max(deepestPitDepth, Math.Min(potentialPitStartValue - potentialPitBottomValue, potentialPitEndValue - potentialPitBottomValue));

            //move to the next pit
            currentIndex++;
        }

        return deepestPitDepth;
    }

    static void Main(string[] args)
    { 
        
    }
}
