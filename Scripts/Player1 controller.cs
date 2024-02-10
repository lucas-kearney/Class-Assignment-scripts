using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player1controller : MonoBehaviour

{
    private Player thePlayer;
    public TextMeshPro setName;
    public GameObject destinationGo;
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
       this.thePlayer = new Player("Mike");
       SetPlayerInfo();
       
    }

    void SetPlayerInfo()
    {
        string playerInfo = this.thePlayer.display();
        setName.text = playerInfo;
        
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        moveTowardsDestination();
        /*
        if(MySingleton.player1Turn == true)
        {
            print("****** Player1: " + MySingleton.count + "******");
            MySingleton.count++;
            MySingleton.player1Turn = false;
        }
        */
    }
    void moveTowardsDestination()
    {
        Vector3 targetPosition = this.destinationGo.transform.position;
        Vector3 startingPosition = this.gameObject.transform.position;

        if(targetPosition != startingPosition)
        {
        this.transform.position = Vector3.MoveTowards(startingPosition, targetPosition, speed * Time.deltaTime);
        } 

    }
}
