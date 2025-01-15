using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateMovement : MonoBehaviour
{
    public bool dragging = false;

    // Update is called once per frame
    void Update()
    {

        CheckForClicks();

        //if this is currently being dragged
        if (this.dragging)
        {
            //create a variable to hold the mouse position just because it looks clearer and easier to read
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //now we create a second vector3 as we don't want the sprite z axis to match the mouse position only on X and Y we want to stay on the same z axis
            Vector3 position = new Vector3(mousePosition.x, mousePosition.y, 1);
            //set its position equal to the vector3 we just created
            transform.position = position;
        }
    }

    private void CheckForClicks()
    {
        //if left click
        if (Input.GetMouseButtonDown(0))
        {
            //get mouse position as world position
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //ray cast and whatever was hit gets returned
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            //did we hit something with a collider?
            if (hit.collider != null)
            {
                //is the collider we hit the same as the whichever object is currently running this script?
                if (hit.collider.gameObject == gameObject)
                {
                    //yes it is so set draggable to true, which lets the update function lock its position to the mouse position
                    this.dragging = true;
                }

            }

        }
        //if we press right click stop draggin this object
        else if (Input.GetMouseButtonDown(1))
        {
            //and if whatever is running this script is currently being dragged
            if (this.dragging)
            {
                //set dragging to false
                this.dragging = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log(collision);
        //if the game object we collided with is not equal to the current game object (so anything other than itself)
        if (collision.gameObject != gameObject)
        {
            //turn dragging for this object off because we hit something
            this.dragging = false;
        }
    }

}

