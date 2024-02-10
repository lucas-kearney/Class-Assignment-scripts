using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player2controller : MonoBehaviour

{
    private Player thePlayer;
    public TextMeshPro setName;
    // Start is called before the first frame update
    
    void Start()
    {
       this.thePlayer = new Player("Dave");
       SetPlayerInfo();
       
    }
    

    // Update is called once per frame
    
    void SetPlayerInfo()
    {
        string PlayerInfo = this.thePlayer.display(); 
        setName.text = PlayerInfo;
        
    }
    
    void FixedUpdate()
    {
        
       /*
       if(MySingleton.player1Turn == false)
       {
            print("****** Player2: " + MySingleton.count + "******");
            MySingleton.count++;
            MySingleton.player1Turn = true;
       }
       */
    }
}
