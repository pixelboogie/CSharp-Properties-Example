using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour 
{
    void Start () 
    {
        Debug.Log("Game Started ");
        
        Player myPlayer = new Player();

        //Properties can be used just like variables
        myPlayer.Experience = 5000f;
        float exp = myPlayer.Experience;
        float lvl = myPlayer.Level;
        float hlth = myPlayer.Health;
        

        Debug.Log("Game experience = " + exp);
        Debug.Log("Game level = " + lvl);
        Debug.Log("Game health = " + hlth);

         Debug.Log("Game Start ended ");
    }
}