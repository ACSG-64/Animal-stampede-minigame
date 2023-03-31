using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    private float horizontalInput;
    private readonly float horizontalBoundRange = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // Set horizontal movement boundaries
        if (transform.position.x <= -horizontalBoundRange)
        {
            transform.position = new Vector3(-horizontalBoundRange, transform.position.y, transform.position.z);
            if (horizontalInput < 0) return;
        }
        else if (transform.position.x >= horizontalBoundRange)
        {
            transform.position = new Vector3(horizontalBoundRange, transform.position.y, transform.position.z);
            if (horizontalInput > 0) return;
        }

        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
    }
}
