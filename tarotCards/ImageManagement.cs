using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarotCards
{
    internal class ImageManagement
    {
        public void imageAdd(PictureBox picture, ToolTip tip, int id)
        {
            switch (id)
            {
                case 0:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "death.jpg"));
                    tip.SetToolTip(picture, "Death");
                    break;
                case 1:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "deathR.jpg"));
                    tip.SetToolTip(picture, "Death [Ters]");
                    break;
                case 2:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "judgement.jpg"));
                    tip.SetToolTip(picture, "Judgement");
                    break;
                case 3:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "judgementR.jpg"));
                    tip.SetToolTip(picture, "Judgement [Ters]");
                    break;
                case 4:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "justice.jpg"));
                    tip.SetToolTip(picture, "Justice");
                    break;
                case 5:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "justiceR.jpg"));
                    tip.SetToolTip(picture, "Justice [Ters]");
                    break;
                case 6:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "strength.jpg"));
                    tip.SetToolTip(picture, "Strength");
                    break;
                case 7:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "strengthR.jpg"));
                    tip.SetToolTip(picture, "Strength [Ters]");
                    break;
                case 8:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "temperance.jpg"));
                    tip.SetToolTip(picture, "Temperance");
                    break;
                case 9:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "temperanceR.jpg"));
                    tip.SetToolTip(picture, "Temperance [Ters]");
                    break;
                case 10:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theChariot.jpg"));
                    tip.SetToolTip(picture, "The Chariot");
                    break;
                case 11:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theChariotR.jpg"));
                    tip.SetToolTip(picture, "The Chariot [Ters]");
                    break;
                case 12:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theDevil.jpg"));
                    tip.SetToolTip(picture, "The Devil");
                    break;
                case 13:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theDevilR.jpg"));
                    tip.SetToolTip(picture, "The Devil [Ters]");
                    break;
                case 14:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theEmperor.jpg"));
                    tip.SetToolTip(picture, "The Emperor");
                    break;
                case 15:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theEmperorR.jpg"));
                    tip.SetToolTip(picture, "The Emperor [Ters]");
                    break;
                case 16:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theEmpress.jpg"));
                    tip.SetToolTip(picture, "The Empress");
                    break;
                case 17:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theEmpressR.jpg"));
                    tip.SetToolTip(picture, "The Empress [Ters]");
                    break;
                case 18:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theFool.jpg"));
                    tip.SetToolTip(picture, "The Fool");
                    break;
                case 19:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theFoolR.jpg"));
                    tip.SetToolTip(picture, "The Fool [Ters]");
                    break;
                case 20:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theHangedMan.jpg"));
                    tip.SetToolTip(picture, "The Hanged Man");
                    break;
                case 21:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theHangedManR.jpg"));
                    tip.SetToolTip(picture, "The Hanged Man [Ters]");
                    break;
                case 22:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theHermit.jpg"));
                    tip.SetToolTip(picture, "The Hermit");
                    break;
                case 23:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theHermitR.jpg"));
                    tip.SetToolTip(picture, "The Hermit [Ters]");
                    break;
                case 24:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theHierophant.jpg"));
                    tip.SetToolTip(picture, "The Hierophant");
                    break;
                case 25:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theHierophantR.jpg"));
                    tip.SetToolTip(picture, "The Hierophant [Ters]");
                    break;
                case 26:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theHighPriestess.jpg"));
                    tip.SetToolTip(picture, "The High Priestess");
                    break;
                case 27:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theHighPriestessR.jpg"));
                    tip.SetToolTip(picture, "The High Priestess [Ters]");
                    break;
                case 28:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theLovers.jpg"));
                    tip.SetToolTip(picture, "The Lovers");
                    break;
                case 29:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theLoversR.jpg"));
                    tip.SetToolTip(picture, "The Lovers [Ters]");
                    break;
                case 30:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theMagician.jpg"));
                    tip.SetToolTip(picture, "The Magician");
                    break;
                case 31:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theMagicianR.jpg"));
                    tip.SetToolTip(picture, "The Magician [Ters]");
                    break;
                case 32:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theMoon.jpg"));
                    tip.SetToolTip(picture, "The Moon");
                    break;
                case 33:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theMoonR.jpg"));
                    tip.SetToolTip(picture, "The Moon [Ters]");
                    break;
                case 34:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theStar.jpg"));
                    tip.SetToolTip(picture, "The Star");
                    break;
                case 35:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theStarR.jpg"));
                    tip.SetToolTip(picture, "The Star [Ters]");
                    break;
                case 36:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theSun.jpg"));
                    tip.SetToolTip(picture, "The Sun");
                    break;
                case 37:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theSunR.jpg"));
                    tip.SetToolTip(picture, "The Sun [Ters]");
                    break;
                case 38:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theTower.jpg"));
                    tip.SetToolTip(picture, "The Tower");
                    break;
                case 39:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theTowerR.jpg"));
                    tip.SetToolTip(picture, "The Tower [Ters]");
                    break;
                case 40:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theWorld.jpg"));
                    tip.SetToolTip(picture, "The World");
                    break;
                case 41:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "theWorldR.jpg"));
                    tip.SetToolTip(picture, "The World [Ters]");
                    break;
                case 42:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "wheelOfFortune.jpg"));
                    tip.SetToolTip(picture, "Wheel Of Fortune");
                    break;
                case 43:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "rotateCardsImages", "wheelOfFortuneR.jpg"));
                    tip.SetToolTip(picture, "Wheel Of Fortune [Ters]");
                    break;
                case 44:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "aceOfCups.jpg"));
                    tip.SetToolTip(picture, "Ace Of Cups");
                    break;
                case 45:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "aceOfPentacles.jpg"));
                    tip.SetToolTip(picture, "Ace Of Pentacles");
                    break;
                case 46:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "aceOfSwords.jpg"));
                    tip.SetToolTip(picture, "Ace Of Swords");
                    break;
                case 47:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "aceOfWands.jpg"));
                    tip.SetToolTip(picture, "Ace Of Wands");
                    break;
                case 48:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "eightOfCups.jpg"));
                    tip.SetToolTip(picture, "Eight Of Cups");
                    break;
                case 49:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "eightOfPentacles.jpg"));
                    tip.SetToolTip(picture, "Eight Of Pentacles");
                    break;
                case 50:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "eightOfSwords.jpg"));
                    tip.SetToolTip(picture, "Eight Of Swords");
                    break;
                case 51:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "eightOfWands.jpg"));
                    tip.SetToolTip(picture, "Eight Of Wands");
                    break;
                case 52:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "fiveOfCups.jpg"));
                    tip.SetToolTip(picture, "Five Of Cups");
                    break;
                case 53:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "fiveOfPentacles.jpg"));
                    tip.SetToolTip(picture, "Five Of Pentacles");
                    break;
                case 54:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "fiveOfSwords.jpg"));
                    tip.SetToolTip(picture, "Five Of Swords");
                    break;
                case 55:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "fiveOfWands.jpg"));
                    tip.SetToolTip(picture, "Five Of Wands");
                    break;
                case 56:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "fourOfCups.jpg"));
                    tip.SetToolTip(picture, "Four Of Cups");
                    break;
                case 57:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "fourOfPentacles.jpg"));
                    tip.SetToolTip(picture, "Four Of Pentacles");
                    break;
                case 58:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "fourOfSwords.jpg"));
                    tip.SetToolTip(picture, "Four Of Swords");
                    break;
                case 59:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "fourOfWands.jpg"));
                    tip.SetToolTip(picture, "Four Of Wands");
                    break;
                case 60:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "kingOfCups.jpg"));
                    tip.SetToolTip(picture, "King Of Cups");
                    break;
                case 61:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "kingOfPentacles.jpg"));
                    tip.SetToolTip(picture, "King Of Pentacles");
                    break;
                case 62:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "kingOfSwords.jpg"));
                    tip.SetToolTip(picture, "King Of Swords");
                    break;
                case 63:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "kingOfWands.jpg"));
                    tip.SetToolTip(picture, "King Of Wands");
                    break;
                case 64:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "knightOfCups.jpg"));
                    tip.SetToolTip(picture, "Knight Of Cups");
                    break;
                case 65:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "knightOfPentacles.jpg"));
                    tip.SetToolTip(picture, "Knight Of Pentacles");
                    break;
                case 66:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "knightOfSwords.jpg"));
                    tip.SetToolTip(picture, "Knight Of Swords");
                    break;
                case 67:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "knightOfWands.jpg"));
                    tip.SetToolTip(picture, "Knight Of Wands");
                    break;
                case 68:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "nineOfCups.jpg"));
                    tip.SetToolTip(picture, "Nine Of Cups");
                    break;
                case 69:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "nineOfPentacles.jpg"));
                    tip.SetToolTip(picture, "Nine Of Pentacles");
                    break;
                case 70:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "nineOfSwords.jpg"));
                    tip.SetToolTip(picture, "Nine Of Swords");
                    break;
                case 71:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "nineOfWands.jpg"));
                    tip.SetToolTip(picture, "Nine Of Wands");
                    break;
                case 72:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "pageOfCups.jpg"));
                    tip.SetToolTip(picture, "Page Of Cups");
                    break;
                case 73:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "pageOfPentacles.jpg"));
                    tip.SetToolTip(picture, "Page Of Pentacles");
                    break;
                case 74:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "pageOfSwords.jpg"));
                    tip.SetToolTip(picture, "Page Of Swords");
                    break;
                case 75:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "pageOfWands.jpg"));
                    tip.SetToolTip(picture, "Page Of Wands");
                    break;
                case 76:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "queenOfCups.jpg"));
                    tip.SetToolTip(picture, "Queen Of Cups");
                    break;
                case 77:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "queenOfPentacles.jpg"));
                    tip.SetToolTip(picture, "Queen Of Pentacles");
                    break;
                case 78:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "queenOfSwords.jpg"));
                    tip.SetToolTip(picture, "Queen Of Swords");
                    break;
                case 79:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "queenOfWands.jpg"));
                    tip.SetToolTip(picture, "Queen Of Wands");
                    break;
                case 80:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "sevenOfCups.jpg"));
                    tip.SetToolTip(picture, "Seven Of Cups");
                    break;
                case 81:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "sevenOfPentacles.jpg"));
                    tip.SetToolTip(picture, "Seven Of Pentacles");
                    break;
                case 82:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "sevenOfSwords.jpg"));
                    tip.SetToolTip(picture, "Seven Of Swords");
                    break;
                case 83:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "sevenOfWands.jpg"));
                    tip.SetToolTip(picture, "Seven Of Wands");
                    break;
                case 84:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "sixOfCups.jpg"));
                    tip.SetToolTip(picture, "Six Of Cups");
                    break;
                case 85:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "sixOfPentacles.jpg"));
                    tip.SetToolTip(picture, "Six Of Pentacles");
                    break;
                case 86:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "sixOfSwords.jpg"));
                    tip.SetToolTip(picture, "Six Of Swords");
                    break;
                case 87:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "sixOfWands.jpg"));
                    tip.SetToolTip(picture, "Six Of Wands");
                    break;
                case 88:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "tenOfCups.jpg"));
                    tip.SetToolTip(picture, "Ten Of Cups");
                    break;
                case 89:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "tenOfPentacles.jpg"));
                    tip.SetToolTip(picture, "Ten Of Pentacles");
                    break;
                case 90:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "tenOfSwords.jpg"));
                    tip.SetToolTip(picture, "Ten Of Swords");
                    break;
                case 91:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "tenOfWands.jpg"));
                    tip.SetToolTip(picture, "Ten Of Wands");
                    break;
                case 92:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "threeOfCups.jpg"));
                    tip.SetToolTip(picture, "Three Of Cups");
                    break;
                case 93:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "threeOfPentacles.jpg"));
                    tip.SetToolTip(picture, "Three Of Pentacles");
                    break;
                case 94:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "threeOfSwords.jpg"));
                    tip.SetToolTip(picture, "Three Of Swords");
                    break;
                case 95:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "threeOfWands.jpg"));
                    tip.SetToolTip(picture, "Three Of Wands");
                    break;
                case 96:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "twoOfCups.jpg"));
                    tip.SetToolTip(picture, "Two Of Cups");
                    break;
                case 97:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "twoOfPentacles.jpg"));
                    tip.SetToolTip(picture, "Two Of Pentacles");
                    break;
                case 98:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "twoOfSwords.jpg"));
                    tip.SetToolTip(picture, "Two Of Swords");
                    break;
                case 99:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsImages", "twoOfWands.jpg"));
                    tip.SetToolTip(picture, "Two Of Wands");
                    break;
                default:
                    picture.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "allCardsImages", "cardsBackimage", "tarotCard.jpg"));
                    tip.SetToolTip(picture, "Close");
                    break;
            }
        }
    }
}
