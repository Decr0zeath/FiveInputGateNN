public class ORGate : IGate
{
    public int GetOutput(int[] inputs)
    {
        foreach (var bit in inputs)
        {
            if (bit == 1) return 1;
        }
        return 0;
    }
}