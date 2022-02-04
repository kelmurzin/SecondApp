using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    [SerializeField] private GameObject cubePref;
    [SerializeField] private int number;
        
    private void Start()
    {
        StartCoroutine(Spawn());
        
    }

    IEnumerator Spawn()
    {
        
        if (number > 0)
        {
            
            for (int i = 0; i < number; i++)
            {
                Instantiate(cubePref,transform.position, Quaternion.identity);                
                yield return new WaitForSeconds(1f);
            }
        }
    }
    

}
