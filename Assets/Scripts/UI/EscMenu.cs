using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class EscMenu : MonoBehaviour
{
    [SerializeField] private GameObject escMenu;
    public static bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleEscMenu();
        }

    }
    
    public void ToggleEscMenu()
    {
        if (escMenu.activeSelf)
        {
            escMenu.SetActive(false);
            isPaused = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            escMenu.SetActive(true);
            isPaused = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void ResumeButton()
    {
        escMenu.SetActive(false);
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
