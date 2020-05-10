using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vensi
{
    class Vensi
    {
       
        public delegate void ShowInfo(string message);
        public delegate bool GetReq(bool res);
        public delegate void SetText(int n);
        public delegate void SetTime(int n);
        public CardSet Deck { get; set; }
        public Player[] Players { get; set; }
        private int CurrentScore { get; set; }
        private int CurrentPlayerTime { get; set; }      
        public GraphicCardSet Currentcard { get; set; }
        public int IsPlayerGetCardSet { get; set; }
        public Panel Player_pannel { get; set; }
        public Player CurrentPlayer { get; set; }
     
        private ShowInfo ShowMessage;
        private SetText Settext;
        private SetTime Settime;
  
        public Vensi(PictureBox cur_pan, Panel player_pannel, CardSet cardSet, Player[] players)
        {
            IsPlayerGetCardSet = 0;
            Player_pannel = player_pannel;
            CurrentScore = 0;
            CurrentPlayerTime = 60;
            Deck = cardSet;
            Deck.Mix();
            for (int i = 0; i < 3; i++)
            {
                Card card = Deck.Pull();
                Currentcard = new GraphicCardSet(cur_pan);
                Currentcard.Add(new GraphicCard(card.cardFigure, card.cardSuit, cur_pan));
            }
            for (int i = 0; i < players.Length; i++)
            {
                players[i].Cards = new GraphicCardSet(player_pannel);
            }
                      
            Players = players;
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
                if (player.Cards.Cards.Count==0)
                {
                    return true;
                }
            }
            return false;
        }

        async public void Move(Player player)
        {
            CurrentPlayer = player;
             ShowMessage(String.Format("Player {0} will play now", player.Name));
          
            player.Cards.Show();
            for (int j = 0; j < 60; j++)
            {
               
               if (CurrentPlayerTime != 0)
               {
                   await Task.Delay(1000);
                   CurrentPlayerTime--;
                   Settime(CurrentPlayerTime);
               } 
               if (IsPlayerGetCardSet == 1)
               {
                   GraphicCardSet cardSet = Currentcard;
                   for (int i = 0; i < cardSet.Cards.Count; i++)
                   {
                       GraphicCard gc = (GraphicCard)cardSet.Cards[i];
                       CurrentPlayer.Cards.Add(Currentcard);
                   }
                   // CurrentPlayer.Cards = new GraphicCardSet(Player_pannel, CurrentPlayer.Cards.Cards);
                   CurrentPlayer.Cards.Show();
                   IsPlayerGetCardSet = 0;
                   CurrentScore = 0;
                   Settext(CurrentScore);              
               }
              
               else if (IsPlayerGetCardSet == 2)
               {
                   if (CurrentScore - 1 == Currentcard.GetPoints())
                   {
                       for (int i = 0; i < CurrentPlayer.Cards.Cards.Count; i++)
                       {
              
                           if (((GraphicCard)CurrentPlayer.Cards.Cards[i]).IsSelected)
                           {
                                Currentcard.Cards.Add(CurrentPlayer.Cards.Pull(i));
                           }
                       }
                   }
                   IsPlayerGetCardSet = 0;
                   //CurrentPlayer.Cards.Show();
                   CurrentScore = 0;
                   Settext(CurrentScore);
               }
               
            }
              
        }
        
        public void Start()
        {
            Currentcard.Show();
             if (Players.Length == 2)
            {
                foreach(Player pl in Players)
                {
                    pl.Cards.Add(Deck.Deal(13));
                    CardSet cs = pl.Cards;
                     for(int i = 0; i <cs.GetLenght(); i++)
                    {
                        ((GraphicCard)pl.Cards.Cards[i]).RegisterHandler(SetTxt);
                    }                   
                }
            }
            else
            {
                foreach (Player pl in Players)
                {
                    pl.Cards.Add(Deck.Deal(7));
                    CardSet cs = pl.Cards;
                    for (int i = 0; i < cs.GetLenght(); i++)
                    {
                        ((GraphicCard)pl.Cards.Cards[i]).RegisterHandler(SetTxt);
                    }

                }
            }
            while(!IsGameEnded())
            {
                for (int i = 0; i < Players.Length; i++)
                {
                    
                    //if (i==1)
                    //{
                      //  i = 0;
                    //}
                    CurrentScore = 0;
                    Move(Players[i]);
                    
                }
              
            }
           ShowMessage( GetWinner());
            
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

        public void SetTxt(int n)
        {
            CurrentScore += n;
            Settext(CurrentScore);
           
        }
        public void Showm(int n)
        {
            ShowMessage(n.ToString());
        }
     
    }
}
