using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float PlayerSpeed = 5f;
    public  float Speed = -9.81f;
    private Vector2 _movementDirection;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        _movementDirection = Time.deltaTime * PlayerSpeed * horizontalInput * Vector2.right;
        _movementDirection.y = Speed * Time.deltaTime;

        transform.Translate(_movementDirection);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameManager>().GameOver();
    }
}
