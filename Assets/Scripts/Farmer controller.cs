using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private float speed = 5f;
    public float boundary=10f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        Vector2 moveDirection= new Vector2(moveInput,0);
        transform.Translate(moveDirection*speed*Time.deltaTime);
        Vector2 currentPosition= transform.position;

        currentPosition.x = Mathf.Clamp(currentPosition.x, -boundary, boundary);
        transform.position = currentPosition;

        if (Input.GetKeyDown(KeyCode.A)) 
        {
            transform.localScale = new Vector2(-1, 1);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector2(1, 1);
        }
    }
    
}
