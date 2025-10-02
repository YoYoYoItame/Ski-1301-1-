using UnityEngine;

public class YaY : MonoBehaviour
{
         private void OnTriggerEnter(Collider other)
        {
          Player player = other.GetComponent<Player>();
          player.Score += 5;
          
          string s = string.Format("+5 points\nYour score is {0}", player.Score);
          GameManager.instance. ShowNotiText(s);
          Destroy(gameObject);
        }
}
