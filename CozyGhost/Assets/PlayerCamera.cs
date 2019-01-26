using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Vector2 playerBounds;
    public Vector2 focuspoint;

    private Rigidbody2D RB;

    public void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        focuspoint = Vector2.zero;
    }

    public void FixedUpdate()
    {

        Vector2 diff = GhostMovementController.Instance.RB.position - RB.position;
        if(Mathf.Abs(diff.x) > playerBounds.x || Mathf.Abs(diff.y) > playerBounds.y)
            RB.MovePosition(RB.position + diff * GhostMovementController.Instance.Speed * Time.fixedDeltaTime);
    }
}
