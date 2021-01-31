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

        if (GameObject.FindGameObjectsWithTag("AkME").Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (flowchrt == null)
        {
            if(GameObject.Find("NPC")!=null)
            flowchrt = GameObject.Find("A_interaction");
            else
            flowchrt = GameObject.Find("Menu");
        }

        currentMusic = flowchrt.GetComponent<Flowchart>().GetIntegerVariable("currentMusic");
    }

    public void PlayMusic()
    {

        
        MusicEvents[currentMusic].Post(gameObject);
    }
}
