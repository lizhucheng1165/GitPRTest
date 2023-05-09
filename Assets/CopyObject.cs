using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyObject : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float timer = 0;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.3f)
        {
            GameObject copy = Instantiate(obj);
            copy.GetComponent<Rigidbody>().useGravity = true;
            copy.transform.position = this.transform.position;
            timer = 0f;
        }
    }
}
