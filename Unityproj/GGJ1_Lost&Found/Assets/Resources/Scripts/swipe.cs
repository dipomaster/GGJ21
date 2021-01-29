using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class swipe : MonoBehaviour
{

    [SerializeField] private GameObject items_description;
    public Color[] colors;
    public GameObject scrollbar;
    private float scroll_pos = 0;
    float[] pos;
    private bool runIt = false;
    private float time;
    private Button takeTheBtn;
    public Button PrevButton, NextButton;
    int btnNumber;
    private int currentItem=1;
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        pos = new float[transform.childCount];
        distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i] = distance * i;
        }
        //OnInput(distance);
    }
    private void Awake()
    {
        //SelectMenuItem(currentItem);
    }

    // Update is called once per frame
    void Update()
    {



        //if (runIt)
        //{
        //    GecisiDuzenle(distance, pos, takeTheBtn);
        //    time += Time.deltaTime;

        //    if (time > 1f)
        //    {
        //        time = 0;
        //        runIt = false;
        //    }
        //}



        //if (Input.GetMouseButton(0))
        //{

        //    if (scrollbar.GetComponent<Scrollbar>().value != scroll_pos)
        //    {
        //        scroll_pos = scrollbar.GetComponent<Scrollbar>().value;


        //    }

        //}
        //else
        //{
        //    for (int i = 0; i < pos.Length; i++)
        //    {
        //        if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
        //        {
        //           // scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.1f);
        //            SelectMenuItem(i);
        //        }
        //    }


        //}
        //Debug.LogAssertion("scroll position "+ scroll_pos);
        
       // OnInput();

    }


    private void  OnInput( )
    {
        



        for (int i = 0; i < pos.Length; i++)
        {
            //PrevButton.interactable = (i != 0);
            //NextButton.interactable = (i != transform.childCount - 1);
            if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
            {
                // Debug.LogWarning("Current Selected Level" + i);
                //currentItem = i;
                print("pos[i]= "+pos[i]);
                print("[i]= " + i);
                // SelectMenuItem(i);
                transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1f, 1f), 0.1f);
                items_description.GetComponentInChildren<TextMeshProUGUI>().text = transform.GetChild(i).gameObject.GetComponent<TextMeshPro>().text;
            }
            else
            {
                transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(0.8f, 0.8f), 0.1f);
                
            }
        }

    }
    //private void GecisiDuzenle(float distance, float[] pos, Button btn)
    //{
    //    // btnSayi = System.Int32.Parse(btn.transform.name);

    //    for (int i = 0; i < pos.Length; i++)
    //    {
    //        if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
    //        {
    //            scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[btnNumber], 1f * Time.deltaTime);

    //        }
    //    }

    //    for (int i = 0; i < btn.transform.parent.transform.childCount; i++)
    //    {
    //        btn.transform.name = ".";
    //    }

    //}


    private void SelectMenuItem(int _index)
    {

        //float distance = 1f / (pos.Length - 1f);
        PrevButton.interactable = (_index != 0);
        NextButton.interactable = (_index != transform.childCount - 1);
        


        if (scroll_pos < pos[_index] + (distance / 2) && scroll_pos > pos[_index] - (distance / 2))
        {
            scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[_index], 0.1f);
            //SelectMenuItem(i);
        }

        OnInput();
        //OnInput(_index * 1f / (transform.childCount - 1f));

    }


    public void ChangeItem(int _change)
    {
        
        currentItem += _change ;
        //print(currentItem);
        scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
        SelectMenuItem(currentItem);


    }


    //public void WhichBtnClicked(Button btn)
    //{
    //    btn.transform.name = "clicked";
    //    for (int i = 0; i < btn.transform.parent.transform.childCount; i++)
    //    {
    //        if (btn.transform.parent.transform.GetChild(i).transform.name == "clicked")
    //        {
    //            btnNumber = i;
    //            takeTheBtn = btn;
    //            time = 0;
    //            scroll_pos = (pos[btnNumber]);
    //            runIt = true;
    //        }
    //    }


    //}

}