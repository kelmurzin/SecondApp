using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragCube : MonoBehaviour
{
    
    private float distance = 15;
    [SerializeField] private bool ActiveDrag;
 
    public void OnMouseDrag()
    {
        if (ActiveDrag)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            transform.position = objPosition;
        }
        
    }
    public void boolFalse()
    {
        if (ActiveDrag)
        {
            ActiveDrag = false;
            Invoke("boolFalse", 1f);
        }
        else
            ActiveDrag = true;
    }
}
