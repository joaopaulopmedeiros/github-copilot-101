namespace Demo.Api.Services;

public static class LinearSearchService
{
    public static int Run(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }
        return -1;
    }   
}
