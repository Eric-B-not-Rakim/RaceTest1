using System;
using System.Collections.Generic;

namespace RaceTest1.Shared
{
	public class Player
	{
		public string name;
		public List<string> cards = new List<string>();
		public PlayerStatus status = PlayerStatus.active;
		public int score;

		public Player(string n)
		{
			name = n;
        }


		/* Introduces player by name
		 * Called by CardTable object
		 */
		public void Introduce(int playerNum)
		{
			Console.WriteLine("Hello, my name is " + name + " and I am player #" + playerNum);
		}
	}
}

