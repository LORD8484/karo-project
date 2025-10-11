using UnityEngine;
using UnityEngine.UI;

public class scene3 : MonoBehaviour
{
    public Image Avatar1;
    public Image Avatar2;
    public Image Avatar3;

    public Image Item;
    public Image Tool;

    int avatarnum;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float r = PlayerPrefs.GetFloat("color_r");
        float g = PlayerPrefs.GetFloat("color_g");
        float b = PlayerPrefs.GetFloat("color_b");
        float a = PlayerPrefs.GetFloat("color_a");

        Color avatarcolor = new Color(r, g, b, a);

        avatarnum = PlayerPrefs.GetInt("SelectedAvatar");

        if (avatarnum == 0)
        {
            Avatar1.gameObject.SetActive(true);
            Avatar1.color = avatarcolor;
        }
        if (avatarnum == 1)
        {
            Avatar2.gameObject.SetActive(true);
            Avatar2.color = avatarcolor;
        }
        if (avatarnum == 2)
        {
            Avatar3.gameObject.SetActive(true);
            Avatar3.color = avatarcolor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
