using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Script : MonoBehaviour
{
    public GameObject Bullet;
    public static float Counter = 4;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Fire1"))
        {
            var clone = Instantiate(Bullet, transform.position, Bullet.transform.rotation);
            
            Destroy(clone, 2f);
        }

    }
}
    
