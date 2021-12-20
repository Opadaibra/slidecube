using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBar : MonoBehaviour
{
	public GameObject Player;
	public Slider slider;
	public Gradient gradient;
	public Image fill;
	private void Start()
	{
		Player = GameObject.FindWithTag("Player"); 
	}
	public void SetMaxHealth(float EndLevel) 
	{
		slider.maxValue = EndLevel;
		slider.value = 0;
		fill.color = gradient.Evaluate(1f);
	}

   void Update()
	{
		slider.value = Player.transform.position.z;
		fill.color = gradient.Evaluate(slider.normalizedValue);
    }

}
