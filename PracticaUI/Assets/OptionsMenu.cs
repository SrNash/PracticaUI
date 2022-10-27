using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField]
    float horizontal;
    [SerializeField]
    GameObject flagsGrid, titleOptions, buttonLanguage, container;

    private void OnEnable()
    {
        SelectLanguageOption();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectLanguageOption()
    {
        LeanTween.moveLocalX(container, horizontal, 1.25f);
        //LeanTween.moveLocalX(flagsGrid, horizontal, 1.25f);
        LeanTween.alphaCanvas(container.GetComponent<CanvasGroup>(), 1f, 1.5f);
        flagsGrid.SetActive(true);
        //LeanTween.moveLocalX(titleOptions, horizontal, 1.25f);
        //LeanTween.alphaCanvas(titleOptions.GetComponent<CanvasGroup>(), 1f, 1.5f);
        //LeanTween.moveLocalX(buttonLanguage, horizontal, 1.25f);
        //LeanTween.alphaCanvas(buttonLanguage.GetComponent<CanvasGroup>(), 1f, 1.5f);
    }
}
