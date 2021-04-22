using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShop : MonoBehaviour
{
    MeshRenderer meshRenderer;
    public int numberColors;
    public Texture orangeTexture;
    public Texture blueTexture;
    public GameObject buttonEquipOrange;
    public GameObject buttonEquipBlue;
    public GameObject checkMark1;
    public GameObject checkMark2;

    // Start is called before the first frame update
    void Start()
    {
        numberColors = PlayerPrefs.GetInt("Color");
        meshRenderer = GetComponent<MeshRenderer>();
        buttonEquipOrange.SetActive(false);
        buttonEquipBlue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(numberColors == 1)
        {
            meshRenderer.material.SetTexture("_MainTex", orangeTexture);
            checkMark1.SetActive(true);
            checkMark2.SetActive(false);
        }
        if (numberColors == 2)
        {
            meshRenderer.material.SetTexture("_MainTex", blueTexture);
            checkMark1.SetActive(false);
            checkMark2.SetActive(true);
        }
    }
    public void PlayerOrange()
    {
        meshRenderer.material.SetTexture("_MainTex", orangeTexture);
        buttonEquipOrange.SetActive(true);
        buttonEquipBlue.SetActive(false);

    }
    public void PlayerBlue()
    {
        meshRenderer.material.SetTexture("_MainTex", blueTexture);
        buttonEquipOrange.SetActive(false);
        buttonEquipBlue.SetActive(true);
    }
    public void EquipOrange()
    {
        numberColors = 1;
        PlayerPrefs.SetInt("Color", numberColors);
        buttonEquipOrange.SetActive(false);
        buttonEquipBlue.SetActive(false);
        checkMark1.SetActive(true);
        checkMark2.SetActive(false);
    }
    public void EquipBlue()
    {
        numberColors = 2;
        PlayerPrefs.SetInt("Color", numberColors);
        buttonEquipOrange.SetActive(false);
        buttonEquipBlue.SetActive(false);
        checkMark1.SetActive(false);
        checkMark2.SetActive(true);
    }
}