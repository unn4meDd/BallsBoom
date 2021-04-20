using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    string str = "https://www.youtube.com/";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void YouTube()
    {
        Application.OpenURL(str);
    }

    public void Play()

    {
        SceneManager.LoadScene("Game");
    }
    public void Shop()
    {

    }
    public void Settings()
    {

    }

}
