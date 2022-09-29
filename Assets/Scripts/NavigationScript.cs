using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoginButton()
    {
        SceneManager.LoadScene(SceneConstants.HomeScene);
    }
    public void CancelButton()
    {
        SceneManager.LoadScene(SceneConstants.LoginScene);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(SceneConstants.GameScene);
    }
}
