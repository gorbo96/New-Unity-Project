using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class scrSeleccion : MonoBehaviour
{
    public Button boton1;
    public Button boton2;
    public Button boton3;
    public Button boton4;
    public Button boton5;
    public Button boton6;    
    public Button boton7;    
    public Dropdown lista;
    public byte indice=0;
    public bool repeticion=true;
    public Toggle optVaron;
    public Toggle optMujer;
    public Toggle opt1per;
    public Toggle opt3per;
    public Toggle optTecla;
    public Toggle optVoz;
    public Toggle optRaton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab)){
            
            if(repeticion && indice==5){
                indice=1;
            }
            if(repeticion && indice==8){
                indice=5;
            }
            if(repeticion && indice==11){
                indice=8;
            }
            if(repeticion && indice==15){
                indice=11;
            }
            
            switch(indice){
                case 0:
                    boton1.Select();                    
                    break;
                case 1:
                    repeticion=true;
                    lista.Select();                    
                    break;
                case 2:
                    boton2.Select();                    
                    break;
                case 3:
                    boton3.Select();                    
                    break;
                case 4:
                    boton4.Select();                    
                    break;
                case 5:
                    repeticion=true;
                    optVaron.Select();
                    break;
                case 6:
                    optMujer.Select();
                    break;
                case 7:
                    boton5.Select();
                    break;
                case 8:
                    repeticion=true;
                    opt1per.Select();
                    break;
                case 9:
                    opt3per.Select();
                    break;
                case 10:
                    boton6.Select();
                    break;
                case 11:
                    repeticion=true;
                    optTecla.Select();
                    break;
                case 12:
                    optVoz.Select();
                    break;
                case 13:
                    optRaton.Select();
                    break;
                case 14:
                    boton7.Select();
                    break;
            }
            indice++;
        }
        if(Input.GetKeyDown(KeyCode.Return)){
            if((indice==3 || indice==4 || indice==5) && repeticion){
                repeticion=false;
                indice=5;
            }
            if(indice==8 && repeticion){                
                repeticion=false;                
            }
            if(indice==11 && repeticion){
                repeticion=false;                
            }
            
        }
        
    }    
}
