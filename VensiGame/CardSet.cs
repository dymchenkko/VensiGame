using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VensiGame
{
    class CardSet
    {
        public delegate void Sum(int points);
        public List<Card> Cards { get; set; }
        private Sum ShowSum;
        protected int Count
        {
            get { return Cards.Count; }
        }
public CardSet() : this(new List<Card>())
        { }

        public CardSet(int count)
        {
            if (count > 52) throw new Exception("It's too much cards!!");
            Cards = new List<Card>();
            foreach (var i in Enum.GetValues(typeof(CardFigure)))
            {
                foreach (var j in Enum.GetValues(typeof(CardSuit)))
                {
                    Cards.Add(new Card((CardFigure)i, (CardSuit)j));
                }
            }
            Cards.RemoveRange(0, 52 - count);
        }

        public CardSet(List<Card> cards)
        {
            Cards = cards;
        }
        public void Add(params Card[]cards)
        {
            if (Cards == null)
            {
                Cards = new List<Card>();
            }
           
            foreach(var i in cards)
            {
                Cards.Add(i);
            }
        }
        public int GetLenght()
        {
            return Cards.Count();
        }
        public void Add(CardSet cardSet)
        {
            Add(cardSet.Cards.ToArray());
        }
        public void Sort2()
        {
            Cards.Sort((card1, card2) =>
            card1.cardFigure.CompareTo(card2.cardFigure)==0?
            card1.cardSuit.CompareTo(card2.cardSuit):
            card1.cardFigure.CompareTo(card2.cardFigure));
          
        }
        public void Mix()
        {
         
            List<Card> newCards = new List<Card>();
            Random r = new Random();
            int c = 0;

            while (Cards.Count > 0)
            {
                c = r.Next(0, Cards.Count);
                newCards.Add(Cards[c]);
                Cards.Remove(Cards[c]);

            }

           Cards = newCards;
        }
        public virtual void ShowLast()
        {
            Cards[Cards.Count - 1].Show();
        }
        public virtual void Show()
        {
            foreach (var item in Cards)
            {
                item.Show();
            }

        }


        public Card Pull()
        {
            Card a = Cards[0];
            Cards.RemoveAt(0);
            return a;
        }

        public Card Pull(int number)
        {
            Card a = Cards[number];
            Cards.RemoveAt(number);
            return a;
        }
       
        public void RegisterHandler(Sum showSum)
        {
            ShowSum = showSum;
        }
        public CardSet Deal(int amount)
        {
            List<Card> c = new List<Card>();
            if (amount > Cards.Count) 
                amount = Cards.Count;

            for (int i = 0; i < amount; i++)
            {
                Card cr = Cards[0];
                c.Add(cr);
                Cards.RemoveAt(0);
            }

            return new CardSet(c);
        }

    }
}
