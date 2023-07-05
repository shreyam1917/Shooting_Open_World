using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Sphere : MonoBehaviour
{
    public float Speed;
    public float Jump;
    float x, y, z;
    public Rigidbody rgdby;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Jump");
        z = Input.GetAxis("Vertical");
        rgdby.velocity = new Vector3(x * Speed, rgdby.velocity.y, z * Speed);
        rgdby.AddForce(y * Jump * transform.up);
    }
}
