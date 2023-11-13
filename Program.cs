namespace Rekrüsif_ve_Extesion_Metotlar;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("###Welcome Method's###");

        //Rekrüsif Özyinelemi Metot
        //3^4 3*3*3*3
        int result =1;
        for (int i = 1; i <5; i++)
        result = result *3;
        Console.WriteLine(result);

        kök instance = new ();
        Console.WriteLine( instance.brave (3,4) );


            




        
    }

 }


 public class kök
{
public int brave (int number , int number1)
{
    if (number1<2)
      return number;
    return brave (number, number1-1)* number;
}
/*Brave (3,4)
Brave(3,3)*3
Brave(3,2)*3 *3
Brave(3-1)*3 *3 *3
3*3*3*3= 3^4


*/
}


public class Extension{


    
}