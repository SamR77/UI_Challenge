using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Text ScoreOutput;

    public float score = 0;

    public GameObject image;
    public bool isImageVisible = false;

    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    public Image backGround;



    // Update is called once per frame
    void Update()
    {
        ScoreOutput.text = score.ToString();

        BackgroundColor();

        backGround.transform.Rotate(new Vector3(0f, 0f, 0.1f));

    }

    public void IncreaseScore()
    {
        score += 10;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void HideShowImage()
    {
        if (isImageVisible == false)
        {
            isImageVisible = true;
            image.SetActive(true);
        }
        else if (isImageVisible == true)
        {
            isImageVisible = false;
            image.SetActive(false);
        }

    }

    void BackgroundColor()
    {
        backGround.GetComponent<Image>().color = new Color(redSlider.value, greenSlider.value, blueSlider.value, 100);





    }
}
