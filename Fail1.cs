using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fail1 : MonoBehaviour
{
    public void GoBackLvl1()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
