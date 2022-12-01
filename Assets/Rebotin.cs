using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebotin : MonoBehaviour
{
    [SerializeField] Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        anim.SetTrigger("Saltar");
    }


}
