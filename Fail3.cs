using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fail3 : MonoBehaviour
{
    public void GoBack3()
    {
        SceneManager.LoadSceneAsync(9);
    }
}
