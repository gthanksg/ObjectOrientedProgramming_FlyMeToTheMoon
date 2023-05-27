﻿using System;
using System.Globalization;

namespace FlyMeToTheMoon
{
    public class Player : DrawObject
    {
        protected int HighScore;
        protected int SmHighScore;
        protected int Health;
        protected int UsedBullets;
        protected int Hits;
        public bool IsMovingLeft;
        public bool IsMovingRight;
        protected int Difficulty;

        public int GetDifficulty()
        {
            return Difficulty;
        }

        public void SetDifficulty(int value)
        {
            Difficulty = value;
        }

        public void IncDifficulty()
        {
            if (Difficulty == 2)
            {
                Difficulty = 0;
            }
            else
            {
                Difficulty++;
            }
        }

        public string GetAccuracy()
        {
            if (UsedBullets == 0) return "0";
            float hits = Hits * 100;
            var accuracy = hits / UsedBullets;
            var decimalValue = Math.Round((decimal)accuracy, 0);
            return decimalValue.ToString(CultureInfo.InvariantCulture);
        }
        
        public void SetUsedBullets(int value)
        {
            UsedBullets = value;
        }
        
        public void IncUsedBullets(int value)
        {
            UsedBullets += value;
        }
        
        public void SetHits(int value)
        {
            Hits = value;
        }
        
        public void IncHits(int value)
        {
            Hits += value;
        }

        public void SetHighScore(int value)
        {
            HighScore = value;
        }

        public void SetHeath(int value)
        {
            Health = value;
        }

        public void DecHealth(int value)
        {
            Health -= value;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public int GetHealth()
        {
            return Health;
        }
        
        public int GetHighScore()
        {
            return HighScore;
        }

        public void IncHighScore(int incValue)
        {
            SmHighScore += incValue;
            if (SmHighScore > 50) {
                HighScore += 10;
                SmHighScore = 0;
            }
        }
    }
}