using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SharpDX.XInput;

public class ControllerVibration
{

  
 public  void Vibrate(int controllerNumber,int leftMotorStrength, int RightMotorStrength)
    {
        if(leftMotorStrength < 1000 || RightMotorStrength < 1000)
        {
            Debug.LogWarning("Motor strength should not be below 1000. Typcial range is from 1000 - 50000");
        }



        Controller cont;

        if(controllerNumber == 1)
        {
             cont = new Controller(UserIndex.One);
        }

        else if (controllerNumber == 2)
        {
             cont = new Controller(UserIndex.Two);
        }

        else if(controllerNumber == 3)
        {
             cont = new Controller(UserIndex.Three);
        }

        else if(controllerNumber == 4)
        {
             cont = new Controller(UserIndex.Four);
        }
        else
        {
            cont = new Controller(UserIndex.One);
            Debug.LogWarning("controllerNumber must be an int between 1 and 4! controllerNumber was defaulted to 1");
        }
        Vibration v = new Vibration();

        v.LeftMotorSpeed = (ushort) leftMotorStrength;
        v.RightMotorSpeed = (ushort)RightMotorStrength;

        cont.SetVibration(v);
    }


   public IEnumerator VibrateForSeconds(float seconds,int controllerNumber, int leftMotorStrength, int RightMotorStrength)
    {

        if (leftMotorStrength < 1000 || RightMotorStrength < 1000)
        {
            Debug.LogWarning("Motor strength should not be below 1000. Typcial range is from 1000 - 50000");
        }

        Controller cont;

        if (controllerNumber == 1)
        {
            cont = new Controller(UserIndex.One);
        }

        else if (controllerNumber == 2)
        {
            cont = new Controller(UserIndex.Two);
        }

        else if (controllerNumber == 3)
        {
            cont = new Controller(UserIndex.Three);
        }

        else if (controllerNumber == 4)
        {
            cont = new Controller(UserIndex.Four);
        }
        else
        {
            cont = new Controller(UserIndex.One);
            Debug.LogWarning("controllerNumber must be an int between 1 and 4! controllerNumber was defaulted to 1");
        }
        Vibration v = new Vibration();

        v.LeftMotorSpeed = (ushort)leftMotorStrength;
        v.RightMotorSpeed = (ushort)RightMotorStrength;

        cont.SetVibration(v);

        yield return new WaitForSeconds(seconds);

        v.LeftMotorSpeed = 0;
        v.RightMotorSpeed = 0;
        cont.SetVibration(v);
        
    } 



}
