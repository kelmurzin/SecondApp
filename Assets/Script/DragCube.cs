using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragCube : MonoBehaviour
{
    public bool ActiveDrag = true;

    private Vector3 _pointScreen;
    private Vector3 _curPos;

    private Rigidbody _rb;
      
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        _pointScreen = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        ActiveDrag = true;
    }

    private void OnMouseUp() => _rb.useGravity = true;

    private void OnMouseDrag()
    {
        if (ActiveDrag)
        {
            Vector3 curScreenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _pointScreen.z);
            _curPos = Camera.main.ScreenToWorldPoint(curScreenPos);
            _rb.velocity = new Vector3(_curPos.x, _curPos.y, 0);
            _rb.useGravity = false;


        }
        else
            _rb.useGravity = true;
                   
    }
}
