using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    public Text name1;
    public InputField display;

    // Start is called before the first frame update
    void Start()
    {
        name1.text = PlayerPrefs.GetString("user_name");
    }

    public void Create()
    {
        name1.text = display.text;
        PlayerPrefs.SetString("user_name", name1.text);
        PlayerPrefs.Save();
    }

    public void setUsername(string name)
    {
        name1.text = name;
    }


}
