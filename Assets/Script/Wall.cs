using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Wall : MonoBehaviour
{
    public UnityEvent destroyCube;   

    [SerializeField] private bool _active;
    [SerializeField] private TMP_Text _redText;
    [SerializeField] private TMP_Text _blueText;

    private int _red;
    private int _blue;

    private void OnTriggerEnter(Collider other)
    {
        if (_active)
        {
            if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue)
            {
                Destroy(other.gameObject);
                _blue++;
                _blueText.text = _blue.ToString();
                destroyCube?.Invoke();
            }
            else
                other.gameObject.GetComponent<DragCube>().ActiveDrag = false;
            
        }

        if(!_active)
        {           
            if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.red)
            {
                Destroy(other.gameObject);
                _red++;
                _redText.text = _red.ToString();
                destroyCube?.Invoke();
            }
            else          
                other.gameObject.GetComponent<DragCube>().ActiveDrag = false;          
        }
    }
}

