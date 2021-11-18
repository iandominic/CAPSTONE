using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destination : MonoBehaviour
{

    public int pivotPoint = 0;

    void OnTriggerEnter(Collider col)
    {

        if(col.tag == "tambay")
        {
            Debug.Log("entered");
            if (pivotPoint == 5)
            {
                pivotPoint = 0;
            }
            if (pivotPoint == 4)
            {
                this.gameObject.transform.position = new Vector3(11, -8, 10);
                pivotPoint = 5;
            }
            if (pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(14, -8, 4);
                pivotPoint = 4;
            }
            if (pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(16, -8, 8);
                pivotPoint = 3;
            }
            if (pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(16, -8, 11);
                pivotPoint = 2;
            }
            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(11, -8, 12);
                pivotPoint = 1;
            }
        }
    }
}
