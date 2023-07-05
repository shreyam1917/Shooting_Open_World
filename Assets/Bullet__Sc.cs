using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet__Sc : MonoBehaviour
{
    public Rigidbody Bullet;
    public float Shoot;
    public GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Bullet.AddForce(Shoot * transform.up);
        Shoot_Script.Counter -= Time.deltaTime; 
    }
   private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            if(Shoot_Script.Counter <= 0 )
            {
                Shoot_Script.Counter = 4;
                Destroy(collision.gameObject);
            }
            if (Shoot_Script.Counter > 0)
            {

                Destroy(gameObject);
            }
        }
    }
}
