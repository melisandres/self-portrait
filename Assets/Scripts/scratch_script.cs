using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class scratch_script : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	public Image recordLight;
	public Vector2 recordLightSize;

	public Color flashing;

	void Start()
	{
		recordLightSize = recordLight.rectTransform.sizeDelta;
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		recordLight.rectTransform.sizeDelta = recordLight.rectTransform.sizeDelta * 1.5f;
	}


	public void OnPointerExit(PointerEventData eventData)
	{
		BackToSize ();
	}



	public void BackToSize()
	{
		recordLight.rectTransform.sizeDelta = recordLightSize;
	}

	public void Update()
	{

		recordLight.GetComponent<Image> ().color = flashing;
		flashing = Color.Lerp (Color.white, Color.black, Mathf.PingPong (Time.time, 0.6f));
	}
}
