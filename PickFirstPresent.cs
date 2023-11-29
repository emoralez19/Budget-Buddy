using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickFirstPresent : MonoBehaviour
{
    public void CouponSelect()
    {
        SceneManager.LoadSceneAsync(11);
    }
}
