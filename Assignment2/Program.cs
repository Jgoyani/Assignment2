using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;

            int length = 0;
            do
            {
                Console.WriteLine("Please Enter Length");
                string legthString = Console.ReadLine();
                try
                {
                    length = int.Parse(legthString);
                    temp = 1;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Please write integer value");
                    temp = 0;
                }
                if (length < 1 & temp == 1)
                {
                    Console.WriteLine("Please enter value more than 0.");
                    temp = 0;
                }

            }
            while (temp == 0);

            temp = 0;
            int height = 0;
            do
            {
                Console.WriteLine("Please Enter Height");
                string heightString = Console.ReadLine();
                try
                {
                    height = int.Parse(heightString);
                    temp = 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please write integer value");
                    temp = 0;
                }
                if (height < 1 & temp == 1)
                {
                    Console.WriteLine("Please enter value more than 0.");
                    temp = 0;
                }

            }
            while (temp == 0);

            temp = 0;
            int width = 0;
            do
            {
                Console.WriteLine("Please Enter width");
                string widthString = Console.ReadLine();
                try
                {
                    width = int.Parse(widthString);
                    temp = 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please write integer value");
                    temp = 0;
                }
                if (width < 1 & temp == 1)
                {
                    Console.WriteLine("Please enter value more than 0.");
                    temp = 0;
                }

            }
            while (temp == 0);

            Rectangle r = new Rectangle(length, width, height);

            Console.WriteLine("----------------------");

            int input = 0;
            do
            {
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Height");
                Console.WriteLine("6. Change Rectangle Height");
                Console.WriteLine("7. Get Rectangle Volume");
                Console.WriteLine("8. Exit");

                input = Int32.Parse(Console.ReadLine());
                if (input == 1)
                {
                    int localLength = r.GetLength();
                    Console.WriteLine("Length is: {0}", localLength);
                }
                else if (input == 2)
                {
                    Console.WriteLine("Enter length");
                    int localLength = int.Parse(Console.ReadLine());
                    localLength =  r.SetLength(localLength);
                }
                else if(input == 3)
                {
                    int localWidth = r.GetWidth();
                    Console.WriteLine("Width is: {0}", localWidth);
                }
                else if (input == 4)
                {
                    Console.WriteLine("Enter Width");
                    int localWidth = int.Parse(Console.ReadLine());
                    if (localWidth > 0)
                    {
                        localWidth = r.SetWidth(localWidth);
                    }
                }
                else if (input == 5)
                {
                    int localHeight = r.GetHeight();
                    Console.WriteLine("Height is: {0}", localHeight);
                }
                else if (input == 6)
                {
                    Console.WriteLine("Enter Height");
                    int localHeight = int.Parse(Console.ReadLine());
                    if(localHeight > 0)
                    {
                        localHeight = r.SetHeight(localHeight);
                    }
                    
                }
                else if(input == 7)
                {
                    int volume = r.GetVolume();
                    Console.WriteLine("Volume is {0}", volume);
                }
                else if(input == 8)
                {
                    
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                }
            } while (input != 8);

            Console.ReadLine();
        }
    }
}
