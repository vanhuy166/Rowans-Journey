using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class viewUI : MonoBehaviour
{
    public Slider skill;
    public Text score;
    public Image isSkill;
    public GameObject gameover;
    public Text gameoverscore;
    public Text bestscore;
    public GameObject pauseGame;
    public int mark=0;
    public void setScore()
    {
        score.text = ""+ mark;
    }
    public void setColor()
    {
        if (skill.value >= 1)
        {
            Color newcolor = isSkill.color;
            newcolor.a = 255.0f;
            isSkill.color = newcolor;
        }
        else
        {
            Color newcolor = isSkill.color;
            newcolor.a = 0.0f;
            isSkill.color = newcolor;
        }
    }
    public void setSkill()
    {
        score.fontSize = 70;
        skill.value += 0.1f;
        setColor();
        StartCoroutine("delay");
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.2f);
        score.fontSize = 50;
    }
    public void setGameoverscore()
    {
        gameoverscore.text = "" + mark;
    }
    public void setBestcore()
    {
        bestscore.text = "best : "+ PlayerPrefs.GetInt("bestscore");
    }
}
