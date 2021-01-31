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



    void Awake()
    {

        if (GameObject.Find("GM") != null)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        if (flowchrt == null)
        {
            flowchrt = GameObject.Find("A_interaction");
        }
    }

    private void Update()
    {        
        currentMusic = flowchrt.GetComponent<Flowchart>().GetIntegerVariable("currentMusic");
    }

    public void PlayMusic()
    {
        MusicEvents[currentMusic].Post(gameObject);
    }
}
