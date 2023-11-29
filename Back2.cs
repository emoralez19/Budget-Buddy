using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back2 : MonoBehaviour
{
    public void BackToLvl2()
    {
        SceneManager.LoadSceneAsync(6);
    }
}

