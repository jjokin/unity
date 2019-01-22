using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowController : MonoBehaviour
{
    public Transform weaponhold;
    Bow equippedBow;
    public Bow startingBow;

    void Start()
    {
        if(startingBow != null)
        {
            EquipBow(startingBow);
        }
    }

    public void EquipBow(Bow Bowtoequip)
    { 
        if (equippedBow != null)
            Destroy(equippedBow.gameObject);

        // tähtäysvirhe testi
        float x = Random.Range(-2, 2);
        Debug.Log("Vaihdetaan kulmaa ");
        Debug.Log(x);
        
        //weaponhold.transform.parent;
        weaponhold.Rotate(x, x, x);

        equippedBow = Instantiate(Bowtoequip,weaponhold.position, weaponhold.rotation) as Bow;

        //liikkuu mukana mihin pelaaja
        equippedBow.transform.parent = weaponhold;
    }
    
    
    // kuka ampuu jotta erottaa player ja enemy
    public void Shoot(MonoBehaviour shooter)
    {
        //Debug.Log(" AMPU TULEE");

        if (shooter.tag == "Player")
        {
            //Debug.Log("try shoot");
            if (equippedBow != null)
            {
                equippedBow.Shoot();
                // Debug.Log("shoot");
            }
        }
        else
        {
            //Debug.Log("Yrittää ampua");
            equippedBow.Shoot();
        }
    }

}
