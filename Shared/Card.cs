﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTest1.Shared
{
	public class Card
	{
		public string id;
		public string displayName;

		public Card(string shortCardName, string longCardName)
		{
			id = shortCardName;
			displayName = longCardName;
		}
	}
}
