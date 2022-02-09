using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{   
    private int _numColor;
        
    private void Start()
    {        
        _numColor = Random.Range(0, 2);

        switch (_numColor)
        {
            case 1:
                 GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case 0:
                GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
        }
        
    }

}
