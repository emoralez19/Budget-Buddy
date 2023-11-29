using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromCouponOne : MonoBehaviour
{
    public void StartLevelThree()
    {
        SceneManager.LoadSceneAsync(14);
    }
}
