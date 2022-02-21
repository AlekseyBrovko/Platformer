using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private bool isActivated = false;
    [SerializeField] private GameObject levelCompleteCanvas;

    public void Activate()
    {
        isActivated = true;
    }

    public void FinishLevel()
    {
        if (isActivated)
        {
            gameObject.SetActive(false);
            levelCompleteCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
