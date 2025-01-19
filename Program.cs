
class Program
{
    public static void Main() {
        int[] nums = { 1,2,3,4 };
        Console.WriteLine(MissingNumber(4,nums));
    }

    public static int MissingNumber(int n, int []a)
    {
        return n*(n+1)/2- a.Sum();
    }
}
