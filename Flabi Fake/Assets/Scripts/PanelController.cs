using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject pausePanel;
    public GameObject gamePanel;
    public GameObject overPanel;

    public void ShowStartPanel()
    {
        startPanel.SetActive(true);
        pausePanel.SetActive(false);
        gamePanel.SetActive(false);
        overPanel.SetActive(false);
    }

    public void ShowEndPanel() 
    {
        startPanel.SetActive(false);
        pausePanel.SetActive(false);
        gamePanel.SetActive(false);
        overPanel.SetActive(true);
    }

    public void ShowGamePanel()
    {
        startPanel.SetActive(false);
        pausePanel.SetActive(false);
        gamePanel.SetActive(true);
        overPanel.SetActive(false);
    }

    public void ShowPausePanel()
    {
        startPanel.SetActive(false);
        pausePanel.SetActive(false);
        gamePanel.SetActive(false);
        overPanel.SetActive(false);
    }
}
