using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using AI.entity;

namespace AI.scene {
    public class SceneMainMenu : Scene {

        private SpriteFont font;
        private Entity enemy = new Entity();
        private Player player = new Player();

        public SceneMainMenu() {
            enemy.Velocity = Vector2.Zero;
            enemy.Move(new Vector2(500, 200));
            enemy.target = player;
        }

        public override void LoadContent(ContentManager Content) {
            font = Content.Load<SpriteFont>("Arial");
            enemy.LoadContent(Content);
            player.LoadContent(Content);
        }

        public override void Render(SpriteBatch sb) {
            enemy.Render(sb);
            player.Render(sb);
        }

        public override void Update(double dt) {
            enemy.Update(dt);
            player.Update(dt);
        }
    }
}
