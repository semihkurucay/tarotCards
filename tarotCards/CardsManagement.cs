using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarotCards
{
    internal class CardsManagement
    {
        private int[] _cardsList = new int[78];
        private ArrayList _cards = new ArrayList();
        private Random _random = new Random();

        public int[] listAdd()
        {
            for(int i = 0; i < 100; i++)
            {
                _cards.Add(i);
            }

            int nowCardId = 0;
            int nowCard = 0;

            for(int i = 0; i <  _cardsList.Length; i++)
            {
                nowCardId = _random.Next(0, _cards.Count);
                nowCard = Convert.ToInt32(_cards[nowCardId]);

                if(nowCard < 44)
                {
                    if(nowCard % 2 == 0)
                    {
                        _cardsList[i] = nowCard;
                        _cards.Remove(nowCard);
                        _cards.Remove(nowCard + 1);
                    }
                    else
                    {
                        _cardsList[i] = nowCard;
                        _cards.Remove(nowCard);
                        _cards.Remove(nowCard - 1);
                    }
                }
                else
                {
                    _cardsList[i] = nowCard;
                    _cards.Remove(nowCard);
                }
            }

            return _cardsList;
        }
    }
}
