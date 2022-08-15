using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Создает кубы.
/// </summary>
public class SpawnCube : MonoBehaviour
{

    [SerializeField] private CubeColor cube;
    [SerializeField] private QuantityCubs quantityCubs;
    private int number;
    
    private void Start()
    {
        number = quantityCubs.CountCube;
        StartCoroutine(Spawn());        
    }

    IEnumerator Spawn()
    {
        
        if (number > 0)
        {
            
            for (int i = 0; i < number; i++)
            {
                Instantiate(cube, transform.position, Quaternion.identity);
                yield return new WaitForSeconds(1f);
            }
        }
    }
    

}
