using UnityEngine;
using UnityEngine.EventSystems;

public class NpcPaddle : MonoBehaviour
{
    public float speed = 50f;
    public new Rigidbody2D rigidbody { get; private set; }
    public Vector2 direction { get; private set; }
    public Rigidbody2D ball;

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(this.rigidbody.position.y > ball.position.y)
        {
            MoveDirection(Vector2.down);
        }
        else if(this.rigidbody.position.y < ball.position.y)
        {
            MoveDirection(Vector2.up);
        }
        else
        {
            MoveDirection(Vector2.zero);
        }
    }

    private void MoveDirection(Vector2 direction)
    {
        this.rigidbody.AddForce(direction * speed);
    }
}
