using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    Vector2 move;
    Rigidbody2D rb2D;
    [SerializeField]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 raw = context.ReadValue<Vector2>();
        move = raw;
        Rotation(raw);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2D.velocity = new Vector2(move.x * speed, move.y * speed);
    }

    void Rotation(Vector2 vector)
    {
        if(vector.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }else if (vector.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }else if (vector.y < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        else if (vector.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
    }
}

