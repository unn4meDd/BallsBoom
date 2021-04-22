using UnityEngine;

public class PlayerLoad : MonoBehaviour
{
    MeshRenderer meshRenderer;
    public int numberColors;
    public Texture blueTexture;
    public Texture orangeTexture;


    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        numberColors = PlayerPrefs.GetInt("Color");
    }

    // Update is called once per frame
    void Update()
    {
        if (numberColors == 1)
        {
            meshRenderer.material.SetTexture("_MainTex", orangeTexture);
        }
        if (numberColors == 2)
        {
            meshRenderer.material.SetTexture("_MainTex", blueTexture);
        }
    }
}
