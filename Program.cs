using System;
using System.Collections.Generic;
namespace myApp
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Enter your ticket number");
				string ticketNumber = Console.ReadLine();
				if (ticketNumber.Length >= 4 && ticketNumber.Length <= 8)
				{
					Int32 val;
					if (Int32.TryParse(ticketNumber, out val))
					{
						List<string> ticket = new List<string>();

						foreach (char c in ticketNumber)
						{
							ticket.Add(c.ToString());
						}

						string firstNumber = "0";
						if (ticket.Capacity % 2 != 0)
						{
							ticket.Insert(0, firstNumber);
						}
						
						string[] output = ticket.ToArray();
						
						int sum1 = 0;
						for (int i = 0; i < output.Length / 2; i++)
						{
							sum1 += int.Parse(output[i]);
						}

						int sum2 = 0;
						for (int j = output.Length / 2; j < output.Length; j++)
						{
							sum2 += int.Parse(output[j]);
						}

						if (sum1 == sum2)
						{ Console.WriteLine("Your ticket is lucky!"); }
						else { Console.WriteLine("Your ticket is not lucky!"); }
												
					}
					else
					{
						Console.WriteLine("Вad input, try to use digits in your ticket number!");
					}
				}
				else
				{
					Console.WriteLine("Try to use ticket number which contains 4 to 8 digits long!");
				}
			}
		}
	}
}
