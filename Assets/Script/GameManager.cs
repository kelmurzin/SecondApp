using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/// <summary>
/// Отвечает за активность игры.
/// </summary>
public class GameManager : MonoBehaviour
{
    public event Action<bool> onBoolChange;
    [SerializeField] private bool isActiveGame;

    public void ChangeGameActive(bool active)
    {
        isActiveGame = active;
        onBoolChange(isActiveGame);
    }

}
