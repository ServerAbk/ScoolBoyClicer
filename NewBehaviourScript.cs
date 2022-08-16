using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    

    public int a, b, c, f, manny, progres;
    public double d;
    public string n, v, l, y, t;
    public Text ClickTextProgres;
    public Text ClickTextManny;
    public Text ClickTextA;
    public Text ClickTextB;
    public Text ClickTextC;
    public Text ClickTextD;
    public Text ClickTextN;
    public Text ClickTextF;
    public Text ClickTextV;
    public Text ClickTextL;
    public Text ClickTextY;
    public Text ClickTextT;
   

    void Start()
    {
        a = 100;
        b = 100;
        c = 50;
        f = 60;
        d = 4;
        n = PlayerPrefs.GetString("name");
        manny = PlayerPrefs.GetInt("manny");
        progres = PlayerPrefs.GetInt("progres");

    }


    void Update()
    {

        ClickTextA.text = a.ToString();
        ClickTextB.text = b.ToString();
        ClickTextC.text = c.ToString();
        ClickTextD.text = d.ToString();
        ClickTextF.text = f.ToString();
        ClickTextN.text = n;
        ClickTextV.text = v;
        ClickTextL.text = l;
        ClickTextY.text = y;
        ClickTextT.text = t;
 

        if (a <= 0)
        {
            v = "Вы умерли, ХА ХА ХА";
        }
        else
        {
            v = "";
        }
        if (b <= 0)
        {
            l = "Вы устали, вам нужно поспать";
        }
        else
        {
            l = "";
        }
        if (d <= 3.5)
        {
            y = "У вас низкая успеваемость, теперь вас бьет МАМА";
        }
        else
        {
            y = "";
        }
        if (d <= 2)
        {
            t = "Вас исключили из школы";
        }
       



        
    } 
    
    public void ClickFight()
    {
        d = Math.Round(d, 1);
        if (a <= 0)
        {
            GetComponent<Button>().interactable = false;
        }
        if (b <= 0)
        {
            GetComponent<Button>().interactable = false;
        }
        if (d <= 2)
        {
            GetComponent<Button>().interactable = false;
        }
        if (a <= 100 & a >= 10)
        {
            a -= 10;
        }
       if (b <= 100 & b >= 10)
        {
            b -= 10;
        }
        if (c <= 90 & c >= 0)
        {
            c += 10;
        }
        if (f <= 100 & f >= 10)
        {
            f -= 10;
        }
        if (d <= 5.1)
        {
            d -= 0.1;
        }
       if (d <= 3.5 & a >= 10)
        {
            a -= 10;
        }
        manny += 100;
        PlayerPrefs.SetInt("manny", manny);
        progres += 100;
        PlayerPrefs.SetInt("progres", progres);

    }
    public void ClickSleep()
    {
        d = Math.Round(d, 1);
        if (d <= 2)
        {
            GetComponent<Button>().interactable = false;
        }
        if (a <= 0)
        {
            GetComponent<Button>().interactable = false;
        }
        a = 100;
        b = 100;

    }
    public void ClickStudy()
    {
        d = Math.Round(d, 1);
        if (d <= 2 | d == 5)
        {
            GetComponent<Button>().interactable = false;
        }
        if (b <= 0)
        {
            GetComponent<Button>().interactable = false;
        }
        if (a <= 0)
        {
            GetComponent<Button>().interactable = false;
        }
        if (a <= 100 & a >= 10)
        {
            a -= 10;
        }
        if (b <= 100 & b >= 10)
        {
            b -= 10;
        }
        if (c <= 100 & c >= 10)
        {
            c -= 10;
        }
        if (f <= 100 & f >= 10)
        {
            f -= 10;
        }
        if (d <= 4.8)
        {
            d += 0.2;
        }
        else if (d == 4.9)
        {
            d += 0.1;
        }
        if (d <= 3.5 & a >= 10)
        {
            a -= 10;
        }
        manny += 100;
        PlayerPrefs.SetInt("manny", manny);

    }
    public void ClickSatiety()
    {
        d = Math.Round(d, 1);
        if (d == 2)
        {
            GetComponent<Button>().interactable = false;
        }
        if (a <= 0)
        {
            GetComponent<Button>().interactable = false;
        }
        if (b <= 0)
        {
            GetComponent<Button>().interactable = false;
        }
        if (f <= 90 & f >= 0)
        {
            f += 10;
        }
        if (d <= 5.1)
        {
            d -= 0.1;
        }
        if (d <= 3.5 & a >= 10)
        {
            a -= 10;
        }
        if (b <= 90 & b >= 0)
        {
            b += 10;
        }
    }
    
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    
}
