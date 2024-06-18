using UnityEngine;
using UnityEngine.UI;

public class BestDistanceCounter : MonoBehaviour
{
    private Text bestDistanceCounter;
    void Start()
    {
        bestDistanceCounter = GetComponent<Text>();
        bestDistanceCounter.text = PlayerPrefs.GetFloat("BestDistance").ToString();
    }

}
