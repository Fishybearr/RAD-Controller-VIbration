
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SharpDX.XInput;

//Be sure to change the class name to the name of your script
public class AdvancedExample : MonoBehaviour
{
	//Declares a new controller
	//UserIndex.One is the first controller connected, This package supports up to UserIndex.Four
	Controller controller1 = new Controller(UserIndex.One);
	
	//Creates a new vibration
	Vibration v = new Vibration();



	void StartVibration()
	{
		// Sets the right motor speed of the controller
		v.RightMotorSpeed = (ushort)10000;

		//Sets the left motor speed of the controller
		v.LeftMotorSpeed = (ushort)10000;

		// Sends actual vibration command to the controller
		controller1.SetVibration(v);


	}


	void EndVibration()
	{
		// Sets motor speeds to 0
		v.RightMotorSpeed = (ushort)0;
		v.LeftMotorSpeed = (ushort)0;

		// Sends vibrate command to controller
		controller1.SetVibration(v);

	}






}
