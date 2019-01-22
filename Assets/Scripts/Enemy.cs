using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof(Player))]
[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{

    Transform target;
    //Vector3 target;
    //Rigidbody EnemyRigidbody;
    BowController bowcontroller;
    GameController gamecontroller;
    Vector3 velocity;
    Vector3 enemyposition;
    public float speed = 2;
    public float MaxDist = 15;
    public float MinDist = 5;

    public string rank;
    int health;
    int experience;
    int morale;

    //fyysiset
    int strenght;
    int vitality;
    int endurance;

   

    public bool defend;
    public bool attack;
    public bool retreat;

    public Enemy[] subordinates = new Enemy[12];
    public int subnum;
    public Enemy Commander;
    
    public int[] subo = new int[12];
    // TUNNISTEET
    //ryhmä johon kuuluu
    public int team;
    
    public bool FormationisActive;
    public string FormationType;
    public Vector3 FormationMoveTo;
    public bool FormationPositionReady;
    public bool FormationIsMoving;
    
    public Vector3 MoveTo;
    public Transform MoveTarget;

    int ID;










    // Use this for initialization
    void Start()
    {
       // if (team == team1)
          //  target = team2[n].transform;
        target = GameObject.FindGameObjectWithTag("Player").transform;

        bowcontroller = GetComponent<BowController>();
        //alaisia alussa 0
        subnum = 0;

        // EnemyRigidbody = GetComponent<Rigidbody>();
        // enemyposition = transform.position;





    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        if (transform.position.x < target.position.x)
        {
            velocity.x = 1;
        }
        else if (transform.position.x > target.position.x)
        {
            velocity.x = -1;
        }
        else
        {
            velocity.x = 0;
        }

        if (transform.position.z < target.position.z)
        {
            velocity.z = 1;
        }
        else if (transform.position.z > target.position.z)
        {
            velocity.z = -1;
        }
        else
        {
            velocity.z = 0;
        }

        */
        //gamecontroller.GiveOrders();
        if (rank == "Sergeant")
        {
            transform.LookAt(target);
            MoveTarget = transform;
        }
        if (rank == "Spearman")
        {
            transform.LookAt(MoveTarget);
            Debug.Log(MoveTarget);
        }
        // tähän sijoitukset ryhmä
        if (transform == MoveTarget)
        {
            //bowcontroller.Shoot(this);
            Debug.Log("Paikalla!");
        }
        else
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            Debug.Log("siirrytään:");
            Debug.Log(MoveTarget);
        }

        /*      

          //liikkuminen
          if (Vector3.Distance(transform.position, target.position) <= MaxDist || defend == false)
          {
              if (Vector3.Distance(transform.position, target.position) >= MinDist)
              {
                  transform.position += transform.forward * speed * Time.deltaTime;
              }
              else
              {
                 // Debug.Log("pitäisi yrittää ampua ");
                  bowcontroller.Shoot(this);
                 // Debug.Log(" ampuiko?");
              }
          }
          else
          {
              //Debug.Log("pitäisi yrittää ampua ");
              bowcontroller.Shoot(this);
              if(Vector3.Distance(transform.position, target.position) >= MinDist)
              {
                  transform.position -= transform.forward * speed * Time.deltaTime;
              }
              //Debug.Log(" ampuiko?");
          }
          //transform.Translate(velocity * Time.fixedDeltaTime * speed);

          //  EnemyRigidbody.MovePosition(EnemyRigidbody.position + velocity * Time.fixedDeltaTime * speed);
      */
    }
    public void ChangeRank(string rank_)
    {
        rank = rank_;
    }
    public string GiveRank()
    {
        return rank;
    }
    public int GiveLeader()
    {
        return Commander.GiveID();
    }
    public string Name()
    {
        return name;
    }
    public void ChangeName(string name_)
    {
        name = name_;
    }
    public int GiveID()
    {
        return ID;
    }
    public void ChangeID(int id)
    {
        ID = id;
    }
    public void addSubordinate(Enemy added)
    {
        //lisätään alainen
        subordinates[subnum] = added;
        subnum++;



    }




 
    /*
    void MakeFormation(Enemy Nco)
    {
        int n = 0;
        while (Nco.subnum > n)
        {
            int h = 0;

            while (gamecontroller.leaders[n].subnum > h)
            {

                h++;

            }
            n++;
        }

    }
    */
}

