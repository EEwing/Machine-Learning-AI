﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace AI.interfaces {
    interface IContentLoadable {
        void LoadContent(ContentManager Content);
    }
}
