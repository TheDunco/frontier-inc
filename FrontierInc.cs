using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Nez;
using Nez.Textures;

namespace FrontierInc
{
    public class FrontierInc : Core 
    {
        //private GraphicsDeviceManager _graphics;
        //private SpriteBatch _spriteBatch;
        private static readonly int numPlanets = 54;
        private static readonly int numRingPlanets = 26;
        private static readonly int numMoons = 37;
        private int planetIndex = 0;

        private int planetScaleFactor = 10;

        #region sprite definitions
        List<Texture2D> Planets = new List<Texture2D>();
        List<Texture2D> RingPlanets = new List<Texture2D>();
        List<Texture2D> Moons = new List<Texture2D>();
        #endregion

        // set window size...
        public FrontierInc() : base()
        {
            //_graphics = new GraphicsDeviceManager(this);
            //Content.RootDirectory = "Content";
            //IsMouseVisible = true;
        }

        // occurs when game starts. Apply settings and load components
        protected override void Initialize()
        {
            base.Initialize();

            var scene = Scene.CreateWithDefaultRenderer(Color.Black);

            var planet = scene.Content.Load<Texture2D>("planet1");
            var entity = scene.CreateEntity("first-planet");
            entity.AddComponent(new Spriterenderer(planet));

            // change this to change scene
            Core.Scene = scene;

        }



        //// load assets
        //protected override void LoadContent()
        //{
        //    _spriteBatch = new SpriteBatch(GraphicsDevice);

        //    // load planets
        //    for(int i = 1; i <= numPlanets; i++)
        //    {
        //        Planets.Add(Content.Load<Texture2D>($"planet{i}"));
        //    }
        //    // load ringplanets
        //    for (int i = 1; i <= numRingPlanets; i++)
        //    {
        //        RingPlanets.Add(Content.Load<Texture2D>($"ring-planet{i}"));
        //    }
        //    // load moons
        //    for (int i = 1; i <= numMoons; i++)
        //    {
        //        Moons.Add(Content.Load<Texture2D>($"moon{i}"));
        //    }
        //}
        
        //// game loop
        //// 60fps by default
        //protected override void Update(GameTime gameTime)
        //{
        //    Random rand = new Random();
        //    MouseState mouseState = Mouse.GetState();
        //    Point mousePosition = new Point(mouseState.X, mouseState.Y);

        //    if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
        //        Exit();

        //    if(Mouse.GetState().LeftButton == ButtonState.Pressed)
        //    {
        //        planetIndex = rand.Next(numPlanets);
        //        Debug.WriteLine(planetIndex);
        //    }

        //    // TODO: Add your update logic here

        //    base.Update(gameTime);
        //}

        //// graphics/drawing to screen
        //// also runs every frame. Solely for drawing images and text.
        //// no variables or calculations in there; uses graphics card
        //protected override void Draw(GameTime gameTime)
        //{
        //    GraphicsDevice.Clear(Color.CornflowerBlue);

        //    _spriteBatch.Begin();

        //    _spriteBatch.Draw(Planets[planetIndex],
        //        new Rectangle(0, 0, 800/planetScaleFactor, 702/planetScaleFactor),
        //        new Rectangle(0, 0, 800, 702),
        //        Color.White);

        //    _spriteBatch.End();

        //    base.Draw(gameTime);
        //}
    }
}
