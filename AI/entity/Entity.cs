using AI.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using AI.algorithms;

namespace AI.entity {
    class Entity : MoveableObject, IEntity, IContentLoadable {

        Texture2D texture;
        public FeatureSet Features;
        public Entity target;

        public int Speed { get; set; } = 100;

        public Entity() {
            Features = new FeatureSet(this);
        }

        public void LoadContent(ContentManager Content) {
            texture = Content.Load<Texture2D>("Textures/enemy2");
            SetWidth(texture.Width*2);
            SetHeight(texture.Height*2);
        }

        public void Render(SpriteBatch sb) {
            sb.Draw(texture, bounds, Color.White);
        }

        public override void Update(double dt) {
            Features.Update(dt);
            base.Update(dt);
        }

        public class FeatureSet : IUpdatable {
            private Entity entity;
            FeatureClass MovementFeatures;



            public FeatureSet(Entity entity) {
                this.entity = entity;
                MovementFeatures = new MovementFeatureClass(entity);
            }

            public void Update(double dt) {
                MovementFeatures.Update(dt);
            }

            public abstract class FeatureClass : IUpdatable {
                protected enum FeatureType {
                    MOVMT_AGGRESSIVE,
                    MOVMT_PASSIVE,
                    MOVMT_SCARED,
                    CBT_ATTACK,
                    CBT_DEFEND,
                    CBT_ALTERNATE,
                    UNKNOWN
                }
                public abstract void Update(double dt);
            }
        }
    }
}
