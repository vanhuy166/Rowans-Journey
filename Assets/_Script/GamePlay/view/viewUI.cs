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
    public Text winGameScore;
    public Text TitleGame;
    public Text bestscore;
    public Text bestscore1;
    public GameObject pauseGame;
    public GameObject winGame;
    public int mark=0;

    public void Awake()
    {
        Color newcolor = isSkill.color;
        newcolor.a = 1;
        isSkill.color = newcolor;
    }
    public void setScore()
    {
        score.text = ""+ mark;
    }
    public void setColor()
    {
        if (skill.value >= 1)
        {
            Color newcolor = isSkill.color;
            newcolor.a = 1;
            isSkill.color = newcolor;
        }
        else
        {
            Color newcolor = isSkill.color;
            newcolor.a = 0;
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
    public void setWinGameScore()
    {
        winGameScore.text = "" + mark;
    }
    public void setBestcore()
    {
        bestscore.text = "best : "+ PlayerPrefs.GetInt("bestscore");
    }
    public void setBestcoreWin()
    {
        bestscore1.text = "best : " + PlayerPrefs.GetInt("bestscore");
    }
}
