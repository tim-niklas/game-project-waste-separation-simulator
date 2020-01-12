using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyController : MonoBehaviour
{
    public float minusTime = 5;
    public float plusTime = 2;

    public Button easy;
    public Button medium;
    public Button hard;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DiffEasy()
    {
        minusTime = 5;
        easy.GetComponent<Image>().color = Color.grey;
        hard.GetComponent<Image>().color = Color.white;
        medium.GetComponent<Image>().color = Color.white;
    } 
    public void DiffMedium()
    {
        minusTime = 10;
        medium.GetComponent<Image>().color = Color.grey;
        easy.GetComponent<Image>().color = Color.white;
        hard.GetComponent<Image>().color = Color.white;
    }

    public void DiffHard()
    {
        minusTime = 15;
        hard.GetComponent<Image>().color = Color.grey;
        easy.GetComponent<Image>().color = Color.white;
        medium.GetComponent<Image>().color = Color.white;
    }
}
