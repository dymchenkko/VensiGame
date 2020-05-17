using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VensiGame;

namespace Vensi
{
    class Vensi
    {

        public delegate void ShowInfo(string message);
        public delegate bool GetReq(bool res);
        public delegate void SetText(int n);
        public delegate void SetTime(int n);

        public Action<Player> SelectCurrentPlayer;

        public CardSet Deck { get; set; }
        public Player[] Players { get; set; }
        public CardSet Table { get; set; }
        public int IsPlayerGetCardSet { get; set; }//?
        public Player CurrentPlayer { get; set; }

        private ShowInfo ShowMessage;
        private SetText Settext;
        private SetTime Settime;

        public Vensi(Player[] players, CardSet deck, CardSet table)
        {
            IsPlayerGetCardSet = 0;
            Deck = deck;
            Table = table;
            Deck.Mix();
            Players = players;

            Start();


        }



        public void RegisterHandler(ShowInfo showInfo, SetText setText, SetTime setTime)
        {
            Settime = setTime;
            Settext = setText;
            ShowMessage = showInfo;
        }

        public bool IsGameEnded()
        {
            foreach (var player in Players)
            {
                if (player.Cards.Cards.Count == 0)
                {
                    return true;
                }
            }
            return false;
        }

        // method Time is Up ()

        async public void MoveAction(Move move)
        {
            Player player = CurrentPlayer;

            if (move is MoveActive)
            {
                MoveActive currentMove = (MoveActive)move;
                if(Value(currentMove.MovingCards)==Table[0].Value)
                    Table.Add(currentMove.MovingCards)

            }



            ShowMessage(String.Format("Player {0} will play now", player.Name));
            Refresh();
            CheckWinner();//проверка, никто ли не выиграл
        }

        private object Value(CardSet cardset)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            CurrentPlayer = Players[0];

            Table.Add(Deck.Pull());

            Table.Show();

            int cardAmount = Players.Length == 2 ? 13 : 7;

            foreach (Player pl in Players)
            {
                pl.Cards.Add(Deck.Deal(cardAmount));
            }



            Refresh();

        }

        private void Refresh()
        {
            //Отображение изменений
            //cardset show
            //selectactiveplayer(activePlayer)
            throw new NotImplementedException();
        }

        private string GetWinner()
        {
            foreach (var player in Players)
            {
                if (player.Cards.Cards.Count == 0)
                {
                    return player.Name;
                }
            }
            return "";
        }


        public void Showm(int n)
        {
            ShowMessage(n.ToString());
        }

        public int VensiValue(Card card)
        {
            switch (card.cardFigure)
            {
                case CardFigure.two:
                    return 2;
                case CardFigure.three:
                    return 3;
                case CardFigure.four:
                    return 4;
                case CardFigure.five:
                    return 5;
                case CardFigure.six:
                    return 6;
                case CardFigure.seven:
                    return 7;
                case CardFigure.eight:
                    return 8;
                case CardFigure.nine:
                    return 9;
                case CardFigure.ten:
                    return 10;
                case CardFigure.jack:
                    return 11;
                case CardFigure.queen:
                    return 12;
                case CardFigure.king:
                    return 13;
                case CardFigure.ace:
                    return 1;
                default:
                    return 0;
            }
        }

        public int VensiValue(string s)
        {
            switch (s)
            {
                case "CardFigure.two":
                    return 2;
                case "CardFigure.three":
                    return 3;
                case "CardFigure.four":
                    return 4;
                case "CardFigure.five":
                    return 5;
                case "CardFigure.six":
                    return 6;
                case "CardFigure.seven":
                    return 7;
                case "CardFigure.eight":
                    return 8;
                case "CardFigure.nine":
                    return 9;
                case "CardFigure.ten":
                    return 10;
                case "CardFigure.jack":
                    return 11;
                case "CardFigure.queen":
                    return 12;
                case "CardFigure.king":
                    return 13;
                case "CardFigure.ace":
                    return 1;
                default:
                    return 0;
            }

        }
    }
}
