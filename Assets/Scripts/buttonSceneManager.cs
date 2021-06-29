using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonSceneManager : MonoBehaviour
{

    public void OnButtonClick()
    {
        SceneManager.LoadScene("PlayNow");
    }
}
