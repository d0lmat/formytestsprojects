const float acceleration = 4f;
const float friction = 6.3f;
Vector2f vel = new Vector2f(0, 0); // скорость
Vector2f acc = new Vector2f(0, 0); // ускорение

***
acc.X = 0;
acc.Y = 0;

if (Keyboard.IsKeyPressed(Keyboard.Key.A))
{

  acc.X = -acceleration * deltaTime;
}

if (Keyboard.IsKeyPressed(Keyboard.Key.D))
{
  acc.X = acceleration * deltaTime;
}

if (Keyboard.IsKeyPressed(Keyboard.Key.W))
{
  acc.Y = -acceleration * deltaTime;
}

if (Keyboard.IsKeyPressed(Keyboard.Key.S))
{
  acc.Y = acceleration * deltaTime;
}
vel -= vel * friction * deltaTime;
vel += acc + 0.5f * acc;
pos += vel / zoom;
