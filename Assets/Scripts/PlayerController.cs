using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float horizontalBoundRange = 10;
    public GameObject projectilePrefab;
    private float horizontalInput;    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveHorizontally();
        FireProjectile();
    }

    private void MoveHorizontally()
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

    private void FireProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
