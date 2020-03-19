using System.Collections.Generic;
using System.Windows.Forms;

namespace Blackjack
{
	public partial class MainForm : Form
	{
		private List<Card> player1Cards;
		private List<Card> player2Cards;

		public MainForm()
		{
			InitializeComponent();
			player1Cards = new List<Card>();
			player2Cards = new List<Card>();
			InitializeGame();
		}

		private void InitializeGame()
		{
			player1Cards.Clear();
			player2Cards.Clear();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			UpdateBoard();
		}

		private void UpdateBoard()
		{
			Player1ScoreText.Text = Card.Sum(player1Cards).ToString();
			Player2ScoreText.Text = Card.Sum(player2Cards).ToString();
		}
	}
}