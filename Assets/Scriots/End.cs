
using UnityEngine;

public class End : MonoBehaviour
{      
       private void OnTriggerEnter(Collider other)
   {
         Player player = other.GetComponent<Player>();
         player.Score += 100;
         
         string s = string.Format("You Win!\nYour score is: {0}", player.Score);
         GameManager.instance.ShowNotiText(s);
   }
}