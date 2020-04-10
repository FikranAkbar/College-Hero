using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.y = Mathf.Clamp(pos.y, -6, 6);

        pos.x = Mathf.Clamp(pos.x, -10, 10);

        transform.position = pos;
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }
    }
}
