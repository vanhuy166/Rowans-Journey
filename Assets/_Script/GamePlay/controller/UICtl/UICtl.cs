using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtl : MonoBehaviour
{
    public viewUI viewui;
    private void Awake()
    {
        viewui = GameObject.Find("UI").GetComponent<viewUI>();
    }
    public void congdiem()
    {
        viewui.mark++;
        viewui.setScore();
    }
    public void congSkill()
    {
        viewui.setSkill();
    }
    public void checkBestscore()
    {

        if(viewui.mark> PlayerPrefs.GetInt("bestscore"))
        {
            PlayerPrefs.SetInt("bestscore", viewui.mark);
        }
    }
}
