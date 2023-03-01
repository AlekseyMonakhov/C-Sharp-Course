// See https://aka.ms/new-console-template for more information


int[] numbers = new int[100];
Random random = new Random();

for (int i = 0;i < numbers.Length - 1; i++) 
{
    numbers[i] = random.Next(1,1000);
}

List<int> GetEven(int[] array)
{
	List<int> evenNumArr = new List<int>(); 
	for (int i = 0; i < array.Length - 1; i++)
	{
		if (array[i] % 2 == 0) 
		{
			evenNumArr.Add(array[i]);
		} 
    }
	return evenNumArr;
}

List<int> GetOdd(int[] array)
{
    List<int> oddNumArr = new List<int>();
    for (int i = 0; i < array.Length -1; i++)
    {
        if (array[i] % 2 > 0)
        {
            oddNumArr.Add(array[i]);
        }
    }
    return oddNumArr;
}


List<int> GetReverse(int[] array)
{
    List<int> reverseArr = new List<int>();
    int counter = array.Length-1;
    while (counter >= 0) 
    {
        reverseArr.Add(array[counter]);
        counter--;
    }
    
    return reverseArr;
}

int[] GetSort(int[] array, bool fromMaxToMin = true)
{

    int maxValue;
    for (int i = 0; i < array.Length -1; i++)
    {
        for (int j = i + 1; j < array.Length -1; j++)
        {
            if(fromMaxToMin)
            {
                if (array[i] < array[j])
                {
                    maxValue = array[j];
                    array[j] = array[i];
                    array[i] = maxValue;

                }
            }
            else
            {
                if (array[i] > array[j])
                {
                    maxValue = array[j];
                    array[j] = array[i];
                    array[i] = maxValue;

                }
            }

        }

    }

    return array;
}

List<int> even = GetEven(numbers);
List<int> odd = GetOdd(numbers);
List<int> reversed = GetReverse(numbers);
int[] sorted = GetSort(numbers, false);



for (int i = 0; i < sorted.Length - 1; i++)
{
	Console.WriteLine(sorted[i]);
}
