using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class LevelBtn : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI textLevel;
    [SerializeField] private TextMeshProUGUI textTitleBtn;

    // Start is called before the first frame update
    void Start()
    {  
        textLevel.GetComponent<TextMeshProUGUI>().text = this.name;
    }


     public void OnClickBtnLevel(){
        if(int.Parse(this.name) % 3 == 0){
            Debug.Log(textTitleBtn.GetComponent<TextMeshProUGUI>().text);
        } else {
            Debug.Log("Click: " + this.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
