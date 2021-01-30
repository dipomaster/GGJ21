using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class AkSoundEmitterScript : MonoBehaviour
{
    public AK.Wwise.Event StartTalking;
    public AK.Wwise.Event StopTalking;
    public AK.Wwise.Switch SelectCharacter;
    public AK.Wwise.Switch[] SelectEmotion;
    public GameObject flowchrt;
    public int emotion_state=0;

    private void Update()
    {
        emotion_state = flowchrt.GetComponent<Flowchart>().GetIntegerVariable("emotion_state");
        ManageEmotion();

        
    }

    private void Start()
    {
        SelectCharacter.SetValue(gameObject);
    }

    private void ManageEmotion()
    
        {
            SelectEmotion[emotion_state].SetValue(gameObject);
        
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
