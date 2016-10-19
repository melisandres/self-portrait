using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class notification_script : MonoBehaviour 
{
	public GameObject myNotificationPanel;
	public float timer;
	public float timerLength;
	public bool notifying;


	//and now some notifications for the panel 
	public Text notificationTextBox;

	[HideInInspector] public static string yay0 = "Phew! I'm pretty sure no one saw that.";
	[HideInInspector] public static string yay1 = "Good job! there are some things no one should have to watch.";
	[HideInInspector] public static string yay2 = "You're getting the hang of this! Remember, use your stealth for good.";
	[HideInInspector] public static string yay3 = "Well done! I hope you're not so focussed on this that you're not doing you job...";
	[HideInInspector] public static string yay4 = "I know. Its the uniforms. You'll get used to it.";
	[HideInInspector] public static string yay5 = "Almost done with the this floor, only 13 more to go!";

	[HideInInspector] public static string nay0 = "Just so you know, you were just recorded scratching your bum. Nice job.";
	[HideInInspector] public static string nay1 = "You know that everyone is watching the cameras, right?";
	[HideInInspector] public static string nay2 = "I saw that. Everyone saw that.";
	[HideInInspector] public static string nay3 = "The boss just walked in. They saw you do that.";
	[HideInInspector] public static string nay4 = "If you don't watch your image, someone else will--you know what I mean?";


	public static string [] yayNotifications;
	public static string [] nayNotifications;
	public static string[][] notifications;

	void Awake()
	{
		yayNotifications = new string[] { yay0, yay1, yay2, yay3, yay4, yay5 };
		nayNotifications = new string[] { nay0, nay1, nay2, nay3, nay4 };
		notifications = new string[][] { yayNotifications, nayNotifications };
	}


	void Start()
	{
		myNotificationPanel.SetActive (false);
	}

	void Update()
	{
		if (notifying)
		{
			myNotificationPanel.SetActive (true);
			timer += Time.deltaTime;
				if (timer >= timerLength)
				{
					notifying = false;
					myNotificationPanel.SetActive (false);
					timer = 0;
				}
		}
	}

	public void StartNotifying (int yayOrNay, int scratches)
	{
		notificationTextBox.GetComponent<Text>().text = notifications[yayOrNay][scratches];
		notifying = true;
	}

}
