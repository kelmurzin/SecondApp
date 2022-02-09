using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SpawnCube : MonoBehaviour
{
    public UnityEvent InitCube;

    [SerializeField] private GameObject _cubePref;
    [SerializeField] private int _number;
    
    private void Start()
    {
        StartCoroutine(Spawn());        
    }

    IEnumerator Spawn()
    {
        
        if (_number > 0)
        {
            
            for (int i = 0; i < _number; i++)
            {
                Instantiate(_cubePref,transform.position, Quaternion.identity);
                InitCube?.Invoke();
                yield return new WaitForSeconds(1f);
            }
        }
    }
    

}
