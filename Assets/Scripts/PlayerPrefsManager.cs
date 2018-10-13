using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

    const string MASTER_MUSIC_KEY = "master_music";
    const string MASTER_EFFECTS_KEY = "master_effects";
    const string DIFFICULTY_KEY = "difficulty";
    const string TEXT_SPEED_KEY = "text_speed";
    const string NO_MERCY_KEY = "no_mercy";

    public static void SetMasterMusic(float music)
    {
        if (music > 0f && music < 1f)
        {
            PlayerPrefs.SetFloat(MASTER_MUSIC_KEY, music);
        }
        else {
            Debug.LogError("Master music out of range");
        }
    }

    public static float GetMasterMusic()
    {
        return PlayerPrefs.GetFloat(MASTER_MUSIC_KEY);
    }



    public static void SetMasterEffects(float effects)
    {
        if (effects > 0f && effects < 1f)
        {
            PlayerPrefs.SetFloat(MASTER_EFFECTS_KEY, effects);
        }
        else
        {
            Debug.LogError("Effects out of range");
        }
    }

    public static float GetMasterEffects()
    {
        return PlayerPrefs.GetFloat(MASTER_EFFECTS_KEY);
    }



    public static void SetDifficulty(int difficulty) {
        if (difficulty >= 0 && difficulty <= 3)
        {
            PlayerPrefs.SetInt(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Not valid difficulty range");
        }
    }

    public static int GetDifficulty(){
        return PlayerPrefs.GetInt(DIFFICULTY_KEY);
        }


    public static void SetTextSpeed(float textSpeed)
    {
        if (textSpeed > 0f && textSpeed < 1f)
        {
            PlayerPrefs.SetFloat(TEXT_SPEED_KEY, textSpeed);
        }
        else
        {
            Debug.LogError("Text Speed out of range");
        }
    }

    public static float GetTextSpeed()
    {
        return PlayerPrefs.GetFloat(TEXT_SPEED_KEY);
    }


    public static void SetNoMercy(int noMercy)
    {
        if (noMercy == 0 || noMercy == 1)
        {
            PlayerPrefs.SetInt(NO_MERCY_KEY, noMercy);
        }
        else
        {
            Debug.LogError("No Mercy value different than 0 or 1");
        }
    }

    public static int GetNoMercy()
    {
        return PlayerPrefs.GetInt(NO_MERCY_KEY);
    }

}
