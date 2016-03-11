using AI.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI.scene {
    interface IScene : IRenderable, IUpdatable, IContentLoadable {
        void Enter();
        void Exit();
    }
}
