using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class LerpMechanic : MonoBehaviour
{
    public static LerpMechanic instance;
    public List<GameObject> cubes = new List<GameObject>();
    public float movementDelay = 0.25f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MoveListElement();
        }
        if (Input.GetMouseButtonUp(0))
        {
            MoveOrigion();
        }



    }

  
    public void Stack(GameObject other, int index)
    {
        other.transform.parent = transform;
        Vector3 newPos = cubes[index].transform.localPosition;
        newPos.z += 1f;
        newPos.y = -0.5f;
        other.transform.localPosition = newPos;
        cubes.Add(other);
       
        
    }




    private void MoveListElement()
    {
        for (int i = 1; i < cubes.Count; i++)
        {
            Vector3 pos = cubes[i].transform.localPosition;
            pos.x = cubes[i - 1].transform.localPosition.x;
            cubes[i].transform.DOLocalMove(pos, movementDelay);
        }
    }


    private void MoveOrigion()
    {
        for (int i = 1; i < cubes.Count; i++)
        {
            Vector3 pos = cubes[i].transform.localPosition;
            pos.x = cubes[0].transform.localPosition.x;
            cubes[i].transform.DOLocalMove(pos, 0.70f);
        }
    }
}




