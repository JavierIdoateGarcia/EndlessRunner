using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsHandler : MonoBehaviour
{
    public InputField inputNombre;
    public Slider sliderVolumen;
    public Toggle muteToggle;
    public Dropdown graficosDropdown;


    // Start is called before the first frame update

    public void Play()

    {

        SceneManager.LoadScene("EndlessRunner");
    }

    public void Options()

    {

        SceneManager.LoadScene("Options");
    }

   
    void start ()
    {
        CargarDatos();
    }

    public void CambiarNombreDeUsuarioPlayerspPrefs()
    {
        PlayerPrefs.SetString("NombreDeUsuario", inputNombre.text);
    }

   

    public void CambiarVolumenPlayerPrefs()
    {
        PlayerPrefs.SetFloat("Volumen", sliderVolumen.value);
    }

    public void CambiarToggleState()
    {
        if (muteToggle.isOn)
        {
            PlayerPrefs.SetInt("ToggleState", 1);
        }
        else
        {
            PlayerPrefs.SetInt("ToggleState", 0);
        }
    }

    public void CambiarGraficosPlayerPrefs()
    {
        PlayerPrefs.SetInt("Graficos", graficosDropdown.value);
    }

    public void CargarDatos()
    {
        inputNombre.text = PlayerPrefs.GetString("NombreDeUsuario");

        if (PlayerPrefs.HasKey("Volumen"))

        {
            sliderVolumen.value = PlayerPrefs.GetFloat("Volumen");
        }
        else
        {
            sliderVolumen.value = 1f;
        }

        graficosDropdown.value = PlayerPrefs.GetInt("Graficos");

        if (PlayerPrefs.HasKey("ToggleState"))
        {
            var state = PlayerPrefs.GetInt("ToggleState");

            if (state == 1)
            {
                muteToggle.isOn = true;
            }
            else
            {
                muteToggle.isOn = false;
            }
        }
    }
    public void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        CargarDatos();
    }

   
}