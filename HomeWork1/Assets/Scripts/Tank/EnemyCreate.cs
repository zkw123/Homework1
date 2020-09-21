using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyCreate : MonoBehaviour
{

    public GameObject targetEnemy;


    public int enemyTotalNum = 10;


    public float intervalTime = 5;


    private int enemyCounter;



    private GameObject targetPlayer;



    void Start()
    {

        targetPlayer = GameObject.FindGameObjectWithTag("Player");

        enemyCounter = 0;

        InvokeRepeating("CreatEnemy", 0.5F, intervalTime);

    }


    void Update()
    {



    }

    private void CreatEnemy()
    {
        if (targetPlayer.GetComponent<TankHealth>().m_Dead==false)
        {
            /*
            MeshRenderer[] renderers = targetEnemy.GetComponentsInChildren<MeshRenderer>();
            for (int i = 0; i < renderers.Length; i++)
            {
                // ... set their material color to the color specific to this tank.
                renderers[i].sharedMaterial.color =Color.red;
            }
            */
            System.Random r = new System.Random();
            int rx = r.Next(30);
            int rz = r.Next(30);
            Instantiate(targetEnemy, new Vector3(rx-15,0,rz-15), Quaternion.identity);
            enemyCounter++;

            if (enemyCounter == enemyTotalNum)
            {

                CancelInvoke();

            }

        }

        else
        {

            CancelInvoke();

        }

    }

}