using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunController : MonoBehaviour
{

    [SerializeField]
    GameObject bulletPrefab;

    [SerializeField]
    Transform barrelEnd;

    ActionBasedController controller;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PullTrigger()
    {
        // Debug.Log("BANG");
        Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation);
    }
}