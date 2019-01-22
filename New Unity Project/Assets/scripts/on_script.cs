using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class on_script : MonoBehaviour

{
  
    public Text text_kanal;

    public Text text_zone;
    public Text centr_top;
    public Text centr;
    public Plane plane1;
    public GameObject plane;
    private int i = 0;
  
    void Start()
    {
        
    }

    void Update()
    {
  
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && i ==0)
        {
            gameObject.GetComponent<Animation>().Play("on");
            text_kanal.text = "контакт";
            text_zone.text = "зони";
            centr.text = "channel 1";
            centr_top.text = "ch 1";
            i = 1;
        }
        else if (Input.GetMouseButtonDown(0) && i == 1)
        {
            gameObject.GetComponent<Animation>().Play("on");
            text_kanal.text = "";
            text_zone.text = "";
            centr.text = "";
            centr_top.text = "";
            i = 0;
        }
    }

   
 
    
}
