// No driver calls in the original Python file.
// Note: the Python compares against the builtin `max` (arr[i] > max), which raises a TypeError;
// translated with the intended comparison against maxElement.

static double Largest(int[] arr)
{
    double maxElement = double.NegativeInfinity;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElement)
            maxElement = arr[i];
    }

    return maxElement;
}
