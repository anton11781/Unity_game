using UnityEngine;

public class CyclesDemo : MonoBehaviour
{
    public GameObject Prefab;

    void Start()
    {
        for (
            var i = 0f; 
            i < 10; 
            i = i+1
        )
        {
            var newCube = Instantiate(Prefab);
            newCube.transform.position = new Vector3(i,0,0);
        }
    }
}