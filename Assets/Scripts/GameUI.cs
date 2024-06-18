using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Text gameOverText;
    [SerializeField] private Text bestDistanceText;
    [SerializeField] private Text textCounter;
    [SerializeField] private Text bottleCounter;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject pausePanel;


    public void SetBestDistance()
    {
        bestDistanceText.text = PlayerPrefs.GetFloat("BestDistance").ToString();
    }

    public void ChangeCurrentDistance(float counter)
    {
        textCounter.text = counter.ToString();
    }

    public void UpdateBestDistanceInMenu(float counter)
    {
        if (counter > PlayerPrefs.GetFloat("BestDistance"))
        {
            PlayerPrefs.SetFloat("BestDistance", counter);
        }
    }

    public void GameOverText(float counter)
    {
        gameOverText.text = counter.ToString();
    }

    public void HideBestDistanceText()
    {
        bestDistanceText.gameObject.SetActive(false);
    }

    public void UpdateLocalBottleCounter()
    {
        bottleCounter.text = (int.Parse(bottleCounter.GetComponent<Text>().text) + 1).ToString();
    }

    public void UpdateGlobalBottleCounter()
    {
        var globalCountBottle = PlayerPrefs.GetInt("Bottle");
        PlayerPrefs.SetInt("Bottle", globalCountBottle + int.Parse(bottleCounter.GetComponent<Text>().text));
    }

    public void GameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }

    public void PausePanel(bool panelVisibility)
    {
        pausePanel.SetActive(panelVisibility);
    }

}
