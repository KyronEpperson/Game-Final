using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static int points;
    public static int lives;
    public static int add;

    public static Text point;
    public static Text live;
    public static Text username;
    // Start is called before the first frame update

    void Start()
    {
        points = 0;
    }

    private void Update()
    {
        point.text = points.ToString();
        live.text = lives.ToString();
        username.text = username.ToString();
    }

    public void addPoint()
    {
        points = points + 1;
    }

    public void subtractPoint()
    {
        points = points - 1;
    }

    public void addlife()
    {
        lives = lives + 1;
    }

    public void subtractLife()
    {
        lives = lives - 1;
    }

}
