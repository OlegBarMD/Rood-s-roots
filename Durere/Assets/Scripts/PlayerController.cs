using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float PlayerSpeed = 5f;
    private readonly float _gravity = -9.81f;
    private Vector2 _movementDirection;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        _movementDirection = Time.deltaTime * PlayerSpeed * horizontalInput * Vector2.right;
        _movementDirection.y = _gravity * Time.deltaTime;

        transform.Translate(_movementDirection);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameManager>().GameOver();
    }
}
