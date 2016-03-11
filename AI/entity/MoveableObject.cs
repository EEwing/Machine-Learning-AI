using AI.interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI.entity {
    abstract class MoveableObject : IMoveableObject, IUpdatable {

        protected Rectangle bounds = Rectangle.Empty;

        public Vector2 Velocity = Vector2.Zero;
        private Vector2 Location;

        public void SetWidth(int width) {
            bounds.Width = width;
        }

        public void SetHeight(int height) {
            bounds.Height = height;
        }

        public Vector2 GetLocation() {
            return Location;
        }

        public virtual void Update(double dt) {
            //Console.WriteLine("Updating with velocity " + Velocity);
            MoveBy(Velocity * (float)dt);
        }

        public void Move(Vector2 newLocation) {
            int screenWidth = AIGame.Instance.GraphicsDevice.PresentationParameters.BackBufferWidth;
            int screenHeight = AIGame.Instance.GraphicsDevice.PresentationParameters.BackBufferHeight;
            // Handle x-direction out of bounds
            if (newLocation.X + bounds.Width > screenWidth) {
                newLocation.X = screenWidth - bounds.Width;
            } else if (newLocation.X < 0) {
                newLocation.X = 0;
            }

            // Handle y-direction out of bounds
            if (newLocation.Y + bounds.Height > screenHeight) {
                newLocation.Y = screenHeight - bounds.Height;
            } else if (newLocation.Y < 0) {
                newLocation.Y = 0;
            }
            Location = newLocation;
            bounds.Location = Location.ToPoint();
        }

        public void MoveBy(Vector2 Delta) {
            Move(Location + Delta);
        }
    }
}
