using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGenerator : MonoBehaviour
{
  
    public int Num1 = 8;
    public int Num2 = 0;

    public Vector3 RandomPosition()
    {
        float randomX = Random.Range(Num2, Num1);
        float randomY = Random.Range(Num2, Num1);
        float randomZ = Random.Range(Num2, Num1);
        return new Vector3(randomX, randomY, randomZ);
    }

    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = RandomPosition();
        }
    }
}
