using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    //    // Start is called before the first frame update
        [SerializeField]
        private GameObject[] foodReference; // to make copies of the monsters
        [SerializeField]
        private Transform leftpos;

        private GameObject spawnedFood;
        private int randomIndex; // to randomise which monster is spawned
        private int level;


        void Start()
         {
             StartCoroutine(SpawnFood()); 
         }


        // create a coroutine as we can call it over and over again on a set time interval 
        IEnumerator SpawnFood()
        {
            while (true )
            {
                    yield return new WaitForSeconds(Random.Range(1, 3)); // randomly choses the time interval that we have to wait before a new monster is spawned 
                    randomIndex = Random.Range(0, foodReference.Length);  // randomly choses the monster ( value between 0 and 3 )

                    spawnedFood = Instantiate(foodReference[randomIndex]);



                    spawnedFood.transform.position = leftpos.position;
                    level = GameManager.instance.LevelIndex;
                    if (level == 0)
            {
                spawnedFood.GetComponent<FoodMovement>().speed = 1;//Random.Range(1, 2);

            }
                    else if (level == 1)
            {
                spawnedFood.GetComponent<FoodMovement>().speed = 2;//Random.Range(3, 4);

            }
                    else if(level == 2)
            {
                spawnedFood.GetComponent<FoodMovement>().speed = 3;// Random.Range(5, 6);

            }
                    else if(level  == 3) {
                spawnedFood.GetComponent<FoodMovement>().speed = 5;// Random.Range(7, 8);
            }
                    else if(level == 4)
            {
                spawnedFood.GetComponent<FoodMovement>().speed = 7; // Random.Range(9, 10);

            }


        }
       
        }
}
