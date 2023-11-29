using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back3 : MonoBehaviour
{
    public void BackToLvl3()
    {
        SceneManager.LoadSceneAsync(9);
    }
}
