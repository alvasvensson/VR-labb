using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    [SerializeField]
    float force = 500;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
