using System.Collections;using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider difficultySlider;
    [SerializeField] float defaultVolume = 0.8f;
    [SerializeField] int defaultDifficulty = 0;

    // Use this for initialization
    void Start () {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
        difficultySlider.value = PlayerPrefsController.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update ()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer != null)
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else
            Debug.LogWarning("No music player, did you start from other location that splash screen?");
	}

    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        PlayerPrefsController.SetDifficulty((int)difficultySlider.value);
        FindObjectOfType<LevelLoader>().BackToMainMenu();
    }

    public void SetDefaults()
    {
        volumeSlider.value = defaultVolume;
        difficultySlider.value = defaultDifficulty;
    }
}
