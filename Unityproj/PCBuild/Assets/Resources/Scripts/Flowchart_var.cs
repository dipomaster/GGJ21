using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
//this script allows flow flowchart to pass a variable's value
public class Flowchart_var : MonoBehaviour
{

    public GameObject PrevFlowchart;
   // public GameObject NextFlowchart;
    int karmaValue;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Flowchart>().SetIntegerVariable("karma", PrevFlowchart.GetComponent<Flowchart>().GetIntegerVariable("karma") );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
