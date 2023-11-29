using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartFirstLvl : MonoBehaviour
{
    public void GoFirstLvl()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
