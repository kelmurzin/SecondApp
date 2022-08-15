using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Отвечает за количесвто кубов.
/// </summary>
public class QuantityCubs : MonoBehaviour
{
    public int CountCube => countCube;

    [SerializeField] private int countCube;
    [SerializeField] private GameManager gameManager;
    
    private void Start() => WallCheck.onCubeDestroy += MinusCount;
    
    private void OnDestroy() => WallCheck.onCubeDestroy -= MinusCount;
    
    private void MinusCount()
    {
        countCube--;
        if (countCube <= 0)
            gameManager.ChangeGameActive(false);        
    }

}
