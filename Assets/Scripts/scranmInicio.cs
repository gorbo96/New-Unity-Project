using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scranmInicio : MonoBehaviour
{
    public GameObject cnvGrupo;
    public GameObject cnvGrupo1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void animacionStart(){        
        if(cnvGrupo!=null){
            Animator animator = cnvGrupo.GetComponent<Animator>();
            bool animacion= animator.GetBool("boolAnimacion");
            animator.SetBool("boolAnimacion",!animacion);
        }
        if(cnvGrupo1!=null){
            Animator animator = cnvGrupo1.GetComponent<Animator>();
            bool animacion= animator.GetBool("boolAnimacion");
            animator.SetBool("boolAnimacion",!animacion);
        }
    }
}
