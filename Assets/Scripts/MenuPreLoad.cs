using UnityEngine;

public class MenuPreLoad : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        GameOver.gameOver = false;
        Time.timeScale = 1f;
    }
}
