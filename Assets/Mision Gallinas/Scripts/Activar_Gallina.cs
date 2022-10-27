using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activar_Gallina : MonoBehaviour
{
    public GameObject cuboAntes;
    public GameObject camaraP;
    public GameObject camaraF;
    public GameObject MensajeS;
    public GameObject MensajeA;
    public GameObject puertaA;
    public GameObject misionI;
    public GameObject misionT;
    public GameObject mensajeF;
    public GameObject Indicador7;
    public int numeroG;

    public GameObject gallinas;
    public GameObject gallinas2;
    public GameObject gallinas3;
    public GameObject gallinas4;
    public GameObject gallinas5;
    public GameObject gallinas6;
    public GameObject gallina;
    public GameObject gallinaQuieta;
    public GameObject gallinaQuieta2;
    public GameObject gallinaQuieta3;
    public GameObject gallinaQuieta4;
    public GameObject gallinaQuieta5;
    public GameObject gallinaQuieta6;
    public GameObject Reco;
    public GameObject Reco2;
    public GameObject Reco3;
    public GameObject Reco4;
    public GameObject Reco5;
    public GameObject Reco6;
    public GameObject Corral;
    public GameObject Corral2;
    public GameObject Corral3;
    public GameObject Corral4;
    public GameObject Corral5;
    public GameObject Corral6;
    public GameObject Indicador;
    public GameObject Indicador2;
    public GameObject Indicador3;
    public GameObject Indicador4;
    public GameObject Indicador5;
    public GameObject Indicador6;
    public GameObject Salida;
    public GameObject salida2;

    public GameObject textoCompletado;
    public Text mInicio;
    public GameObject CuadroM;
    public Text dmInicio;
    public Text dmactual;
    public GameObject cuadroA;

    public GameObject audioMision;
    public GameObject audioD2;
    public GameObject audioGallinas;
    public GameObject audioCompletado;

    [SerializeField] private int conteoG;
    public GameObject contadorG;
    public GameObject imagenGallina;
    public Text contadorGallinas;




    public void activarGallinas()
    {

        gallinas.SetActive(true);
        gallinas2.SetActive(true);
        gallinas3.SetActive(true);
        gallinas4.SetActive(true);
        gallinas5.SetActive(true);
        gallinas6.SetActive(true);
        audioGallinas.SetActive(true);

    }

    public void recogerGallinas()
    {
        AgarrarGallinas();
        //AgarrarGallinas2();
        //AgarrarGallinas3();
        //AgarrarGallinas4();
        //AgarrarGallinas5();
        //AgarrarGallinas6();
        mensaje();
    }

    public void recogerGallinas2()
    {

        AgarrarGallinas2();
        mensaje();
    }

    public void recogerGallinas3()
    {

        AgarrarGallinas3();
        mensaje();
    }

    public void recogerGallinas4()
    {

        AgarrarGallinas4();
        mensaje();
    }

    public void recogerGallinas5()
    {

        AgarrarGallinas5();
        mensaje();
    }

    public void recogerGallinas6()
    {

        AgarrarGallinas6();
        mensaje();
    }

    void conteoGallinas1()
    {

        conteoG++;
        if (conteoG == 1)
        {
            //conteoG +=1;
            //Debug.Log("Te faltan = 5 gallinas");
            contadorGallinas.text = "1 / 6";
        }
        if (conteoG == 2)
        {
            //conteoG +=1;
            //Debug.Log("Te faltan = 4 gallinas");
            contadorGallinas.text = "2 / 6";
        }
        if (conteoG == 3)
        {
            //conteoG +=1;
            //Debug.Log("Te faltan = 3 gallinas");
            contadorGallinas.text = "3 / 6";
        }
        if (conteoG == 4)
        {
            //conteoG +=1;
            //Debug.Log("Te faltan = 2 gallinas");
            contadorGallinas.text = "4 / 6";
        }
        if (conteoG == 5)
        {
            //conteoG +=1;
            //Debug.Log("Te faltan = 1 gallina");
            contadorGallinas.text = "5 / 6";
        }
        if (conteoG == 6)
        {
            //conteoG +=1;
            //Debug.Log("Tienes todas las gallinas dirigete al gallinero");
            contadorGallinas.text = "6 / 6";
        }
    }



    void AgarrarGallinas()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gallinas);
            Destroy(Reco);
            //Debug.Log("Has agarrado una gallina ");
            dmactual.text = "ve al gallinero";
            gallinaReco();
            Particula1();
            EncenderGallinero();
            conteoGallinas1();
        }
    }

    void AgarrarGallinas2()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gallinas2);
            Destroy(Reco2);
            //Debug.Log("Has agarrado una gallina ");
            dmactual.text = "ve al gallinero";
            gallinaReco();
            Particula2();
            EncenderGallinero2();
            conteoGallinas1();
        }
    }

    void AgarrarGallinas3()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gallinas3);
            Destroy(Reco3);
            //Debug.Log("Has agarrado una gallina ");
            dmactual.text = "ve al gallinero";
            gallinaReco();
            Particula3();
            EncenderGallinero3();
            conteoGallinas1();
        }
    }

    void AgarrarGallinas4()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gallinas4);
            Destroy(Reco4);
            //Debug.Log("Has agarrado una gallina ");
            dmactual.text = "ve al gallinero";
            gallinaReco();
            Particula4();
            EncenderGallinero4();
            conteoGallinas1();
        }
    }

    void AgarrarGallinas5()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gallinas5);
            Destroy(Reco5);
            //Debug.Log("Has agarrado una gallina ");
            dmactual.text = "ve al gallinero";
            gallinaReco();
            Particula5();
            EncenderGallinero5();
            conteoGallinas1();
        }
    }

    void AgarrarGallinas6()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gallinas6);
            Destroy(Reco6);
            //Debug.Log("Has agarrado una gallina ");
            dmactual.text = "ve al gallinero";
            gallinaReco();
            Particula6();
            EncenderGallinero6();
            conteoGallinas1();
        }
    }

    void mensaje()
    {
        //Debug.Log("Agarra la gallina");
        dmactual.text = "Atrapa a la gallina con F";
    }

    void gallinaReco()
    {
        gallina.SetActive(true);
    }

    

    void EncenderGallinero()
    {
        Corral.SetActive(true);
    }

    void EncenderGallinero2()
    {
        Corral2.SetActive(true);
    }

    void EncenderGallinero3()
    {
        Corral3.SetActive(true);
    }

    void EncenderGallinero4()
    {
        Corral4.SetActive(true);
    }

    void EncenderGallinero5()
    {
        Corral5.SetActive(true);
    }

    void EncenderGallinero6()
    {
        Corral6.SetActive(true);
    }

    void numeroGallinas()
    {
        numeroG++;
        
        if (numeroG == 6)
        {
            misionT.SetActive(true);
            //Debug.Log("Sal del gallinero");
            MensajeS.SetActive(true);
            BorrarCuadroAM();

            audioD2.SetActive(true);

            Destroy(audioMision);
        }
    }

    public void MensajeSalida1()
    {
        dmactual.text = "Sal del gallinero";
    }

    public void borrarmensaje()
    {
        Destroy(MensajeS);
    }



    public void mensajeMg()
    {
        dmactual.text = "aún quedan gallinas";
    }


    void BorrarCuadroAM()
    {
        Destroy(MensajeA);
    }

    void cuadroAM()
    {
        MensajeA.SetActive(true);
    }

    public void cuadroMg()
    {
        MensajeA.SetActive(false);

    }



    void dejarGallinas()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(Corral);
            Destroy(Indicador);
            gallinaNoReco();
            gallinaDejada();
            cuadroAM();

            Debug.Log("");

        }
    }

    void dejarGallinas2()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(Corral2);
            Destroy(Indicador2);
            gallinaNoReco();
            gallinaDejada2();
            cuadroAM();

            Debug.Log("");
        }
    }

    void dejarGallinas3()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(Corral3);
            Destroy(Indicador3);
            gallinaNoReco();
            gallinaDejada3();
            cuadroAM();

            Debug.Log("");
        }
    }

    void dejarGallinas4()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(Corral4);
            Destroy(Indicador4);
            gallinaNoReco();
            gallinaDejada4();
            cuadroAM();

            Debug.Log("");
        }
    }

    void dejarGallinas5()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(Corral5);
            Destroy(Indicador5);
            gallinaNoReco();
            gallinaDejada5();
            cuadroAM();

            Debug.Log("");
        }
    }

    void dejarGallinas6()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(Corral6);
            Destroy(Indicador6);
            gallinaNoReco();
            gallinaDejada6();
            cuadroAM();

            Debug.Log("");
        }
    }

    void gallinaNoReco()
    {
        gallina.SetActive(false);
    }
    void mensajeGallina()
    {
        //Debug.Log("soltar gallina");
        dmactual.text = "Soltar gallina";
        
    }
    void gallinaDejada()
    {
        gallinaQuieta.SetActive(true);
        numeroGallinas();
    }

    void gallinaDejada2()
    {
        gallinaQuieta2.SetActive(true);
        numeroGallinas();
    }

    void gallinaDejada3()
    {
        gallinaQuieta3.SetActive(true);
        numeroGallinas();
    }

    void gallinaDejada4()
    {
        gallinaQuieta4.SetActive(true);
        numeroGallinas();
    }

    void gallinaDejada5()
    {
        gallinaQuieta5.SetActive(true);
        numeroGallinas();
    }

    void gallinaDejada6()
    {
        gallinaQuieta6.SetActive(true);
        numeroGallinas();
    }

    void Particula1()
    {
        Indicador.SetActive(true);

    }

    void Particula2()
    {
        Indicador2.SetActive(true);

    }

    void Particula3()
    {
        Indicador3.SetActive(true);

    }

    void Particula4()
    {
        Indicador4.SetActive(true);

    }

    void Particula5()
    {
        Indicador5.SetActive(true);

    }

    void Particula6()
    {
        Indicador6.SetActive(true);

    }


    public void GP()
    {
        

                dejarGallinas();



            mensajeGallina();

       


    }

    public void GP2()
    {
        



                dejarGallinas2();



            mensajeGallina();

        


    }

    public void GP3()
    {
        




                dejarGallinas3();



            mensajeGallina();

       


    }

    public void GP4()
    {
       

                dejarGallinas4();



            mensajeGallina();

        


    }

    public void GP5()
    {
        


                dejarGallinas5();



            mensajeGallina();

 


    }

    public void GP6()
    {
      




                dejarGallinas6();

            mensajeGallina();




    }

    void inicioMision()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            activarGallinas();
            mensajeInicioM();
            abrirPuerta();
            Destroy(misionI);
            CuadroM.SetActive(false);
            cuadroA.SetActive(true);

            camaraF.SetActive(false);
            camaraP.SetActive(true);

            cuboAntes.SetActive(true);

            audioD2.SetActive(false);

            audioMision.SetActive(true);

            contadorG.SetActive(true);
            imagenGallina.SetActive(true);

        }
    }

    void mensajeInicioM()
    {
        //Debug.Log("Atrapa todas las gallinas");
        dmactual.text = "Atrapa a todas las gallinas y llevalas al gallinero";
    }

    public void cuboAntesM()
    {
        Destroy(cuboAntes);
    }

    public void mensajeMision()
    {
        //Debug.Log("Iniciar misión");
        mInicio.text = "Presiona F para comenzar misión";
        dmInicio.text = "";
        CuadroM.SetActive(true);
        inicioMision();

    }



    void abrirPuerta()
    {
        var anim = puertaA.GetComponent<Animator>();
        anim.SetBool("PuertaA", true);
    }



    public void misionTerminadaG()
    {
        cerrarPuerta();
        Destroy(misionT);
        //Debug.Log("Mision completada, dirigete con el aldeano");
        dmactual.text = "Dirigete con el aldeano";
        mensajeF.SetActive(true);
        Indicador7.SetActive(true);
        Destroy(contadorG);
        Destroy(imagenGallina);
    }

    void cerrarPuerta()
    {
        var animc = puertaA.GetComponent<Animator>();
        animc.SetBool("PuertaC", true);
    }


    public void mensajeFinal()
    {
        mensajeMisionG();
        //Debug.Log("Preciona F para hablar");
        mInicio.text = "Presiona F para hablar";
        dmInicio.text = "";
        CuadroM.SetActive(true);
        cuadroA.SetActive(false);
    }

    void mensajeMisionG()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //Debug.Log("Muchas por tu ayuda");
            mInicio.text = "";
            dmInicio.text = "";
            Destroy(mensajeF);
            Destroy(Indicador7);
            Salida.SetActive(true);
            CuadroM.SetActive(false);
            salida2.SetActive(true);

            Destroy(audioGallinas);
            
            //mensajeF.SetActive(false);
        }
    }

    public void despuesDelFin()
    {
        salida2.SetActive(true);

    }

    public void mensajeFinal2()
    {
        mInicio.text = "Muchas gracias por tu ayuda";
        dmInicio.text = "";
        CuadroM.SetActive(true);

    }

    public void salidaMG()
    {
       
        Destroy(Salida);
        Destroy(salida2);
        
        CuadroM.SetActive(false);

        audioCompletado.SetActive(true);
        Destroy(audioD2);
        textoCompletado.SetActive(true);
    }

}
