using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    public Slider musicSlider;
    public Slider effectsSlider;
    public Dropdown difficultyDropdown;
    public Toggle noMercyToggle;
    public Slider textSpeedSlider;

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        musicSlider.value = PlayerPrefsManager.GetMasterMusic();
    }

    public void SaveOptions()
    {
        PlayerPrefsManager.SetMasterMusic(musicSlider.value);
        PlayerPrefsManager.SetMasterEffects(effectsSlider.value);
        PlayerPrefsManager.SetDifficulty(difficultyDropdown.value);
        PlayerPrefsManager.SetTextSpeed(textSpeedSlider.value);
        int noMercy = 1;
        if (noMercyToggle.isOn) { noMercy = 0; }
        PlayerPrefsManager.SetNoMercy(noMercy);

    }

    // Update is called once per frame
    void Update()
    {
        musicManager.SetMusicLevel(musicSlider.value);
    }
}
