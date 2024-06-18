using System;
using UnityEngine;

public class DistanceCounter : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameUI gameUI;

    private float startPos;
    private float counter;

    private void Awake()
    {
        SetPlayerStartPosition();
        gameUI.SetBestDistance();
    }

    private void SetPlayerStartPosition()
    {
        startPos = player.transform.position.x;
    }

    private void Update()
    {
        counter = DistanceFromStart();
        gameUI.ChangeCurrentDistance(counter);
        IfGameOver();
    }

    private float DistanceFromStart()
    {
        return MathF.Round(player.transform.position.x - startPos);
    }

    private void IfGameOver()
    {
        if (GameOver.gameOver)
        {
            gameUI.UpdateBestDistanceInMenu(counter);
            gameUI.GameOverText(counter);
            gameObject.SetActive(false);
            gameUI.HideBestDistanceText();
        }
    }
}
