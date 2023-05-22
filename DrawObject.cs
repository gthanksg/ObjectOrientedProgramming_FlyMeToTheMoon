﻿using System.Drawing;

namespace FlyMeToTheMoon
{
    public class DrawObject
    {
        protected int PosX;
        protected int PosY;
        protected int Width;
        protected int Height;
        protected bool IsDrawing;

        public void SetDrawingStatus(bool drawingStatus)
        {
            IsDrawing = drawingStatus;
        }

        public bool GetDrawingStatus()
        {
            return IsDrawing;
        }

        public void SetWidthHeight(int width, int height)
        {
            Height = height;
            Width = width;
        }

        public bool CheckWorldBorders(int maxBord, int moveSize, bool inc)
        {
            if ((PosX - moveSize <= 0) && !inc)
            {
                return false;
            }
            if ((PosX + moveSize >= maxBord) && inc)
            {
                return false;
            }
            return true;
        }

        public void IncX(int incX)
        {
            PosX += incX;
        }
        
        public void IncY(int incY)
        {
            PosY += incY;
        }
        
        public void DecX(int decX)
        {
            PosX -= decX;
        }
        
        public void DecY(int decY)
        {
            PosY -= decY;
        }
        
        public int GetWidth()
        {
            return Width;
        }
        
        public int GetHeight()
        {
            return Height;
        }

        public int GetX()
        {
            return PosX;
        }
        
        public int GetY()
        {
            return PosY;
        }

        public void SetPosition(int posX, int posY)
        {
            PosX = posX;
            PosY = posY;
        }
    }
}