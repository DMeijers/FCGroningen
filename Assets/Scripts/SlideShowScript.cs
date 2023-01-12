using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideShowScript : MonoBehaviour
{
    public Sprite[] Images;

    public Image leftTopPanel;
    public Image rightTopPanel;
    public Image leftBottomPanel;
    public Image rightBottomPanel;

    public int imageNumber = 0;
    

    void Start(){
        changeImages();
    }

    public void changeImages(){
        leftTopPanel.GetComponent<Image>().sprite = Images[imageNumber];
        rightTopPanel.GetComponent<Image>().sprite = Images[imageNumber + 1];
        leftBottomPanel.GetComponent<Image>().sprite = Images[imageNumber + 2];
        rightBottomPanel.GetComponent<Image>().sprite = Images[imageNumber + 3];
    }

    public void NextPage(){
        imageNumber += 4;
        
        if (Images.Length > imageNumber)
        {
            changeImages();
        }
        else{
            int difference = Images.Length - imageNumber;
            
            switch(difference)
            {
                case 1:
                    leftTopPanel.GetComponent<Image>().sprite = Images[imageNumber];
                    break;

                case 2:
                    leftTopPanel.GetComponent<Image>().sprite = Images[imageNumber];
                    rightTopPanel.GetComponent<Image>().sprite = Images[imageNumber + 1];
                    break;

                case 3:
                    leftTopPanel.GetComponent<Image>().sprite = Images[imageNumber];
                    rightTopPanel.GetComponent<Image>().sprite = Images[imageNumber + 1];
                    leftBottomPanel.GetComponent<Image>().sprite = Images[imageNumber + 2];
                    break;

                default:
                    Debug.Log("No changes can be made");
                    break;
            }
        }

    }

    public void PreviousPage(){
        if (imageNumber != 0){
            imageNumber -= 4;
            changeImages();
        }
    }
}
