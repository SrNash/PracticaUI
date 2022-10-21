using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject mainMenu, containerImg, logoImg, logoImgChild, gImg, titleImg, subtitleImg;
    [SerializeField]
    float horizontal, vertical, smoothTimer;
    [SerializeField]
    Vector2 vectorDir;

    // Start is called before the first frame update
    void Start()
    {
        //LeanTween.moveLocalY(containerImg, vertical, smoothTimer).setEaseOutBounce();
        //LeanTween.moveLocal(logoImg, vectorDir, smoothTimer);

        FadeIn();
    }

    void FadeIn()
    {
        LeanTween.alphaCanvas(logoImg.GetComponent<CanvasGroup>(), 1f, smoothTimer);
        LeanTween.alphaCanvas(logoImgChild.GetComponent<CanvasGroup>(), 1f, smoothTimer).setOnComplete(TitleAnimation);
    }
    void TitleAnimation()
    {
        LeanTween.alphaCanvas(gImg.GetComponent<CanvasGroup>(), 1f, smoothTimer);
        LeanTween.alphaCanvas(titleImg.GetComponent<CanvasGroup>(), 1f, smoothTimer + 1f);
        LeanTween.alphaCanvas(subtitleImg.GetComponent<CanvasGroup>(), 1f, smoothTimer + 1.5f).setOnComplete(BeatWave);
    }
    void BeatWave()
    {
        LeanTween.scale(containerImg, new Vector3(.125f, .125f, 0f), .75f).setOnComplete(Enabled);
    }

    void Enabled()
    {
        mainMenu.GetComponent<MainMenuAnimation>().enabled = true;
        gameObject.SetActive(false);
    }
}
