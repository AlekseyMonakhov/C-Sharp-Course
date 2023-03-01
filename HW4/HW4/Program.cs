using System;

float[] calcTime(int photographersAmount, int[] photographersSpeedArr, int fotoAmount)
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

try
{

    Console.WriteLine("Enter number of photographers");
    int photographersAmount = int.Parse(Console.ReadLine());

    int[] photographersSpeedArr = new int[photographersAmount];

    for (int i = 0;i < photographersAmount; i++)
    {
        Console.WriteLine($"Enter speed of {i + 1}");
        photographersSpeedArr[i]= int.Parse(Console.ReadLine()); 
    }
   
    Console.WriteLine("Enter number of fotos needed to process");
    int fotoAmount = int.Parse(Console.ReadLine());

    float[] result = calcTime(photographersAmount, photographersSpeedArr, fotoAmount);

    for (int i = 0; i < result.Length; i++)
    {
        if(i == 0)
        {
            Console.WriteLine($"team will process this task in {result[i]}h");

        }
        else
        {
            Console.WriteLine($"{i} fotograph result is {result[i]} photos");
        }
        
    }

}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}
