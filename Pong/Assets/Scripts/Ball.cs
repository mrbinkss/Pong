using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 300f;
    public Vector2 direction {  get; private set; }
    public new Rigidbody2D rigidbody {  get; private set; }

    private Vector2 _startingPostition;

    public void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _startingPostition = transform.position;
        AddStartingForce();
    }
    private void AddStartingForce()
    {
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));

        this.rigidbody.AddForce(direction * this.speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Paddle"))
        {
            speed += 60;
            direction = -direction;
            this.rigidbody.AddForce(direction * this.speed);
        }
    }

    public void Reset()
    {
        this.rigidbody.linearVelocity = Vector3.zero;
        this.rigidbody.position = Vector3.zero;

        AddStartingForce();
    }
}
