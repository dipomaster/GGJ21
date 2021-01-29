using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkSoundEmitterScript : MonoBehaviour
{
    public AK.Wwise.Event StartEvent;
    public AK.Wwise.Event StopEvent;
    public AK.Wwise.Switch CharacterSelect;
    public AK.Wwise.Switch EmotionSelect;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        SelectCharacter();
        SelectEmotion();
        IsTalking();
    }

    private void SelectEmotion()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EmotionSelect.SetValue(gameObject);
        }
    }

    private void SelectCharacter()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CharacterSelect.SetValue(gameObject);
        }
    }

    private void IsTalking()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartEvent.Post(gameObject);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            StopEvent.Post(gameObject);
        }
    }
}
