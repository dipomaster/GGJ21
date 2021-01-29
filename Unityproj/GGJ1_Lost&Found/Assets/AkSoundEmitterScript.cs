using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkSoundEmitterScript : MonoBehaviour
{
    public AK.Wwise.Event StartEvent;
    public AK.Wwise.Event StopEvent;

    // Start is called before the first frame update
    void Start()
    {
        StartEvent.Post(gameObject);
    }
}
