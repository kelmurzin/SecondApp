using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Определяет какого цвета будет куб.
/// </summary>
public class CubeColor : MonoBehaviour
{
    public bool IsLeft => isLeft;

    private int _numColor;
    private bool isLeft;
    
    private void Start()
    {        
        _numColor = Random.Range(0, 2);

        switch (_numColor)
        {
            case 1:
                 GetComponent<MeshRenderer>().material.color = Color.red;
                isLeft = true;
                break;
            case 0:
                GetComponent<MeshRenderer>().material.color = Color.blue;
                isLeft = false;
                break;
        }
        
    }

}
