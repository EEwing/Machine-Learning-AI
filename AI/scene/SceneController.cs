using AI.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace AI.scene {
    public class SceneController : IUpdatable, IRenderable, IContentLoadable {

        private Scene CurrentScene;

        public void Initialize() {
            CurrentScene = Scene.MAIN_MENU;
        }

        public void SwitchToScene(Scene scene) {
            CurrentScene.Exit();
            scene.Enter();

            CurrentScene = scene;
        }

        public void Update(double dt) {
            CurrentScene.Update(dt);
        }

        public void Render(SpriteBatch sb) {
            CurrentScene.Render(sb);
        }

        public void LoadContent(ContentManager Content) {
            Scene.MAIN_MENU.LoadContent(Content);
        }
    }
}
