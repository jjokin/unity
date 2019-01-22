using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour {

    public Enemy enemy;
    public int numberOfEnemies = 19;
    Vector3 soldierPosition;

    //public Enemy[] enemies = new Enemy[numberOfEnemies];






    void Start()
    {
        
        soldierPosition.x = 1;
        soldierPosition.y = 1;
        soldierPosition.z = 1;
        
         
        
        int n = 0;



        while (numberOfEnemies > n)
        {
            Enemy soldier = Instantiate(enemy, soldierPosition, Quaternion.identity) as Enemy;

            soldierPosition.x = soldierPosition.x + 2;
            n++;
        }
            /*
            //id josta tunnistaa yksiselitteisesti instanssin
            soldier.ChangeID(n);

           
            if (num_of_leaders +1 >  n)
            {
               
                leaders[k] = soldier;
                k++;
            }
           
            else if (num_of_leaders + 1 < n)
            {
                

                // uusi testi II
               
                int g = 0;
                g= leaders[s].subnum;
                leaders[s].subordinates[g] = soldier;
                leaders[s].subnum++;
                
                if (dividing_soldiers >6)
                {
                    dividing_soldiers = 0;
                    s++;
                }
                dividing_soldiers++;
                    
            }
           
            else
            {
                
            }
            Debug.Log(" taulukkoon numero: ");
            Debug.Log(n);
            // taulukkoon talteen
            enemies[n] = soldier;

            n++;
           
                
          }

        GiveOrders(); 
        
    }
   public void GiveOrders()
    {
        
        int h = 0;
        if (leaders.Length > 0)
        {
            while (h < num_of_leaders)
            {

                                   
                    int s = 0;

                    bool rightside = false;
                    Transform leaderPlace = leaders[h].transform;
                    while (s > leaders[h].subordinates.Length - 1)
                    {
                        //ekalla kerralla aloitetaan oikealta
                        if (h == 0)
                        {
                            rightside = true;
                        }
                        if (rightside == true)
                        {
                            leaders[h].subordinates[s].MoveTo.x = leaderPlace.transform.position.x + (1 * h);
                            leaders[h].subordinates[s].MoveTo.y = leaderPlace.transform.position.y - (1 * h);
                            rightside = false;
                            Debug.Log(" KOHDE:");
                            Debug.Log(leaders[h].subordinates[s].MoveTo);

                            Debug.Log(" KOHDE:");
                            Debug.Log(leaders[h].subordinates[s].MoveTarget.transform.position);
                            leaders[h].subordinates[s].MoveTarget.transform.position = leaders[h].subordinates[s].MoveTo;
                        }
                        if (rightside == false)
                        {
                            leaders[h].subordinates[s].MoveTo.x = leaderPlace.transform.position.x - (1 * h);
                            leaders[h].subordinates[s].MoveTo.y = leaderPlace.transform.position.y - (1 * h);
                            rightside = true;

                            leaders[h].subordinates[s].MoveTarget.transform.position = leaders[h].subordinates[s].MoveTo;
                        }
                        s++;
                    }

                
                h++;
            }
        }
     


        */
      
        

                
        
    }
    /*
    void Update()
    {
        
        

       
    }
*/
}
