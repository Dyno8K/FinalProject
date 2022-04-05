using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    public static enemyManager _inst;

    public enemy EnemytoSpawn1;
    public enemy EnemytoSpawn2;
    public static float fallSpeed = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        fallSpeed = 1.1f;
        bool a = true;
        bool y = false;
        bool x = false;
        bool z = false;
        StartCoroutine(wait(fallSpeed, x, y));


        IEnumerator wait(float f, bool x, bool y)
        {

            while (a)
            {
                SpawnNewEnemy();
                if (f > 0.7f)
                {
                    f -= 0.004f;
                    yield return new WaitForSeconds(f);
                }
                if (f < 0.71)
                {
                    a = false;
                    x = true;
                    
                }



            }
            while (x)
            {
                SpawnNewEnemy();
                if (f > 0.5f)
                {
                    f -= 0.005f;
                    yield return new WaitForSeconds(f);
                }
                if (f < 0.51)
                {
                    x = false;
                    y = true;
                }



            }
            while (y)
            {
                SpawnNewEnemy();
                if (f > 0.3f)
                {
                    f -= 0.003f;
                    yield return new WaitForSeconds(f);
                }
                if (f < 0.31)
                { 
                    y = false;
                    z = true;
                }



            }
            while (z)
            {
                SpawnNewEnemy();
                if (f > 0.2f)
                {
                    f -= 0.001f;
                    yield return new WaitForSeconds(f);
                }
                if (f < 0.21)
                {
                    y = false;
                    z = false;
                }



            }
        }



        void SpawnNewEnemy()
        {
            var randomValue = Random.Range(0, 10);
            if (randomValue > 5)
            {
                var randomX = Random.Range(EnemytoSpawn1.minX, EnemytoSpawn1.maxX);
                var pos = new Vector2(randomX, 10);
                Instantiate(EnemytoSpawn1, pos, Quaternion.identity, transform);

                var randomX2 = Random.Range(EnemytoSpawn1.minX, EnemytoSpawn1.maxX);
                
                var pos1 = new Vector2(randomX2, 12);
                Instantiate(EnemytoSpawn1, pos1, Quaternion.identity, transform);
                fallSpeed -= 0.02f;

                var randomX3 = Random.Range(EnemytoSpawn1.minX, EnemytoSpawn1.maxX);
                var pos2 = new Vector2(randomX3, 18);
                Instantiate(EnemytoSpawn1, pos2, Quaternion.identity, transform);

            }
            else
            {
                var randomX = Random.Range(EnemytoSpawn2.minX, EnemytoSpawn2.maxX);
                var pos = new Vector2(randomX, 8);
                Instantiate(EnemytoSpawn2, pos, Quaternion.identity, transform);



            }


        }


    }
    void Update()
    {
        
    }
}   
