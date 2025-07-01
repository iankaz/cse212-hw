public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step-by-step plan for MultiplesOf:
        // 1. Create a new array of size 'length' to store the multiples.
        // 2. Use a loop that runs from 0 to length - 1.
        // 3. For each index i, calculate the multiple as number * (i + 1) and store it in the array.
        // 4. After the loop, return the array.
        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step-by-step plan for RotateListRight:
        // 1. Determine the split point: the last 'amount' elements will move to the front.
        // 2. Use GetRange to get the last 'amount' elements as a new list.
        // 3. Use GetRange to get the first 'data.Count - amount' elements as another list.
        // 4. Clear the original list.
        // 5. Add the last 'amount' elements to the list.
        // 6. Add the remaining elements to the list.
        int n = data.Count;
        if (n == 0 || amount == 0 || amount == n) return; // No rotation needed
        List<int> last = data.GetRange(n - amount, amount);
        List<int> first = data.GetRange(0, n - amount);
        data.Clear();
        data.AddRange(last);
        data.AddRange(first);
    }
}
