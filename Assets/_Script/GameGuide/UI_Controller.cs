using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    private int indexPanel;
    public GameObject panel_1;
    public GameObject panel_2;
    public GameObject panel_3;
    
    public void displayPanel(int index)
    {
        if(index == 1)
        {
            panel_1.SetActive(true);
            panel_2.SetActive(false);
            panel_3.SetActive(false);
        }
        if (index == 2)
        {
            panel_2.SetActive(true);
            panel_1.SetActive(false);
            panel_3.SetActive(false);
        }
        if (index == 3)
        {
            panel_3.SetActive(true);
            panel_2.SetActive(false);
            panel_1.SetActive(false);
        }
    }
    public void openPanel_1()
    {
        displayPanel(1);
    }
    public void openPanel_2()
    {
        displayPanel(2);
    }
    public void openPanel_3()
    {
        displayPanel(3);
    }

    public void loadGame()
    {
        SceneManager.LoadScene(0);
    }
}
