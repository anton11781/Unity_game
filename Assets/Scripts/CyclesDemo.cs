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
            newCube.GetComponent<MeshRenderer>()
                .material.color = new Color(
                Random.Range(0,1f), 
                Random.Range(0,1f), 
                Random.Range(0,1f));
        }

        int k = 0;
        do
        {
            k++;
        } while (k < 10);

        int j = 10;
        while (j < 10)
        {
            var newCube = Instantiate(Prefab);
            newCube.transform.position = new Vector3(j,1,0);
            newCube.GetComponent<MeshRenderer>()
                .material.color = new Color(
                Random.Range(0,1f), 
                Random.Range(0,1f), 
                Random.Range(0,1f));
            j++;
        }
    }
}