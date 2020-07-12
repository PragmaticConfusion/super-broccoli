using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
    public GameObject startCanvas;
    public GameObject pauseCanvas;
    public GameObject winCanvas;
    // Start is called before the first frame update
    void Start()
    {
        ResetUI();
        startCanvas.gameObject.SetActive(true);
    }

    public void StartGame()
    {
        startCanvas.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseCanvas.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseCanvas.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void WinGame()
    {
        winCanvas.SetActive(true);
        StartCoroutine(EndGame());
    }

    IEnumerator EndGame()
    {
    
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

    }

    public void ResetUI()
    {
        startCanvas.gameObject.SetActive(false);
        pauseCanvas.gameObject.SetActive(false);
        winCanvas.gameObject.SetActive(false);
        Time.timeScale = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }
}
