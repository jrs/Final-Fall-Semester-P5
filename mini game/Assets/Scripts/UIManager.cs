using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI coinAmountText;
    public Button replayButton;
    public Button startButton;

    private int _coinAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        replayButton.gameObject.SetActive(false);
        startButton.gameObject.SetActive(true);
        coinAmountText.text = "Coins: " + _coinAmount.ToString();
        coinAmountText.gameObject.SetActive(false);
    }

    public void UpdateCoinCount()
    {
        _coinAmount++;
        coinAmountText.text = "Coins: " + _coinAmount.ToString();
    }

    public void GameOver()
    {
        replayButton.gameObject.SetActive(true);
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGame()
    {
        startButton.gameObject.SetActive(false);
        coinAmountText.gameObject.SetActive(true);
        GameObject.Find("Spawn Manager").GetComponent<SpawnManager>().StartSpawner();
    }
}
