using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScreenControlManager : MonoBehaviour
{
    [SerializeField]
    GameObject screenGame, screenIntro, player, errorMessage;

    [SerializeField]
    TMP_InputField inputPlayerName;
    [SerializeField]
    TextMeshProUGUI nameText,errorLog;

    [SerializeField]
    Toggle musicCheck;
    [SerializeField]
    AudioSource music;
    [SerializeField]
    Slider musicSlider;

    // Start is called before the first frame update
    void Start()
    {
        screenGame.SetActive(false);
        player.SetActive(false);
        screenIntro.SetActive(true);
        
        //Musica volumen 0
        //music.volume = 0;
    }



    public void StartGame()
    {
        if(string.IsNullOrWhiteSpace(inputPlayerName.text))
        {
            //mostrar error
            errorLog.text = "Introduce un nombre de Player";
        }else
        {
            screenGame.SetActive(true);
            player.SetActive(true);
            screenIntro.SetActive(false);
            nameText.text = inputPlayerName.text;
        }
    }

    public void MusicControl() 
    { 
        if(musicCheck.isOn)
        {
            music.volume = .4f;
            music.Play();
        }
        else 
        {
            music.volume = 0;
            music.Stop();
        }
    }
}
