using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickSecondPresent : MonoBehaviour
{
    public void CouponSelect()
    {
        SceneManager.LoadSceneAsync(12);
    }
}
