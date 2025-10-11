using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scene2 : MonoBehaviour
{
    public TMP_Text welcome;
    public int avatarnum;

    public Image pickavatar;
    
    public Image avatar1;
    public Image avatar2;
    public Image avatar3;

    public GameObject colortab;
    public GameObject tooltab;
    public GameObject itemtab;

    public Image[] tooltype;
    public Image[] itemtype;

    public Color selectedcolor = Color.white;
    public Color unselectedcolor = new Color(38f / 255f, 38f / 255f, 38f / 255f, 1f);

    
    
    void Start()
    {

        

        avatar1.gameObject.SetActive(false);
        avatar2.gameObject.SetActive(false);
        avatar3.gameObject.SetActive(false);

        avatarnum = PlayerPrefs.GetInt("SelectedAvatar");

        string usernamep = PlayerPrefs.GetString("username");
        welcome.text = "Welcome " + usernamep;
    }

    
    void Update()
    {
        if (avatarnum == 0)
        {
            avatar1.gameObject.SetActive(true);
            pickavatar = avatar1;
        }
        if (avatarnum == 1)
        {
            avatar2.gameObject.SetActive(true);
            pickavatar = avatar2;
        }
        if (avatarnum == 2)
        {
            avatar3.gameObject.SetActive(true);
            pickavatar = avatar3;
        }
    }
    public void Return_privous_Scene()
    {
        SceneManager.LoadScene(0);
    }
    public void ColorTab()
    {
        colortab.SetActive(true);
        itemtab.SetActive(false);
        tooltab.SetActive(false);
    }
    public void ToolsTab()
    {
        colortab.SetActive(false);
        itemtab.SetActive(false);
        tooltab.SetActive(true);
    }
    public void ItemTab()
    {
        colortab.SetActive(false);
        itemtab.SetActive(true);
        tooltab.SetActive(false);
    }

    public void itemcol (int itemnum)
    {
     for (int i = 0; i < itemtype.Length; i++)
        {
            if (i == itemnum)
            {
                itemtype[i].color = selectedcolor;
            }
            else
                itemtype[i].color = unselectedcolor;
        }
        PlayerPrefs.SetInt("selitem", itemnum);
        PlayerPrefs.Save();
        
    }
    public void toolcol (int toolnum)
    {
        for(int i=0; i <tooltype.Length;i++) {
            if (i == toolnum)
            {
                tooltype[i].color = selectedcolor;
            }
            else
                tooltype[i].color = unselectedcolor;
        }
        PlayerPrefs.SetInt("seltool", toolnum);
        PlayerPrefs.Save();
    }
    public void SaveColor(Color color)
    {
        PlayerPrefs.SetFloat("color_r", color.r);
        PlayerPrefs.SetFloat("color_g", color.g);
        PlayerPrefs.SetFloat("color_b", color.b);
        PlayerPrefs.SetFloat("color_a", color.a);
        PlayerPrefs.Save();

    }
    public void redcolor()
    {
        pickavatar.color = Color.red;
        SaveColor(Color.red);
    }
    public void blackcolor()
    {
        pickavatar.color = Color.black;
        SaveColor(Color.black);
    }
    public void greencolor()
    {
        pickavatar.color = Color.green;
        SaveColor(Color.green);
    }
    public void bluecolor()
    {
        pickavatar.color = Color.blue;
        SaveColor(Color.blue);
    }
    public void yellowcolor()
    {
        pickavatar.color = Color.yellow;
        SaveColor(Color.yellow);
    }
    public void purplecolor()
    {
        pickavatar.color = new Color32 (255,0,217,255);
    }

    public void nextscene()
    {
        SceneManager.LoadScene(2);
    }
}
