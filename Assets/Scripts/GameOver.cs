using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameUI _gameUI;
    
    public static bool gameOver = false;

    public void GameOverCollisionOrFall()
    {
        gameOver = true;
        _gameUI.GameOverPanel();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
