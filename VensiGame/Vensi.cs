using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VensiGame;

namespace VensiGame
{
    class Vensi
    {

        public delegate void ShowInfo(string message);
        public delegate bool GetReq(bool res);
        public delegate void SetText(int n);

        public Action<Player> SelectCurrentPlayer;
        public Action<int> RequiredScore;
        public CardSet Deck { get; set; }
        public Player[] Players { get; set; }
        public CardSet Table { get; set; }
        public int IsPlayerGetCardSet { get; set; }//?
        public Player CurrentPlayer { get; set; }

        private ShowInfo ShowMessage;

        public Vensi(Player[] players, CardSet deck, CardSet table)
        {
            IsPlayerGetCardSet = 0;
            Deck = deck;
            Table = table;
            Deck.Mix();
            Players = players;
        }



        public void RegisterHandler(ShowInfo showInfo)
        {
            ShowMessage = showInfo;
          //SelectCurrentPlayer = selectCurrentPlayer;
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

        public void MoveAction(Move move)
        {
            Player player = CurrentPlayer;
            if (move is MoveActive)
            {
                MoveActive currentMove = (MoveActive)move;
                if (Table.Cards.Count==0)
                {
                    Table.Add(currentMove.MovingCards);
                    return;
                }
                if (currentMove.MovingCards.Cards.Count==1)
                {
                    if (Value(currentMove.MovingCards) == VensiValue(Table.Cards[Table.Cards.Count - 1]) )
                    {
                    Table.Add(currentMove.MovingCards);
                        for (int i = 0; i < currentMove.MovingCards.Cards.Count; i++)
                        {
                            for (int j = 0; j < CurrentPlayer.Cards.Cards.Count; j++)
                            {
                                if (currentMove.MovingCards.Cards[i]==CurrentPlayer.Cards.Cards[j])
                                {
                                    CurrentPlayer.Cards.Pull(j);
                                }
                            }
                        }
                        RequiredScore(VensiValue(Table.Cards[Table.Cards.Count - 1]));
                        currentMove.MovingCards.Cards.Clear();

                        if (Table.Cards.Count != 0)
                        {
                            Table.ShowLast();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    
                    if (Math.Abs(Value(currentMove.MovingCards) - VensiValue(Table.Cards[Table.Cards.Count - 1]))==1)
                    {
                        Table.Add(currentMove.MovingCards);
                        for (int i = 0; i < currentMove.MovingCards.Cards.Count; i++)
                        {
                            for (int j = 0; j < CurrentPlayer.Cards.Cards.Count; j++)
                            {
                                if (currentMove.MovingCards.Cards[i] == CurrentPlayer.Cards.Cards[j])
                                {
                                    CurrentPlayer.Cards.Pull(j);
                                }
                            }
                        }
                        RequiredScore(VensiValue(Table.Cards[Table.Cards.Count - 1]));
                        currentMove.MovingCards.Cards.Clear();

                        if (Table.Cards.Count != 0)
                        {
                            Table.ShowLast();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
               
                
            }
            else if(move is MovePassive)
            {
                if (Table.Cards.Count ==0)
                {
                    return;
                }
                MovePassive currentMove = (MovePassive)move;
                CurrentPlayer.Cards.Add(Table);
                Table.Cards.Clear();
                if (Deck.Cards.Count!=0)
                {
                Table.Add(Deck.Pull());
                    Table.ShowLast();
                }
                



            }
            else
            {
                return;
            }
            RequiredScore(VensiValue(Table.Cards[Table.Cards.Count - 1]));
            SelectCurrentPlayer(CurrentPlayer);
        }

        private bool CheckWinner()
        {

                if (CurrentPlayer.Cards.Cards.Count == 0)
                {
                    ShowMessage(String.Format("Player {0} won", CurrentPlayer.Name));
                    return true;
                }
            
            return false;
        }

        public int Value(CardSet cardset)
        {
            int res = 0;
            foreach (var card in cardset.Cards)
            {
                res += VensiValue(card);
            }
            return res;
        }

        public void Start()
        {
            CurrentPlayer = Players[0];

            Table.Add(Deck.Pull());
            Table.ShowLast();
            int cardAmount = Players.Length == 2 ? 13 : 7;

            for (int i = 0; i < Players.Length; i++)
            {
                Players[i].Cards.Add(Deck.Deal(cardAmount));
            }


            SelectCurrentPlayer(CurrentPlayer);
        

    }

        public void Refresh()
        {


            //Отображение изменений
            if (Table.Cards.Count!=0)
            {
                Table.ShowLast();
            }
          
           
            for (int i = 0; i < Players.Length; i++)
            {
                if (Players[i]==CurrentPlayer)
                {
                    if (i==Players.Length-1)
                    {
                        CurrentPlayer = Players[0];
                        CurrentPlayer.Cards.Show();
                        if (Table.Cards.Count != 0)
                        {
                            Table.ShowLast();
                        }
                        break;  
                    }
                    i++;
                    CurrentPlayer = Players[i++];
                    CurrentPlayer.Cards.Show();
                    if (Table.Cards.Count != 0)
                    {
                        Table.ShowLast();
                    }
           
                    break;
                }
                
            }
            CurrentPlayer.Cards.Show();
          
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
