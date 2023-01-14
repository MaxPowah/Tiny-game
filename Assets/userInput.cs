using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userInput : MonoBehaviour
{
    public GameObject sword;
    Rigidbody2D selectedObject;
    Vector3 mousePos;
    Vector3 offset;
    
    Vector2 pastPos;
    Vector2 presentPos;

    
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update() {
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
        pastPos = selectedObject.position;
        selectedObject.MovePosition(mousePos + offset);
        
    }
}
}
