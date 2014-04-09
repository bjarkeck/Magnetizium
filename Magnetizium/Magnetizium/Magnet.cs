using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magnetizium
{
    class Magnet
    {
        //The "full" force of the magnet
        float magnetForce;
        //Sets the maximum lenght at which the magnets drag still have any effect
        float magnetForceLenght;
        //The calculatedForce will be the one that determines how much the box will be moved
        float dragMultiplier;
        //Holds 1%maxdrag
        float maxDrag;
        //The amount of drag that it drags the shape with
        float actualDrag;


        Texture2D texture;
        Vector2 position;
               

        public float MagnetForce
        {
            get { return magnetForce; }
            set { magnetForce = value; }
        }

        public float MagnetForceLenght
        {
            get { return magnetForceLenght; }
            set { magnetForceLenght = value; }
        }

        public float DragMultiplier
        {
            get { return dragMultiplier; }
            set { dragMultiplier = value; }
        }

        public float MaxDrag
        {
            get { return maxDrag; }
            set { maxDrag = value; }
        }

        public float ActualDrag
        {
            get { return actualDrag; }
            set { actualDrag = value; }
        }
        



        public Magnet()
        {

        }


        public void CalculateDrag()
        {
            //Could just divide by 10000
            //Just wrote what it needs to do
            //magnetForceLenght / 100 = maxDrag;
            //maxDrag / 100 = dragMultiplier;
            //magnetForce* dragMultiplier = actualDrag;
        }
    }
}
