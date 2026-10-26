using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class pausemenu1 : MonoBehaviour
{

    public GameObject wristUI;
    public bool activeWristUI = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DisplayWristUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseButtonPressed(InputAction.CallbackContext context)
    {
        if(context.performed)
            DisplayWristUI();
    }

    public void DisplayWristUI()
    {
        if(activeWristUI)
        {
            wristUI.SetActive(false);
            activeWristUI = false;   
            Time.timeScale = 1;
        }
        else if(!activeWristUI)
        {
            wristUI.SetActive(true);
            activeWristUI = true;
            Time.timeScale = 0;
        }
    }

    public void Resume()
    {
        wristUI.SetActive(false);
        activeWristUI = false;
        Time.timeScale = 1;
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
