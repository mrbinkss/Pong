using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerPaddle : MonoBehaviour
{
    public Vector2 startXLocation;
    public float speed = 50f;
    public new Rigidbody2D rigidbody {  get; private set; }
    public Vector2 direction {  get; private set; }


    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        if(Input.GetKey(KeyCode.UpArrow))
        {
            this.direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.direction = Vector2.down;
        }
        else
        {
            this.direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if(this.direction != Vector2.zero)
        {
            this.rigidbody.AddForce(this.direction * this.speed);
        }
    }
}
