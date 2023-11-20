using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SoundTextureChanger : MonoBehaviour 
{
	public Texture _soundOFF,_soundON;
	public Image _target;

	void Start()
	{

		AudioListener.volume = System.Convert.ToInt32(!StaticVariables.soundOff);

		ChangeTexture ();
//		this.audio.clip = Resources.Load("ClickSound")as AudioClip;
	}
	
	public	void ChangeTexture()
	{
	//	if (StaticVariables.soundOff == false)
			//_target.texture = _soundOFF;
	//	else
		//	_target.texture = _soundON;
		AudioListener.volume = System.Convert.ToInt32(!StaticVariables.soundOff);
	}
	public void ChangeTiltTexture()
	{
		if(StaticVariables.tilting)
		{
			StaticVariables.tilting = false;
			Debug.Log("Tilt"+StaticVariables.tilting);
			//_target.texture = _soundON;
		}
		else
		{
			StaticVariables.tilting = true;

			//_target.texture = _soundOFF;
		}
	}
}
