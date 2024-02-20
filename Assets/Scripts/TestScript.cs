using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestScript : MonoBehaviour
{
    //public GameObject cube;
    //public int x, y, z;
    public GameObject scene_1,scene_2,scene_3;
    public GameObject endingScene;
    public GameObject stats;
    public TextMeshProUGUI healthValue, currencyValue;
    public int healthPoints, currencyPoints;

    // Start is called before the first frame update
    void Start()
    {
        // cube.transform.localScale = new Vector3(x, y, z);
        scene_1.SetActive(true);
        stats.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //for scale
        //cube.transform.localScale = new Vector3(x, y, z);
        //for position
        //cube.transform.localPosition = new Vector3(x, y, z);

        healthValue.text = healthPoints.ToString();
        currencyValue.text = currencyPoints.ToString();

        if(currencyPoints <= 0)
        {
            endingScene.SetActive(true);
        }
    }
    
    public void StartButton()
    {
        scene_1.SetActive(false);
        scene_2.SetActive(true);
        stats.SetActive(true);
    }

    public void SecondFloorButton()
    {
        scene_2.SetActive(false);
        scene_3.SetActive(true);
    }
    public void ShawarmaButton() 
    {
        healthPoints += 5;
        currencyPoints -= 75;
    }
    
    
}
