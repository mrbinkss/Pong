using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 300f;
    public Vector2 direction {  get; private set; }
    public new Rigidbody2D rigidbody {  get; private set; }

    public void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        direction = new Vector2(Random.Range(-1f,1f), Random.Range(-1f,1f));

        this.rigidbody.AddForce(direction * this.speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided");
    }
}
