using System;
bool isError = false;

float[] calcTime(int[] photographersSpeedArr, int fotoAmount)
{
    int totalSpeed = 0;
    float[] result = new float[photographersSpeedArr.Length + 1];

    for (int i = 0; i < photographersSpeedArr.Length; i++)
    {
        totalSpeed += photographersSpeedArr[i];
    }
    
    result[0] = (float)fotoAmount / (float)totalSpeed;  

    for (int i = 0; i < photographersSpeedArr.Length; i++)
    {
        result[i + 1] = (float)Math.Round(photographersSpeedArr[i] * result[0], 1);
    }

    return result;
}


do
{

    try
    {

        Console.WriteLine("Enter number of photographers");
        int photographersAmount = int.Parse(Console.ReadLine());

        if (photographersAmount < 1)
        {
            throw new Exception("photographers count cant be less then 1");
        }

        int[] photographersSpeedArr = new int[photographersAmount];

        for (int i = 0; i < photographersAmount; i++)
        {
            Console.WriteLine($"Enter speed of {i + 1}");
            int photographerSpeed = int.Parse(Console.ReadLine());

            if (photographerSpeed == 0)
            {
                throw new Exception("photographer speed cant be 0");
            }

            photographersSpeedArr[i] = photographerSpeed;
        }

        Console.WriteLine("Enter number of fotos needed to process");
        int fotoAmount = int.Parse(Console.ReadLine());

        isError = false;

        float[] result = calcTime(photographersSpeedArr, fotoAmount);

        for (int i = 0; i < result.Length; i++)
        {
            if (i == 0)
            {

                Console.WriteLine($"team will process this task in {result[i] * 60}minutes");

            }
            else
            {
                Console.WriteLine($"{i} fotograph result is {result[i]} photos");
            }

        }

    }
    catch (Exception ex)
    {
        isError= true;
        Console.WriteLine(ex.Message);
    }

} while (isError);

