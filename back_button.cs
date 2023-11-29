using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_button : MonoBehaviour
{
    public void ReturnToHome()
    {
        SceneManager.LoadSceneAsync(0);
    }
    
}
