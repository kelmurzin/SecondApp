using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Показ панели проигрыша.
/// </summary>
public class GameOver : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject panelGameObject;

    private void Start() => gameManager.onBoolChange += ShowPanelGameObject;
   
    private void OnDestroy() => gameManager.onBoolChange -= ShowPanelGameObject;
   
    private void ShowPanelGameObject(bool isActive)
    {
        if (isActive)
            panelGameObject.SetActive(false);
        else
            panelGameObject.SetActive(true);
    }

}
