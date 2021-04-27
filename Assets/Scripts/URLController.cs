using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLController : MonoBehaviour
{
    string youtubeChannel = "https://www.youtube.com/channel/UCw732c8mKwIU-tsgF5WacUw";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void YouTubeChannel()
    {
        Application.OpenURL(youtubeChannel);
    }
}
