using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    
    private Vector2 initialPosition; 
    private bool isFingerTouching = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isFingerTouching = true;
            initialPosition = Input.mousePosition;
        }
    

        if (Input.GetMouseButton(0) && isFingerTouching == true)
        {
            var diff = (Input.mousePosition - initialPosition).Normalized * speed;
            rb.velocity = new Vector3 (diff.x, 0, diff.y);
        }

        if (Input.GetMouseButtonDown(0) && isFingerTouching == false)
        {
            rb.velocity = Vector3.Zero;
            isFingerTouching = false;
        }
    }
}
