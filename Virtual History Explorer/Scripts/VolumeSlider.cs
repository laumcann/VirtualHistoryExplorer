using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeSlider : MonoBehaviour
{

    public AudioSource BackgroundMusic;

    public Slider mainSlider;

    public TextMeshProUGUI mainSliderText;
	
	public void Start()
	{

        mainSliderText.text = mainSlider.value.ToString();


		//Adds a listener to the main slider and invokes a method when the value changes.
		mainSlider.onValueChanged.AddListener (delegate {ValueChangeCheck ();});
	}
	
	// Invoked when the value of the slider changes.
	public void ValueChangeCheck()
	{
		Debug.Log (mainSlider.value);
	}
}
