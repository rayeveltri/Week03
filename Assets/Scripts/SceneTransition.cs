using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition: MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("RayeLevel01");
    }
}
