using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChangeLanguage : MonoBehaviour
{
    [SerializeField]
    int currentLang;
    [SerializeField]
    int TOTAL_LANGUAGES;

    /*private void Start()
    {
        SelectCurrentLang();
    }*/
    private void Awake()
    {
        //Array con los diferentes idiomas que tiene el juego configurado
        //LocalizationSetting.AvailableLocales.Locales
        //Idiomas = {Español, Inglés, Francés, Italiano, Alemám,...}

        //El idioma que se está utilizando
        //LocalizationSetting.SelectedLocale

        int randomLang = Random.Range(0, 3);   //Seleccionamos un idioma aleatorio

        Debug.Log(randomLang);

        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[randomLang];
        currentLang = randomLang;
    }

    public void NextLanguage()
    {
        currentLang += 1;
        if (currentLang >= LocalizationSettings.AvailableLocales.Locales.Count)
        {
            currentLang = 0;
        }
        
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[currentLang];

        Debug.Log(currentLang);
    }
    public void PreviousLanguage()
    {
        currentLang -= 1;

        if (currentLang < 0)
        {
            currentLang = LocalizationSettings.AvailableLocales.Locales.Count - 1;
        }
        
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[currentLang];

        Debug.Log(currentLang);
    }

    void SelectCurrentLang()
    {
        UnityEngine.Localization.Locale searcher = LocalizationSettings.AvailableLocales.Locales[currentLang];

        while (searcher != LocalizationSettings.SelectedLocale && currentLang < LocalizationSettings.AvailableLocales.Locales.Count)
        {
            currentLang++;
            searcher = LocalizationSettings.AvailableLocales.Locales[currentLang];
        }
    }

    public void SpanishSelect()
    {
        currentLang = 0;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[currentLang];
    }
    public void EnglishSelect()
    {
        currentLang = 1;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[currentLang];
    }
    public void FrenchSelect()
    {
        currentLang = 2;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[currentLang];
    }
    public void GermanSelect()
    {
        currentLang = 3;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[currentLang];
    }
    public void ItalySelect()
    {
        currentLang = LocalizationSettings.AvailableLocales.Locales.Count - 1;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[currentLang];
    }
}