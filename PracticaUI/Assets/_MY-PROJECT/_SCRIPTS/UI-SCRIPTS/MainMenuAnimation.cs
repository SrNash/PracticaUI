using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuAnimation : MonoBehaviour
{

    [SerializeField]
    GameObject container, logoImg, titleGImg, titleImg, subtitleImg, buttonsGrid, bloodImg, containerViewImg;
    [SerializeField]
    float horizontal, vertical, rot;
    [SerializeField]
    float smoothTimer1, smoothTimer2;

    // Start is called before the first frame update
    void OnEnable()
    {
        ContainerView();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ContainerView()
    {
        LeanTween.alphaCanvas(containerViewImg.GetComponent<CanvasGroup>(), 1f, 0f).setOnComplete(Introduction);
    }
    void Introduction()
    {
        //LeanTween.move(container, firstDir, 1.25f).setOnComplete();
        LeanTween.moveLocalX(container, horizontal, 1.25f).setOnComplete(FadeIn);
    }
    void FadeIn()
    {
        LeanTween.alphaCanvas(logoImg.GetComponent<CanvasGroup>(), 1f, 2.5f);
        LeanTween.alphaCanvas(titleGImg.GetComponent<CanvasGroup>(), 1f, 3f);
        LeanTween.alphaCanvas(titleImg.GetComponent<CanvasGroup>(), 1f, 3.25f);
        LeanTween.alphaCanvas(subtitleImg.GetComponent<CanvasGroup>(), 1f, 3.5f);
        LeanTween.alphaCanvas(buttonsGrid.GetComponent<CanvasGroup>(), 1f, 3.75f);
        LeanTween.alphaCanvas(bloodImg.GetComponent<CanvasGroup>(), 1f, 4f).setOnComplete(LogoRotation);
    }
    void LogoRotation()
    {
        LeanTween.rotateY(logoImg, rot, smoothTimer1).setLoopPingPong(-1);
    }
    void ChangeColor()
    {

    }
}
