using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] Doragon doragon;

    private void PauseGame ()
    {
        Time.timeScale = 0;
        doragon.isMoveable = false;
    }
    private void ResumeGame ()
    {
        Time.timeScale = 1;
        doragon.isMoveable = true;
       
    }

}
