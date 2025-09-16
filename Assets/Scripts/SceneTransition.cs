using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
=======
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition: MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("RayeLevel01");
        // call for start button
>>>>>>> 7cad43856cfd765f4f3a9258f3bb5da59ac5ae7d
    }
}
