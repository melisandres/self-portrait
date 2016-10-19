using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scratch_yourself : MonoBehaviour 
{
	public GameObject myItchPanel;
	public GameObject uiController;
	public Button scratch;

	public int recordedScratch;
	public int secretScratches;

	//seen_by_camera is sending us a value for isSeen
	public bool isSeen;

	public GameObject startPosition;



	public void ScratchYourself()
	{
		uiController.GetComponent<itch_panel>().itchy = false;
		//numOfScratches in itch_panel is figuring out the timing of scratches.
		uiController.GetComponent<itch_panel>().numOfScratches++;
		myItchPanel.SetActive (false);

		if (isSeen) 
		{
			uiController.GetComponent<notification_script> ().StartNotifying (1, recordedScratch);
			recordedScratch++;
		} 
		else 
		{
			uiController.GetComponent<notification_script> ().StartNotifying (0, secretScratches);
			secretScratches++;
		}

		gameObject.transform.position = startPosition.transform.position;
		scratch.GetComponent<scratch_script> ().BackToSize();
	}


}
