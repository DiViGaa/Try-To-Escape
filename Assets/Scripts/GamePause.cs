using UnityEngine;
using UnityEngine.Audio;

public class GamePause : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup MasterGroup;
    [SerializeField] private GameUI _gameUI;
    
    private bool inPause;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !GameOver.gameOver)
        {
            if (inPause)
            {
                PauseResume(false, CursorLockMode.Locked, false, 1f, -30f);
            }
            else
            {
                PauseResume(true, CursorLockMode.Confined, true, 0f, -80);
            }
        }
    }

    private void PauseResume(bool cursorVisible, CursorLockMode cursorMode, bool panelVisibility, float timeScale, float volume)
    {
        CursorState(cursorVisible, cursorMode);
        _gameUI.PausePanel(panelVisibility);
        Time.timeScale = timeScale;
        MasterGroup.audioMixer.SetFloat(MasterGroup.ToString(), volume);
    }

    private static void CursorState(bool cursorVisible, CursorLockMode cursorMode)
    {
        Cursor.visible = cursorVisible;
        Cursor.lockState = cursorMode;
    }

    public void RusumeWithButton()
    {
        PauseResume(false, CursorLockMode.Locked, false, 1f, -30f);
    }
}
