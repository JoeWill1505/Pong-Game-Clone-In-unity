using JetBrains.Annotations;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    [SerializeField] private Rigidbody2D ball;

    public void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y)
            {
                _rigidbody.velocity = Vector2.up * this.speed;
            }
            else if (this.ball.position.y < this.transform.position.y)
            {
                _rigidbody.velocity = Vector2.down * this.speed;
            }
        }
        else
        {
            if (this.transform.position.y > 0.0f)
            {
                _rigidbody.velocity = Vector2.down * this.speed;
            }
            else if (this.transform.position.y < 0.0f)
            {
                _rigidbody.velocity = Vector2.up * this.speed;
            }
        }
    }
}
