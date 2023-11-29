using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.EventSystems;

public class ChangeScene : MonoBehaviour//, IPointerClickHandler
{
    /*  public void loadScene(string sceneName)
      {
          SceneManager.LoadScene(sceneName);
      } */

    /* public void OnPointerClick(PointerEventData eventData)
     {
         SceneManager.LoadScene("Title Screen");
     }*/

    void OnMouseDown()
    {
        SceneManager.LoadScene("Title Screen");
    }
}
