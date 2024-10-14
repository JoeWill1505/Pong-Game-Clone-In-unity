using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    [SerializeField] private float bounceStrength = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            Vector2 normal = collision.GetContact(0).normal; 
            rb.AddForce(-normal * this.bounceStrength, ForceMode2D.Impulse); 
        }
    }
}
