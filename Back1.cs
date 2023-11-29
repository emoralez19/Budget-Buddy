using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back1 : MonoBehaviour
{
    public void BackToStart()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
