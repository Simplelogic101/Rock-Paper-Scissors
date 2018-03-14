/*
 * Created by SharpDevelop.
 * User: 7071-111
 * Date: 3/12/2018
 * Time: 11:54 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RockPaperScissors
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			
			Console.WriteLine("Wellcome to Rock, Paper, Scissors!!!");
			Console.ReadLine();
			Console.WriteLine("Make your choice:");
			
			gameFunc();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void gameFunc()
		{
         
			Random Random = new Random();
			
			string rock = "ROCK";
			string paper = "PAPER";
			string scissor = "SCISSORo";
		    string choice = Console.ReadLine();
			
			int random = Random.Next(1,4);
			choice = choice.ToUpper();
			
			
			switch (random)
			{
			
				case 1:
					if (choice == rock) {
						Console.WriteLine(choice + " <- you vs. us -> " +rock);
			            Console.WriteLine("It's a Tie.");		
					}
					
					else if (choice == paper) {
						Console.WriteLine(choice + " <- you vs. us -> " +rock);
			            Console.WriteLine("It's your defeat.");	
					
				    } else if (choice == scissor) {
						Console.WriteLine(choice + " <- you vs. us -> " +rock);
			            Console.WriteLine("It's your Victory!!");
					} else {
						Console.WriteLine(choice + " is not a choice.");
					}
						break;
				case 2:
					if (choice == scissor) {
						Console.WriteLine(choice + " <- you vs. us -> " +paper);
			            Console.WriteLine("It's your defeat.");		
		            
					} else if (choice == paper) {
						Console.WriteLine(choice + " <- you vs. us -> " + paper);
			            Console.WriteLine("It's your Victory!!");	
					
				    } else if (choice == scissor) {
						Console.WriteLine(choice + " <- you vs. us -> " +paper);
			            Console.WriteLine("It's a tie.");
					} else {
						Console.WriteLine(choice + " is not a choice.");
						}
				        break;
						
				case 3:
					if (choice == rock) {
						Console.WriteLine(choice + " <- you vs. us -> " +scissor);
			            Console.WriteLine("It's your defeat.");		
		            
					} 
				    else if (choice == paper) {
						Console.WriteLine(choice + " <- you vs. us -> " +scissor);
			            Console.WriteLine("It's your Victory!!");	
					
				    } 
				    else if (choice == scissor) {
						Console.WriteLine(choice + " <- you vs. us -> " +scissor);
			            Console.WriteLine("It's a tie.");
					} 
				    else {
						Console.WriteLine(choice + " is not a choice.");
				        }
					    break;
			}
		
		}
	}
}
				