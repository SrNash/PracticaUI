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
    [SerializeField]
    GameObject screenOption;

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
        LeanTween.moveLocalX(container, horizontal, 3f).setOnComplete(FadeIn);
    }
    void FadeIn()
    {
        LeanTween.alphaCanvas(logoImg.GetComponent<CanvasGroup>(), 1f, 4.5f);
        LeanTween.alphaCanvas(titleGImg.GetComponent<CanvasGroup>(), 1f, 5f);
        LeanTween.alphaCanvas(titleImg.GetComponent<CanvasGroup>(), 1f, 5.25f);
        LeanTween.alphaCanvas(subtitleImg.GetComponent<CanvasGroup>(), 1f, 5.5f);
        LeanTween.alphaCanvas(buttonsGrid.GetComponent<CanvasGroup>(), 1f, 5.75f);
        LeanTween.alphaCanvas(bloodImg.GetComponent<CanvasGroup>(), 1f, 6f).setOnComplete(LogoRotation);
    }
    void LogoRotation()
    {
        LeanTween.rotateY(logoImg, rot, smoothTimer1).setLoopPingPong(-1);
    }

    void CloseMenu()
    {
        LeanTween.moveLocalX(container, horizontal, 5f).setOnComplete(ScreenOptionsMenu);
        //LeanTween.alphaCanvas(container.GetComponent<CanvasGroup>(), 0f, 1.5f);
    }

    public void ScreenOptionsMenu()
    {
        //LeanTween.moveLocalY(container, 1094f, 5f).setOnComplete(EnabledMenuCanvas);
        LeanTween.alphaCanvas(container.GetComponent<CanvasGroup>(), 0f, 1.5f).setOnComplete(EnabledMenuCanvas);
    }

    void EnabledMenuCanvas()
    {
        screenOption.SetActive(true);
        gameObject.SetActive(false);
    }
    public void DisabledMenuCanvas()
    {
        LeanTween.alphaCanvas(container.GetComponent<CanvasGroup>(), 1f, 1.5f);
        screenOption.SetActive(false);
        gameObject.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
