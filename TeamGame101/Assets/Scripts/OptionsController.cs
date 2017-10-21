using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OptionsController : MonoBehaviour {
    public Slider volume;
    public Slider difficulty;
    public LevelManager levelManager;

    private musicmanager musicManager;
	// Use this for initialization
	void Start () {
        musicManager = GameObject.FindObjectOfType<musicmanager>();
        volume.value = player_prefManager.GetMasterVolume();
        difficulty.value = player_prefManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update () {
        musicManager.ChangeVolume(volume.value);
	}
    public void SaveAndExit()
    {
        player_prefManager.SetDifficulty(difficulty.value);
        player_prefManager.SetMasterVolume(volume.value);
        Application.LoadLevel("Start Menu");
    }
    public void setDefaults()
    {
        volume.value = 0.5f;
        difficulty.value = 3f;

    }
}
