using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public delegate void EventGamedelegated();
    public EventGamedelegated StartGameDelegate;
    public EventGamedelegated EndGameDelegate;
    public EventGamedelegated PauseGameDelegate;
    public EventGamedelegated ResumeGameDelegate;
    public EventGamedelegated RebootGameDelegate;

    public void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void Startgame()
    {
        Time.timeScale = 1f;
        StartGameDelegate?.Invoke();
    }

    public void Pausegame()
    {
        Time.timeScale = 0;
        PauseGameDelegate?.Invoke();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        ResumeGameDelegate?.Invoke();
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        EndGameDelegate?.Invoke();
    }

    public void Reboot()
    {
        SceneManager.LoadScene("Samplescene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
