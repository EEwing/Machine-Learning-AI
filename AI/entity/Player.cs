using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI.entity {
    class Player : Entity {

        bool[] keys = { false, false, false, false };
        int speed = 200;

        public override void Update(double dt) {
            keys[0] = Keyboard.GetState().IsKeyDown(Keys.W);
            keys[1] = Keyboard.GetState().IsKeyDown(Keys.A);
            keys[2] = Keyboard.GetState().IsKeyDown(Keys.S);
            keys[3] = Keyboard.GetState().IsKeyDown(Keys.D);

            if (keys[0] != keys[2]) {
                Velocity.Y = keys[0] ? -speed : speed;
            } else {
                Velocity.Y = 0;
            }

            if(keys[1] != keys[3]) {
                Velocity.X = keys[1] ? -speed : speed;
            } else {
                Velocity.X = 0;
            }
            
            base.Update(dt);
        }
    }
}
