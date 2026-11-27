// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

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

        static float floorHeight = 400f;
        Vector2 playerposition = new Vector2(50f, floorHeight);
        float position = 0f;
        float speed = 2f;
        float jumptime = 20;
        float jumphtimer = 0;
        float jumpheight = 90f;
        float gravity = 2f;

        int floorOffset = 10;
        int[] floor = new int[500];

        int obstacleradius = 10;
        int obsticleoffset = 200;
        int[] obsticle = new int[50];

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
                obsticle[i] = obsticleoffset * i + 200 + Random.Integer(0, 20);
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            


        }
    }

}
