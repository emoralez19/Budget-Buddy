using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pass2 : MonoBehaviour
{
    public void GoMiniGameRules()
    {
        SceneManager.LoadSceneAsync(9);
    }
}
