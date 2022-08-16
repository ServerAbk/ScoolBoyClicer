using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    NewBehaviourScript NewBehaviourScript = new NewBehaviourScript();
    
    public string Name;
    public int Manny;
    public int ProgreS;
    public Text ClickTextManny;
    public Text ClicName;
    public Text ClickTextProgres;

    void Start()
    {
        ProgreS = NewBehaviourScript.progres;
        

    }


    void Update()
    {
        
        ClickTextManny.text = Manny.ToString();
        Manny = PlayerPrefs.GetInt("manny");
        ProgreS = PlayerPrefs.GetInt("progres");
        ClickTextProgres.text = ProgreS.ToString();
    }

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Shop()
    {
        SceneManager.LoadScene(3);
    }
    public void Progress()
    {
        SceneManager.LoadScene(2);
    }
    public void Menu3()
    {
        SceneManager.LoadScene(0);
    }
    public void Menu2()
    {
        SceneManager.LoadScene(0);
    }
    public void ChangeName()
    {
        if (Manny <= 1000)
        {
            GetComponent<Button>().interactable = false;
        }
        if (Manny >= 1000)
        {
            SceneManager.LoadScene(4);
        }
    }
    
    public void CheckName()
    {
        if (Manny <= 1000)
        {
            GetComponent<Button>().interactable = false;
        }
        Name = ClicName.text;
        if (Name.Length <= 8 && Name.Length != 0)
        {
            PlayerPrefs.SetString("name", Name);
            Manny -= 1000;
            PlayerPrefs.SetInt("manny", Manny);
        }
       
    }
    public void MMM()
    {
        SceneManager.LoadScene(0);
    }
    public void Progres()
    {
        if (ProgreS < 1000)
        {
            GetComponent<Button>().interactable = false;
        }
        if (ProgreS >= 1000)
        {
            Manny += 500;
            PlayerPrefs.SetInt("manny", Manny);
            ProgreS -= 1000;
            PlayerPrefs.SetInt("progres", ProgreS);
        }
    }


}

