using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownCreation : MonoBehaviour
{
    [SerializeField]
    GameObject bolder;
    [SerializeField]
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomSpawnPos = new Vector3(Random.Range(14,20) + target.position.x, Random.Range(2,5) + target.position.y + 4, 0);
        Instantiate(bolder, randomSpawnPos, Quaternion.identity);
        StartCoroutine("SummonClown");
    }
    IEnumerator SummonClown()
    {
            for (float i = 1f; i >= 0; ++i)
            {
                Vector3 randomSpawnPos = new Vector3(Random.Range(14, 20) + target.position.x, Random.Range(2, 5) + target.position.y + 4, 0);
                Instantiate(bolder, randomSpawnPos, Quaternion.identity);
                yield return new WaitForSeconds(1f);
            }
            yield return new WaitForSeconds(.1f);
    }
}

