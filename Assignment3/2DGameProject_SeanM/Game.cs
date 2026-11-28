// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Texture2D graphic1 = Graphics.LoadTexture("C:\\Users\\epicg\\Downloads\\2DGameAssignment\\Idle.png");
        Texture2D graphic2 = Graphics.LoadTexture("C:\\Users\\epicg\\Downloads\\2DGameAssignment\\Running1.png");
        Texture2D graphic3 = Graphics.LoadTexture("C:\\Users\\epicg\\Downloads\\2DGameAssignment\\Running2.png");
        Texture2D graphic4 = Graphics.LoadTexture("C:\\Users\\epicg\\Downloads\\2DGameAssignment\\Running3.png");
        Texture2D graphic5 = Graphics.LoadTexture("C:\\Users\\epicg\\Downloads\\2DGameAssignment\\Running4.png");
        Texture2D graphic6 = Graphics.LoadTexture("C:\\Users\\epicg\\Downloads\\2DGameAssignment\\Running5.png");
        Texture2D graphic7 = Graphics.LoadTexture("C:\\Users\\epicg\\Downloads\\2DGameAssignment\\Running6.png");
        Texture2D graphic8 = Graphics.LoadTexture("C:\\Users\\epicg\\Downloads\\2DGameAssignment\\Present.png");
        Texture2D graphic9 = Graphics.LoadTexture("C:\\Users\\epicg\\Downloads\\2DGameAssignment\\Jump.png");

        static float floorHeight = 400f;
        Vector2 playerposition = new Vector2(400f, floorHeight);
        float position = 0f;
        float speed = 3f;
        float jumptime = 20;
        float jumphtimer = 0;
        float jumpheight = 140f;
        float gravity = 2.7f;

        int floorOffset = 10;
        int[] floor = new int[500];

        int obstacleradius = 10;
        int obsticleoffset = 285;
        int[] obsticle = new int[100];

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.ClearBackground(0);

            for (int i = 0; i < floor.Length; i++)
            {
                floor[i] = floorOffset + (i * 10);
            }

            for (int i = 0; i < obsticle.Length; i++)
            {
                obsticle[i] = obsticleoffset * i + 350 + Random.Integer(0, 0);
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(0);
            Draw.SetFillColor(Color.White);
            Draw.Rectangle(0, 400, 800, 600);

            if (playerposition.Y < floorHeight)
            {
                playerposition.Y += gravity;
            }
            else
            {
                playerposition.Y = floorHeight;
            }

            if (Input.IsKeyboardKeyPressed(KeyboardKey.Space) && playerposition.Y == floorHeight)
            {
                playerposition.Y -= jumpheight / jumptime;
                jumphtimer = jumptime; 
            }

            if (jumphtimer > 0)
            {
                playerposition.Y -= jumpheight / jumptime;
                jumphtimer--; Graphics.Draw(graphic9, playerposition.X - 280f, playerposition.Y - 80f);
            }

            position += speed;

            foreach (int f in floor)
            {
                Draw.FillColor = Color.White;
                Draw.Rectangle(f - floorHeight, 400f, 10f, 10f);
            }

            foreach (int o in obsticle)
            {
                Graphics.Draw(graphic8, o - position, 350f - obstacleradius);
                
                // Check for collision with the player
                if (Vector2.Distance(playerposition, new Vector2(o - position, 390f + obstacleradius)) < obstacleradius + 20f)
                {
                    // Collision detected, reset game
                    playerposition = new Vector2(400f, floorHeight);
                    position = 50f;
                }
                
                {
                    Graphics.Draw(graphic2, playerposition.X - 280f, playerposition.Y - 80f);

                }



            }

        }
    }
}