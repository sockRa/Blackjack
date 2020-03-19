using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
	public enum CardColor { C, S, D, H }

	public class Card
	{
		public CardColor Color { get; set; }
		public int Value { get; set; }

		public string ImageFileName
		{
			get
			{
				string valuetext;
				switch (Value)
				{
					case 1:
						valuetext = "A";
						break;

					case 11:
						valuetext = "J";
						break;

					case 12:
						valuetext = "Q";
						break;

					case 13:
						valuetext = "K";
						break;

					default:
						valuetext = Value.ToString();
						break;
				}

				return $"{valuetext}{Color.ToString().ToUpper()}.png";
			}
		}

		public Card(CardColor cardColor, int value)
		{
			Color = cardColor;
			Value = value;
		}

		public static int Sum(List<Card> cards)
		{
			var result = 0;

			foreach (var card in cards)
			{
				result += card.Value;
			}

			return result;
		}
	}
}