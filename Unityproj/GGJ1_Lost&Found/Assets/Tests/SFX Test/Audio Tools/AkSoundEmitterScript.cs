using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkSoundEmitterScript : MonoBehaviour
{
    public AK.Wwise.Event StartTalking;
    public AK.Wwise.Event StopTalking;
    public AK.Wwise.Switch SelectCharacter;
    public AK.Wwise.Switch[] SelectEmotion;

    private void Update()
    {
        SelectCharacter.SetValue(gameObject);
        ManageEmotion();
    }

    private void ManageEmotion()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SelectEmotion[0].SetValue(gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            SelectEmotion[1].SetValue(gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            SelectEmotion[2].SetValue(gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            SelectEmotion[3].SetValue(gameObject);
        }
    }

    public void StartSpeech()
    {
        StartTalking.Post(gameObject);
    }

    public void StopSpeech()
    {
        StopTalking.Post(gameObject);
    }
}
