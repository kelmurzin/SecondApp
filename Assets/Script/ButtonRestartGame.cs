using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Кнопка для рестарта сцены.
/// </summary>
[RequireComponent(typeof(Button))]
public class ButtonRestartGame : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(RestartGame);
    }

    private void OnDestroy() => button.onClick.RemoveListener(RestartGame);
    
    private void RestartGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

}
