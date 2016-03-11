using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI.interfaces {
    interface IMoveableObject {
        void Move(Vector2 newLocation);
        void MoveBy(Vector2 Delta);
    }
}
