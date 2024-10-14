using UnityEngine;

public class Player1Paddle : Paddle
{
    private Vector2 _direction;

    private void Update()
    {
        // Check for touch input on the left half of the screen
        if (Input.touchCount > 0) // If there's at least one touch
        {
            foreach (Touch touch in Input.touches)
            {
                // Only respond to touches on the left half of the screen
                if (touch.position.x <= Screen.width / 2)
                {
                    // Convert touch position to world point
                    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 0));

                    // Determine the direction based on the touch position relative to the paddle
                    if (touchPosition.y > transform.position.y)
                    {
                        _direction = Vector2.up; // Move paddle up
                    }
                    else if (touchPosition.y < transform.position.y)
                    {
                        _direction = Vector2.down; // Move paddle down
                    }
                    break; // Stop checking after the first valid touch for Player 1
                }
            }
        }
        else
        {
            _direction = Vector2.zero; // No touch, stop the paddle
        }
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0) // If there is movement
        {
            // Move the paddle based on direction and speed
            _rigidbody.velocity = _direction * this.speed;
        }
        else
        {
            // Stop the paddle when no input is given
            _rigidbody.velocity = Vector2.zero;
        }
    }
}
