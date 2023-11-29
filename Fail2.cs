using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fail2 : MonoBehaviour
{
    public void BackTo2()
    {
        SceneManager.LoadSceneAsync(6);
    }
}
