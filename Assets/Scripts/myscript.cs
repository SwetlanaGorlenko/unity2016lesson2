using UnityEngine;
using System.Collections;

public class myscript : MonoBehaviour {

    public GameObject[,] items;

    public GameObject[] peoplePrefabs; // Префабы




    GameObject obj, obj_cell; // Объект
    public int j_cell, i_cell;
   
  
        
   
    void Start()
    {
        
       GameObject[] peoplePrefabs = { Instantiate(Resources.Load("one")) as GameObject, Instantiate(Resources.Load("two")) as GameObject, Instantiate(Resources.Load("three")) as GameObject, Instantiate(Resources.Load("four")) as GameObject, Instantiate(Resources.Load("five")) as GameObject, Instantiate(Resources.Load("six")) as GameObject };
       GameObject[,] items = new GameObject[8, 8];
        var my_cell = Instantiate(Resources.Load("cell")) as GameObject;

          for (i_cell = 0; i_cell < 8; i_cell++)
          {
              for (j_cell = 0; j_cell < 8; j_cell++)
              {


                  obj_cell = Instantiate(my_cell);
                  obj_cell.transform.position = new Vector3(i_cell, j_cell, 0);

                  obj = Instantiate(peoplePrefabs[Random.Range(0, 5)]);
                  obj.transform.parent = obj_cell.transform;
                  obj.transform.position=new Vector3(i_cell, j_cell, -1);


              }

          }

        my_cell.SetActive(false);
        for (int k = 0; k < peoplePrefabs.Length; k++)
        {
            peoplePrefabs[k].SetActive(false);
        }
       


    }

   /* void fly()
    {
        for (double j = 0; j < 8; j = +0.001)
        {


            obj.transform.position = new Vector3(0, (float)j, 0);
        }
    }*/

    // Update is called once per frame
    void Update()
    {

    }

}