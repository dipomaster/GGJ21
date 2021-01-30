using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkSoundEmitterScript : MonoBehaviour
{
    public AK.Wwise.Event StartTalking;
    public AK.Wwise.Event StopTalking;
    public AK.Wwise.Switch[] SelectCharacter;
    public AK.Wwise.Switch[] SelectEmotion;

    private void Update()
    {
        ManageCharacter();
        ManageEmotion();
        ManageSpeech();
    }

    private void ManageCharacter()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SelectCharacter[0].SetValue(gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SelectCharacter[1].SetValue(gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SelectCharacter[2].SetValue(gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SelectCharacter[3].SetValue(gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SelectCharacter[4].SetValue(gameObject);
        }
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

    private void ManageSpeech()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartTalking.Post(gameObject);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            StopTalking.Post(gameObject);
        }
    }
}
