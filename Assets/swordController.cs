using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordController : MonoBehaviour
{
    public float rotateSpeed;
    public float modifier = 1f;
    public Rigidbody2D swordRb;
    public Transform swordTrans;
    // Start is called before the first frame update
    void Start()
    {
        swordRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        swordTrans.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        rotateSpeed = swordRb.velocity.x * modifier;
        //swordRb.rotation += swordRb.velocity.x * rotateSpeed;
                
    }
}
