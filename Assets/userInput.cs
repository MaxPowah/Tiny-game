using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userInput : MonoBehaviour
{
    public GameObject sword;
    Rigidbody2D selectedObject;
    Vector3 mousePos;
    Vector3 offset;
    private swordController swCtrl;
    
    public Vector3 pastPos;
    public Vector3 presentPos;
    public float swVelocity;

    
    // Start is called before the first frame update
    void Start()
    {
        swCtrl = sword.GetComponent<swordController>();
    }
    void Update() {
        //* velocity stuff
        //just like in physics class
        swVelocity = ((swCtrl.swordTrans.position - pastPos).magnitude) / Time.deltaTime;
        pastPos = swCtrl.swordTrans.position;
        
        //*mouse stuff
        mousePos = Input.mousePosition;
        //Debug.Log(mousePos);
        if (Input.GetMouseButtonDown(0))
        {
            
            Collider2D targetObject = Physics2D.OverlapPoint(mousePos);
            if(targetObject){
                Debug.Log("selected the sword");
                selectedObject = sword.transform.gameObject.GetComponent<Rigidbody2D>();
                offset = sword.transform.position - mousePos;

            }
            else
                Debug.Log("missed");
        }
        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            selectedObject = null;
        }
    }
    void FixedUpdate()
    {
        if (selectedObject)
        {
            //selectedObject.velocity = new Vector2 ((mousePos.x + offset.x), (mousePos.y + offset.y));
            selectedObject.MovePosition(mousePos + offset);
            Debug.Log("past: " + pastPos + " present: " + presentPos);
            
        }
    }
}
