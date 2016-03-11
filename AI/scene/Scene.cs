using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;

namespace AI.scene {
    public abstract class Scene : IScene {

        public static readonly Scene MAIN_MENU = new SceneMainMenu();

        public abstract void Update(double dt);
        public abstract void Render(SpriteBatch sb);

        public virtual void Enter() { }
        public virtual void Exit() { }

        public abstract void LoadContent(ContentManager Content);
    }
}
