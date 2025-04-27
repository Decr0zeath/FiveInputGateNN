public class ANDGate : IGate
{
    public int GetOutput(int[] inputs)
    {
        foreach (var bit in inputs)
        {
            if (bit == 0) return 0;
        }
        return 1;
    }
}