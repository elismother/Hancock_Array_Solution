using System.Diagnostics;

namespace Hancock_Array_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Random random = new Random();

            int integer;

            char[] charArray = new char[50];

            bool exists = true;

            do
            {
                integer = random.Next(65, 122);

                if ((integer > 64 && integer < 91) || (integer > 96 && integer < 123))
                {
                    if ((exists = CharExists(integer)) == false)
                    {
                        for (int i = 0; i < charArray.Length; i++)
                        {
                            if (charArray[i] == '\0')
                            {
                                charArray[i] = (char)integer;
                                break;
                            }
                        }
                    }
                }

            } while (charArray[49] == '\0');

            stopwatch.Stop();

            Console.WriteLine("Elapsed time: " + (stopwatch.Elapsed.ToString()));

            bool CharExists(int integer)
            {

                if (!(Array.Exists(charArray, ch => ch == (char)integer)))
                {
                    return false;
                }
                return true;
            }
        }
    }
}
