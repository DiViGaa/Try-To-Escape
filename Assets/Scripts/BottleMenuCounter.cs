using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottleMenuCounter : MonoBehaviour
{
    private Text bottleCounter;

    private void Awake()
    {
        bottleCounter = GetComponent<Text>();
        bottleCounter.text = PlayerPrefs.GetInt("Bottle").ToString();
    }
}
