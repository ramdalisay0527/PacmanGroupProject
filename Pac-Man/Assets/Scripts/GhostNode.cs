using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class direction 
{

    Vector2 direct;

    public bool tick;
    public direction(int x, int y)
    {
        this.direct = new Vector2(x,y);
        
    }


    public Vector2 getDirect()
    {
        return direct;
    }
}
public class GhostNode : MonoBehaviour
{

    public direction up = new direction(0,8);
    public direction down = new direction(0, -8);
    public direction right = new direction(8, 0);
    public direction left = new direction(-8, 0);

    public Vector3 wallCheck;
    private direction[] directions;
    List<direction> confirmedDirection = new List<direction>();


    private void Awake()
    {
        createDirections();
    }

    public Vector2 randomDirection()
    {
        int randomNumber  = Random.Range(0, confirmedDirection.Count);

        return confirmedDirection[randomNumber].getDirect();

    }
    void createDirections()
    {
        directions = new direction[] { up, down, left, right };
        foreach (direction x in directions)
        {
            if (x.tick == false)
            {
                continue;
            }
            else
            {
                confirmedDirection.Add(x);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ghost")
        {
            
          
            
                collision.GetComponentInParent<Ghost>().updateDirect(randomDirection());

            
            

        }
    }
}
