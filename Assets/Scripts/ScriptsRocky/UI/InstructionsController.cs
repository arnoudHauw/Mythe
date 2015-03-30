using UnityEngine;
using System.Collections;

public class InstructionsController : MonoBehaviour {

    public GameObject[] slides;
    public bool isNextArrow;
    public int currentSlide = 0;
    public GameObject nexArrow;
    public GameObject prevArrow;

    public void Click() 
    {
        if (isNextArrow)
        {
            slides[currentSlide].SetActive(false);
            nexArrow.GetComponent<InstructionsController>().currentSlide++;
            prevArrow.GetComponent<InstructionsController>().currentSlide++;
            slides[currentSlide].SetActive(true);
            prevArrow.SetActive(true);
            if (currentSlide == slides.Length - 1)
            {
                nexArrow.SetActive(false);
            }
        }
        else 
        {
            slides[currentSlide].SetActive(false);
            nexArrow.GetComponent<InstructionsController>().currentSlide--;
            prevArrow.GetComponent<InstructionsController>().currentSlide--;
            slides[currentSlide].SetActive(true);
            nexArrow.SetActive(true);
            if (currentSlide == 0)
            {
                prevArrow.SetActive(false);
            }
        }

    }
}
