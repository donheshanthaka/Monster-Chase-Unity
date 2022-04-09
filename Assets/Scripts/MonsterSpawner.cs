using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] monsterReference;

    private GameObject spawnedMonster;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    IEnumerator SpawnMonsters()
    {
        while (true)
        {
            // The time duration until a new monster is spawned
            yield return new WaitForSeconds(Random.Range(1, 5));

            // Getting an index value from the list of monsters (between 0 - 2) for the 3 monsters we have in the array
            // monsterReference.Length returns the length of the array which can be considered the last index
            randomIndex = Random.Range(0, monsterReference.Length);

            // Getting a random side for the mosters to spwan
            randomSide = Random.Range(0, 2);

            // A copy of a monster game object will be created out of the reference passed in from the array of monsters
            spawnedMonster = Instantiate(monsterReference[randomIndex]);

            // updating the transform position of the created monster with the respective position 
            // the leftPos/ rightPos transform positions are set inside the inspector panel
            if (randomSide == 0)
            {
                // left side
                spawnedMonster.transform.position = leftPos.position;
                // Getting the monster component from the spawned monster and setting it a random speed
                spawnedMonster.GetComponent<Monster>().speed = Random.Range(2, 4);
            }
            else
            {
                // right side
                spawnedMonster.transform.position = rightPos.position;
                // Getting the monster component from the spawned monster and setting it a random speed
                // The value is negated to move the character from right to left
                spawnedMonster.GetComponent<Monster>().speed = -Random.Range(2, 4);
                // The first value is negated because the default orientation of the object would be facing right,
                // ...since this enemy is moving from right to left it should be facing left side, which is achieved using the negation
                spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        } // while
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
