using UnityEngine;

public class Dead : MonoBehaviour
{
   
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject CompleteLavelUI;

    public void CompleteLavel ()
    {
        CompleteLavelUI.SetActive(true);
    } 
    
}
