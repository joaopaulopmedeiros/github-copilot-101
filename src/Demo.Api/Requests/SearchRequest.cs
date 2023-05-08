namespace Demo.Api.Requests;

public class SearchRequest
{
    /// <summary>
    /// Input array
    /// </summary>
    public int[] Array { get; set; }
    /// <summary>
    /// Integer to search for
    /// </summary>
    public int Value { get; set; }
}
