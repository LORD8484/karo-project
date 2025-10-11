using UnityEditor.SearchService;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class controls : MonoBehaviour
{
    public Image[] avatars;
    public Color selected_color = Color.white;
    public Color unselected_color = new Color(38f / 255f, 38f / 255f, 38f / 255f, 1f);
    public bool avatarpick = false;

    public TMP_InputField usernameinput;
    public TMP_Text warning_avatar;
    public TMP_Text warning_username;
    public TMP_Text warning_avaus;
   

    float timer = 0f;
    string username;


    
    public void Update()
    {
 
        if((warning_avatar != null && warning_avatar.gameObject.activeSelf) || (warning_username != null && warning_username.gameObject.activeSelf) || (warning_avaus != null && warning_avaus.gameObject.activeSelf))
        {
            timer += Time.deltaTime;
        }
        if (timer >= 3f)
        {
            warning_avatar.gameObject.SetActive(false);
            warning_username.gameObject.SetActive(false);
            warning_avaus.gameObject.SetActive(false);
            timer = 0f;
        }
    }
    public void SelectAvatar(int index)
    {
        for (int i = 0; i < avatars.Length; i++)
        {
            if (i == index)
            {
                avatars[i].color = selected_color;
                
            }
            else
            {
                avatars[i].color = unselected_color;
            }
        }
        PlayerPrefs.SetInt("SelectedAvatar", index);
        PlayerPrefs.Save();
        avatarpick = true;
    }
    public void Edit_Avatar_Scene()
    {
        username = usernameinput.text;

        if (avatarpick && !string.IsNullOrEmpty(username))
        {
            
            PlayerPrefs.SetString("username", username);
            SceneManager.LoadScene(1);
        }
        else if (!avatarpick && string.IsNullOrEmpty(username))
        {
            
            warning_avaus.gameObject.SetActive(true);
        }
        else if (!avatarpick)
        {
            
            warning_avatar.gameObject.SetActive(true);
        }
        else if (string.IsNullOrEmpty(username))
        {
            
            warning_username.gameObject.SetActive(true);
        }

       
        timer = 0f;
    }

    
}
  


