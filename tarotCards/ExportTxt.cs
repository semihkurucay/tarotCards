using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace tarotCards
{
    internal class ExportTxt
    {
        //Kişi Bilgileri
        private string me = "null";
        private string who = "null";
        private string why = "null";

        //Kart ve dosya bilgileri
        private string cards = "";
        private ArrayList selectsCards;
        private string fileName = "TarotCards " + DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + ".txt";
        private string filePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        public void setMe(string _me)
        {
            me = _me;
        }
        public void setWho(string _who)
        {
            who = _who;
        }
        public void setWhy(string _why)
        {
            why = _why;
        }

        public void setSelectsCards(ArrayList _selectsCards)
        {
            selectsCards = _selectsCards;
        }
        public string getFileName()
        {
            return fileName;
        }
        public string getFilePath()
        {
            return filePath;
        }
        public void setFilePath(string _filePath)
        {
            filePath = _filePath;
        }

        public void writing()
        {
            cardsTxtAdd();
            string text = "Tarot Kart Uygulaması\n" +
                "(Bu gerçek bir uygulama değildir ve olamaz çünkü gelecek her zaman değişir)\n\n\n" +
                "+--------------------+\n" +
                "Bakan Kişi : " + me + "\n" +
                "Bakılan Kişi : " + who + "\n" +
                "Sebebi : " + why + "\n" +
                "+--------------------+\n\n\n" +
                "+---AÇILAN-KARTLAR---+\n" +
                cards;

            string files = (filePath + "\\") + fileName;
            File.WriteAllText(files, text);
        }

        private void cardsTxtAdd()
        {
            int number = 0;
            foreach (int id in selectsCards)
            {
                cards += (++number) + ". ";
                switch (id)
                {
                    case 0:
                        cards += "Death\n";
                        break;
                    case 1:
                        cards += "Death [Ters]\n";
                        break;
                    case 2:
                        cards += "Judgement\n";
                        break;
                    case 3:
                        cards += "Judgement [Ters]\n";
                        break;
                    case 4:
                        cards += "Justice\n";
                        break;
                    case 5:
                        cards += "Justice [Ters]\n";
                        break;
                    case 6:
                        cards += "Strength\n";
                        break;
                    case 7:
                        cards += "Strength [Ters]\n";
                        break;
                    case 8:
                        cards += "Temperance\n";
                        break;
                    case 9:
                        cards += "Temperance [Ters]\n";
                        break;
                    case 10:
                        cards += "The Chariot\n";
                        break;
                    case 11:
                        cards += "The Chariot [Ters]\n";
                        break;
                    case 12:
                        cards += "The Devil\n";
                        break;
                    case 13:
                        cards += "The Devil [Ters]\n";
                        break;
                    case 14:
                        cards += "The Emperor\n";
                        break;
                    case 15:
                        cards += "The Emperor [Ters]\n";
                        break;
                    case 16:
                        cards += "The Empress\n";
                        break;
                    case 17:
                        cards += "The Empress [Ters]\n";
                        break;
                    case 18:
                        cards += "The Fool\n";
                        break;
                    case 19:
                        cards += "The Fool [Ters]\n";
                        break;
                    case 20:
                        cards += "The Hanged Man\n";
                        break;
                    case 21:
                        cards += "The Hanged Man [Ters]\n";
                        break;
                    case 22:
                        cards += "The Hermit\n";
                        break;
                    case 23:
                        cards += "The Hermit [Ters]\n";
                        break;
                    case 24:
                        cards += "The Hierophant\n";
                        break;
                    case 25:
                        cards += "The Hierophant [Ters]\n";
                        break;
                    case 26:
                        cards += "The High Priestess\n";
                        break;
                    case 27:
                        cards += "The High Priestess [Ters]\n";
                        break;
                    case 28:
                        cards += "The Lovers\n";
                        break;
                    case 29:
                        cards += "The Lovers [Ters]\n";
                        break;
                    case 30:
                        cards += "The Magician\n";
                        break;
                    case 31:
                        cards += "The Magician [Ters]\n";
                        break;
                    case 32:
                        cards += "The Moon\n";
                        break;
                    case 33:
                        cards += "The Moon [Ters]\n";
                        break;
                    case 34:
                        cards += "The Star\n";
                        break;
                    case 35:
                        cards += "The Star [Ters]\n";
                        break;
                    case 36:
                        cards += "The Sun\n";
                        break;
                    case 37:
                        cards += "The Sun [Ters]\n";
                        break;
                    case 38:
                        cards += "The Tower\n";
                        break;
                    case 39:
                        cards += "The Tower [Ters]\n";
                        break;
                    case 40:
                        cards += "The World\n";
                        break;
                    case 41:
                        cards += "The World [Ters]\n";
                        break;
                    case 42:
                        cards += "Wheel Of Fortune\n";
                        break;
                    case 43:
                        cards += "Wheel Of Fortune [Ters]\n";
                        break;
                    case 44:
                        cards += "Ace Of Cups\n";
                        break;
                    case 45:
                        cards += "Ace Of Pentacles\n";
                        break;
                    case 46:
                        cards += "Ace Of Swords\n";
                        break;
                    case 47:
                        cards += "Ace Of Wands\n";
                        break;
                    case 48:
                        cards += "Eight Of Cups\n";
                        break;
                    case 49:
                        cards += "Eight Of Pentacles\n";
                        break;
                    case 50:
                        cards += "Eight Of Swords\n";
                        break;
                    case 51:
                        cards += "Eight Of Wands\n";
                        break;
                    case 52:
                        cards += "Five Of Cups\n";
                        break;
                    case 53:
                        cards += "Five Of Pentacles\n";
                        break;
                    case 54:
                        cards += "Five Of Swords\n";
                        break;
                    case 55:
                        cards += "Five Of Wands\n";
                        break;
                    case 56:
                        cards += "Four Of Cups\n";
                        break;
                    case 57:
                        cards += "Four Of Pentacles\n";
                        break;
                    case 58:
                        cards += "Four Of Swords\n";
                        break;
                    case 59:
                        cards += "Four Of Wands\n";
                        break;
                    case 60:
                        cards += "King Of Cups\n";
                        break;
                    case 61:
                        cards += "King Of Pentacles\n";
                        break;
                    case 62:
                        cards += "King Of Swords\n";
                        break;
                    case 63:
                        cards += "King Of Wands\n";
                        break;
                    case 64:
                        cards += "Knight Of Cups\n";
                        break;
                    case 65:
                        cards += "Knight Of Pentacles\n";
                        break;
                    case 66:
                        cards += "Knight Of Swords\n";
                        break;
                    case 67:
                        cards += "Knight Of Wands\n";
                        break;
                    case 68:
                        cards += "Nine Of Cups\n";
                        break;
                    case 69:
                        cards += "Nine Of Pentacles\n";
                        break;
                    case 70:
                        cards += "Nine Of Swords\n";
                        break;
                    case 71:
                        cards += "Nine Of Wands\n";
                        break;
                    case 72:
                        cards += "Page Of Cups\n";
                        break;
                    case 73:
                        cards += "Page Of Pentacles\n";
                        break;
                    case 74:
                        cards += "Page Of Swords\n";
                        break;
                    case 75:
                        cards += "Page Of Wands\n";
                        break;
                    case 76:
                        cards += "Queen Of Cups\n";
                        break;
                    case 77:
                        cards += "Queen Of Pentacles\n";
                        break;
                    case 78:
                        cards += "Queen Of Swords\n";
                        break;
                    case 79:
                        cards += "Queen Of Wands\n";
                        break;
                    case 80:
                        cards += "Seven Of Cups\n";
                        break;
                    case 81:
                        cards += "Seven Of Pentacles\n";
                        break;
                    case 82:
                        cards += "Seven Of Swords\n";
                        break;
                    case 83:
                        cards += "Seven Of Wands\n";
                        break;
                    case 84:
                        cards += "Six Of Cups\n";
                        break;
                    case 85:
                        cards += "Six Of Pentacles\n";
                        break;
                    case 86:
                        cards += "Six Of Swords\n";
                        break;
                    case 87:
                        cards += "Six Of Wands\n";
                        break;
                    case 88:
                        cards += "Ten Of Cups\n";
                        break;
                    case 89:
                        cards += "Ten Of Pentacles\n";
                        break;
                    case 90:
                        cards += "Ten Of Swords\n";
                        break;
                    case 91:
                        cards += "Ten Of Wands\n";
                        break;
                    case 92:
                        cards += "Three Of Cups\n";
                        break;
                    case 93:
                        cards += "Three Of Pentacles\n";
                        break;
                    case 94:
                        cards += "Three Of Swords\n";
                        break;
                    case 95:
                        cards += "Three Of Wands\n";
                        break;
                    case 96:
                        cards += "Two Of Cups\n";
                        break;
                    case 97:
                        cards += "Two Of Pentacles\n";
                        break;
                    case 98:
                        cards += "Two Of Swords\n";
                        break;
                    case 99:
                        cards += "Two Of Wands\n";
                        break;
                    default:
                        cards += "Close\n";
                        break;
                }
            }
        }

    }
}
