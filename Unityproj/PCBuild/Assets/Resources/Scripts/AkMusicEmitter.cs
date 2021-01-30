using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class AkMusicEmitter : MonoBehaviour
{
    public AK.Wwise.Event[] MusicEvents;
    private int characterArrayPos;
    public int currentMusic;
    public GameObject flowchrt;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        if (flowchrt == null)
        {
            flowchrt = GameObject.Find("A_interaction");
        }
        currentMusic = flowchrt.GetComponent<Flowchart>().GetIntegerVariable("currentMusic");
    }

    public void PlayMusic()
    {
        MusicEvents[currentMusic].Post(gameObject);
    }
}
