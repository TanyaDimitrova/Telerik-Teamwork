﻿namespace FyodorDostoevskyRPG
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
   
    class Unit: IActions
    {
        protected string name;
        protected int health;
        protected int damage;
        protected Vector2 position;
        protected Texture2D image;
        protected bool isAlive;

        public string Name
        {
            get 
            { 
                return name; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The unit cannot be nameless!");
                }
                name = value; 
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value <= 1)
                {
                    throw new ArgumentNullException("Health value has be a positive integer number");
                }
                health = value;
            }
        }
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value <= 1)
                {
                    throw new ArgumentNullException("Damage value has be a positive integer number");
                }
                damage = value;
            }
        }
        public Vector2 Position
        {
            get
            {
                return position;
            }
            set
            {
                if ((value.X < 0) || (value.X > 800) || (value.Y < 0) || (value.Y > 600))
                {
                    throw new ArgumentOutOfRangeException("Coordinates out of screen! (800x600)");
                }
                position.X = value.X;
                position.Y = value.Y;
            }
        }
        public Texture2D Image
        {
            get
            {
                return image;
            }
            set
            {
         //       image.SetData(); Тук ми е малко тъмна индия :D
            }
        }



        //методи от интерфейса IActions
        public void IsAlive(int health)
        {
            if (health <= 0)
            {
                this.isAlive = false;
            }
        }
        public void DisplayHealth(int health)
        { 
            
        }
        public void TakeDamage(int damage)
        {
            this.Health -= damage;
        }
        public void Attack(int damage)
        { 
            //
        }


        
    }
}
