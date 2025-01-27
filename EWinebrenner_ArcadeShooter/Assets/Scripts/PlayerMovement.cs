using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 8.0f;
    Rigidbody2D _rb;
    float xInput;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world wwww");
        Debug.LogWarning("WARNING");
        Debug.LogError("ERROR");
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("SPACE HELD");
        //}
        xInput = Input.GetAxisRaw("Horizontal");
       // Debug.Log(xInput);

        //Other versions of GetComponent
        //GetComponent("Rigidbody2D");
       // GetComponent(typeof(Rigidbody2D));
    }
    private void FixedUpdate()
    {
        //Get current velocity
        Vector2 v = _rb.velocity;
        //Change just the X
        v.x = xInput * speed;
        //Set velocity
        _rb.velocity = v;

        //_rb.position += _rb.velocity * Time.fixedDeltaTime;
    }
}
