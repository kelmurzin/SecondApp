using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/// <summary>
/// Триггер для уничтожения кубов.
/// </summary>
public class WallCheck : MonoBehaviour
{
    public static event Action<int,bool> onValueChange;
    public static event Action onCubeDestroy;

    [SerializeField] private bool isLeft;
    [SerializeField] private SC_DragRigidbody dragRigidbody;
    private int left;
    private int right;

    private void OnTriggerEnter(Collider other)
    {
        if (isLeft)
        {
            if (other.GetComponent<CubeColor>().IsLeft)
            {
                Destroy(other.gameObject);
                onCubeDestroy();
                left++;
                onValueChange(left,isLeft);
            }
            else
                dragRigidbody.selectedRigidbody = null;   
        }

        if (!isLeft)
        {
            if (!other.GetComponent<CubeColor>().IsLeft)
            {
                Destroy(other.gameObject);
                onCubeDestroy();
                right++;
                onValueChange(right,isLeft);                
            }
            else
                dragRigidbody.selectedRigidbody = null;                    
        }
    }
}
