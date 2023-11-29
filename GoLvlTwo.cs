using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoLvlTwo : MonoBehaviour
{
    public void GoToSecondLvl()
    {
        SceneManager.LoadSceneAsync(6);
    }
}
