using UnityEngine;
using System.Collections;

public class Player
{
    //Member variables can be referred to as
    //fields.
    private float experience;

    //Experience is a basic property
    public float Experience
    {
        get
        {
           
            Debug.Log("inside Experience get");
            return experience;
        }
        set
        {
            Debug.Log("inside Experience set");
            experience = value;
        }
    }

    //Level is a property that converts experience
    //points into the leve of a player automatically
    public float Level
    {
        get
        {
             Debug.Log("Level get");
            return experience / 100f;
        }
        set
        {
            Debug.Log("Level set");
            experience = value * 100f;
        }
    }

    //This is an example of an auto-implemented
    //property
    public float Health{ get; set;}


    public Player (){
        Debug.Log("Player constructor method starts.");
        Debug.Log("Experience is " + Experience);
        Debug.Log("Level is " + Level);
        Debug.Log("Health is " + Health);
        Debug.Log("Player constructor method ends.");
    }
}
