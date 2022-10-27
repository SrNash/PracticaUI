using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField]
    float horizontal, vertical;
    [SerializeField]
    GameObject container, flagsGrid, titleOptions, buttonLanguage, buttonMusic, buttonBack;
    [SerializeField]
    bool openLanguage = false;

    private void Start()
    {
        LeanTween.alphaCanvas(flagsGrid.GetComponent<CanvasGroup>(), 0f, 0f);
    }

    void OnEnable()
    {
        //Cuando esté habilitado comenzaremos la animación
        OptionsAnimation();
    }
     public void OptionsAnimation()
    {
        //Animamos el contenedor del menu de opciones
        LeanTween.moveLocalY(container, vertical, 5f);
        LeanTween.alphaCanvas(buttonBack.GetComponent<CanvasGroup>(), 1f, 1.5f);
    }

    public void LanguageOptionAnimationOpen()
    {
        //Si ya hemos clickeado el Botón de Idiomas o no
        if (openLanguage)
        {
            LeanTween.moveLocalY(buttonMusic, 83.80101f, 2f);
            LeanTween.alphaCanvas(flagsGrid.GetComponent<CanvasGroup>(), 0f, .35f);
            openLanguage = false;
        }//En caso de que no lo hallamos pulsado con anterioridad
        else if (!openLanguage)
        {
            LeanTween.moveLocalY(buttonMusic, 47f, .75f);
            LeanTween.alphaCanvas(flagsGrid.GetComponent<CanvasGroup>(), 1f, 4f);
            openLanguage = true;
        }
    }


    void ClickBack()
    {
        //Buton para regresar a la pantalla de Menu
    }
}
