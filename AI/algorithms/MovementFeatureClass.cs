using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AI.entity;
using Microsoft.Xna.Framework;

namespace AI.algorithms {
    class MovementFeatureClass : entity.Entity.FeatureSet.FeatureClass {
        FeatureType Type = FeatureType.MOVMT_AGGRESSIVE;
        private Entity.FeatureSet featureSet;
        private Entity entity;

        public MovementFeatureClass(Entity entity) {
            this.entity = entity;
        }

        public override void Update(double dt) {
            switch(Type) {
                case FeatureType.MOVMT_AGGRESSIVE:
                    if (entity.target != null) {
                        // Run toward the target
                        Vector2 diff = entity.target.GetLocation() - entity.GetLocation();
                        diff.Normalize();
                        entity.Velocity = diff * entity.Speed;
                    }
                    break;
                case FeatureType.MOVMT_SCARED:
                    if (entity.target != null) {
                        // Run away from the target
                        Vector2 diff = entity.target.GetLocation() - entity.GetLocation();
                        diff.Normalize();
                        entity.Velocity = diff * -entity.Speed;
                    }
                    break;
                case FeatureType.MOVMT_PASSIVE:
                    // Don't move and fall through to unknown
                case FeatureType.UNKNOWN:
                    break;
            }
        }
    }
}
