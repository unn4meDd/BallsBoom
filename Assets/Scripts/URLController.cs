using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLController : MonoBehaviour
{
    string channelURL = "https://www.youtube.com/channel/UCqWiwMpbw0zfSXmJlHpjaYA";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Subscribe()
    {
        Application.OpenURL(channelURL);
    }
}
