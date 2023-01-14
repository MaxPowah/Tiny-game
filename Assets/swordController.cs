using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordController : MonoBehaviour
{
    public float rotateSpeed;
    public Rigidbody2D swordRb;
    // Start is called before the first frame update
    void Start()
    {
        swordRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(swordRb.velocity.x != 0)
        {
            swordRb.rotation += swordRb.velocity.x * rotateSpeed;
        }
        else
        {
            //swordRb.SetRotation(180);
        }
        
    }
}
