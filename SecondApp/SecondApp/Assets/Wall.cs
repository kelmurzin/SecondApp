using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
public class Wall : MonoBehaviour
{
    public UnityEvent destroyCube;   
    [SerializeField] private bool Active;
    [SerializeField] private TMP_Text redText;
    [SerializeField] private TMP_Text blueText;
    private int red;
    private int blue;

    private void OnTriggerEnter(Collider other)
    {
        if (Active)
        {

            if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.blue)
            {
                Destroy(other.gameObject);
                blue++;
                blueText.text = blue.ToString();
                destroyCube?.Invoke();
            }

            else
            {
                other.gameObject.GetComponent<DragCube>().boolFalse();                
            }
           
        }
        if(!Active)
        {
            
            if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.red)
            {
                Destroy(other.gameObject);
                red++;
                redText.text = red.ToString();
                destroyCube?.Invoke();
            }
            else
            {
                other.gameObject.GetComponent<DragCube>().boolFalse();
            }

        }


    }




}

