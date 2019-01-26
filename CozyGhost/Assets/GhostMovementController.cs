using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class GhostMovementController : MonoBehaviour
{
    public static GhostMovementController Instance = null;

    public float Speed = 1f;
    
    public Rigidbody2D RB { get; private set; }

    public void Awake()
    {
        if (Instance == null)
            Instance = this;

        RB = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        RB.MovePosition(RB.position + movement * Speed * Time.fixedDeltaTime);
    }
}
