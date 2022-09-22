using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_Gallina : MonoBehaviour
{
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



    public void activarGallinas()
    {

        gallinas.SetActive(true);
        gallinas2.SetActive(true);
        gallinas3.SetActive(true);
        gallinas4.SetActive(true);
        gallinas5.SetActive(true);
        gallinas6.SetActive(true);

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

    void AgarrarGallinas()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gallinas);
            Destroy(Reco);
            Debug.Log("Has agarrado una gallina ");
            gallinaReco();
            Particula1();
            EncenderGallinero();
        }
    }

    void AgarrarGallinas2()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gallinas2);
            Destroy(Reco2);
            Debug.Log("Has agarrado una gallina ");
            gallinaReco();
            Particula2();
            EncenderGallinero2();
        }
    }

    void AgarrarGallinas3()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gallinas3);
            Destroy(Reco3);
            Debug.Log("Has agarrado una gallina ");
            gallinaReco();
            Particula3();
            EncenderGallinero3();
        }
    }

    void AgarrarGallinas4()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gallinas4);
            Destroy(Reco4);
            Debug.Log("Has agarrado una gallina ");
            gallinaReco();
            Particula4();
            EncenderGallinero4();
        }
    }

    void AgarrarGallinas5()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gallinas5);
            Destroy(Reco5);
            Debug.Log("Has agarrado una gallina ");
            gallinaReco();
            Particula5();
            EncenderGallinero5();
        }
    }

    void AgarrarGallinas6()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gallinas6);
            Destroy(Reco6);
            Debug.Log("Has agarrado una gallina ");
            gallinaReco();
            Particula6();
            EncenderGallinero6();
        }
    }

    void mensaje()
    {
        Debug.Log("Agarra la gallina");
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


    void dejarGallinas()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(Corral);
            Destroy(Indicador);
            gallinaNoReco();
            gallinaDejada();
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
        }
    }

    void gallinaNoReco()
    {
        gallina.SetActive(false);
    }
    void mensajeGallina()
    {
        Debug.Log("soltar gallina");
    }
    void gallinaDejada()
    {
        gallinaQuieta.SetActive(true);
    }

    void gallinaDejada2()
    {
        gallinaQuieta2.SetActive(true);
    }

    void gallinaDejada3()
    {
        gallinaQuieta3.SetActive(true);
    }

    void gallinaDejada4()
    {
        gallinaQuieta4.SetActive(true);
    }

    void gallinaDejada5()
    {
        gallinaQuieta5.SetActive(true);
    }

    void gallinaDejada6()
    {
        gallinaQuieta6.SetActive(true);
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


    public void GP(Collider other)
    {
        if (other.transform.tag == "GallinaP")
        {


                dejarGallinas();



            mensajeGallina();

        }


    }

    public void GP2(Collider other)
    {
        if (other.transform.tag == "GallinaP")
        {



                dejarGallinas2();



            mensajeGallina();

        }


    }

    public void GP3(Collider other)
    {
        if (other.transform.tag == "GallinaP")
        {




                dejarGallinas3();



            mensajeGallina();

        }


    }

    public void GP4(Collider other)
    {
        if (other.transform.tag == "GallinaP")
        {


                dejarGallinas4();



            mensajeGallina();

        }


    }

    public void GP5(Collider other)
    {
        if (other.transform.tag == "GallinaP")
        {



                dejarGallinas5();



            mensajeGallina();

        }


    }

    public void GP6(Collider other)
    {
        if (other.transform.tag == "GallinaP")
        {




                dejarGallinas6();

            mensajeGallina();

        }


    }

}
