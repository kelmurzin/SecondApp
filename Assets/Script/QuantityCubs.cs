using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuantityCubs : MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    private int _number;

    public void PlusNum() => _number++;

    public void MinusNum()
    {
        if (_number > 0)
            _number--;
        if(_number == 0)
            GameOver();
    }

    private void GameOver() => _panel.SetActive(true);
}
