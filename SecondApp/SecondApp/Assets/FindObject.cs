using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindObject : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    public void StartFind()
    {
        Invoke("Find", .5f);
    }

    private void Find()
    {        
        var cube=FindObjectOfType<DragCube>();
        if (cube ==null)
        {
            panel.SetActive(true);                        
        }                
    }
}
