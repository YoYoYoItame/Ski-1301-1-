using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    [SerializeField]
    private TMP_Text notiText;

    public static GameManager instance;
    void Start()
    {
        instance = this;
    }

    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }

}
