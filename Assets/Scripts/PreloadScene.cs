using UnityEngine;

public class PreloadScene : MonoBehaviour
{
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        GameOver.gameOver = false;
        Time.timeScale = 1f;
    }
}
