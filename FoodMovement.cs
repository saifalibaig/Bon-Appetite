using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    [HideInInspector]
    public float speed;

    Vector2 difference = Vector2.zero;
    bool picked = false;

    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition) - (Vector2)transform.position;
    }

    private void OnMouseDrag()
    {
        transform.position =(Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) -  difference;
        picked = true;
    }
    private Rigidbody2D rd;
    void Awake()
    {
        rd = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (picked == true)
        {
            rd.velocity = new Vector2(0, rd.velocity.y);
        }
        else
        {
            rd.velocity = new Vector2(speed, rd.velocity.y);
        }

        

    }
}
