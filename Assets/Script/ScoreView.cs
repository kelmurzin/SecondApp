using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
/// <summary>
/// Отображение очков.
/// </summary>
public class ScoreView : MonoBehaviour
{
    [SerializeField] private TMP_Text textLeft;    
    [SerializeField] private TMP_Text textRight;

    private void Start() => WallCheck.onValueChange += UpdateScoreText;
    
    private void OnDestroy() => WallCheck.onValueChange -= UpdateScoreText;

    private void UpdateScoreText(int score,bool isBool)
    {
        if (isBool)
            textLeft.text = score.ToString();
        else
            textRight.text = score.ToString();
    }
}
