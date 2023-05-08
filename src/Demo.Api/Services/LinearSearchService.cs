namespace Demo.Api.Services;

public class LinearSearchService : ISearchService
{
    public int Run(int[] array, int target)
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
