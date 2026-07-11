using System.Globalization;

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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // step 1: I needed to create a new array of doubles with the size of the length.
        // step 2: I needed to use a for loop going up to the length and for every integer(i) it went up I would times the chosen number by that i + 1
        // step 3: I would then return that multiples list to see what values pop up.
        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // step 1: I needed to create a new instance of a list for my rotate list right function to work
        // step 2: I will loop through the amount of times I need to rotate the list and remove the last numbers the number of times necessary to insert them at the beginning
        // step 3: I will then clear my original list and add all of the values from my new list to the original data list using AddRange(_data)
        List<int> _data = new List<int>(data);
        for (int i = 0; i < amount; i++)
        {
            int lastIndex = _data.Count - 1;
            int lastValue = _data[lastIndex];
            _data.RemoveAt(lastIndex);
            _data.Insert(0, lastValue);

        }
        data.Clear();
        data.AddRange(_data);

    }
}
