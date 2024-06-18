using UnityEngine;

public class MenuState : MonoBehaviour
{
    [SerializeField] private GameObject choicePanel;
    [SerializeField] private GameObject settingPanel;
    [SerializeField] private GameObject audioSettingPanel;
    [SerializeField] private GameObject controlSettingPanel;
    [SerializeField] private GameObject menuButton;
    public void PlayPanel()
    {
        choicePanel.SetActive(!choicePanel.activeInHierarchy);
    }

    public void SettingsPanel()
    {
        settingPanel.SetActive(!settingPanel.activeInHierarchy);
    }

    public void AudioSettingsPanel()
    {
        audioSettingPanel.SetActive(!audioSettingPanel.activeInHierarchy);
    }

    public void ControlSettingsPanel()
    {
        controlSettingPanel.SetActive(!controlSettingPanel.activeInHierarchy);
    }

    public void MenuButoon()
    {
        menuButton.SetActive(!menuButton.activeInHierarchy);
    }

    public void BackToMenu()
    {
        choicePanel.SetActive(false);
        settingPanel.SetActive(false);
    }

    public void BackToSetting()
    {
        audioSettingPanel.SetActive(false);
        controlSettingPanel.SetActive(false);
        settingPanel.SetActive(true);
    }

}
