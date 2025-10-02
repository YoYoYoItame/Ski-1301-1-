using UnityEngine;

public class Rock : MonoBehaviour
{
   private Renderer rd;

   void Start()
   {
    rd = GetComponent<Renderer>();
   }
    private void OnCollisionEnter (Collision collision)
  {
    Player player = collision.gameObject.GetComponent<Player>();
    player. HP -= 25;
    
    string s = string.Format("Hit (-15)\nRemaining HP:{0}", player.HP);
    GameManager.instance. ShowNotiText(s);
    
    if (player.HP <= 0)
    {
    player.HP = 0;
    GameManager.instance.ShowNotiText("You are dead!");
    Time.timeScale = 0;
    }
  }
  private void OnCollisionExit(Collision collision)
  {
  rd.material.color = new Color32(211, 80, 0, 255);
  }
}
