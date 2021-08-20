using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;
using System.IO;



public class adxl345 : MonoBehaviour
{
    //seri haberleşme kodları acıklama satırı haline getirdim.
   
    
   
    SerialPort serial = new SerialPort("COM7", 9600);
    private int pitch;
    private int roll;
    
    // Use this for initialization
    void Start()
    {
    serial.Open();
    serial.ReadTimeout = 100;

    }

    // Update is called once per frame
    void Update()
    {
        //sd card reading
      // StreamReader reader = new StreamReader(@"C:\sdcard\YENI123.txt");
       // roll = int.Parse(reader.ReadLine());
      //  pitch = int.Parse(reader.ReadLine());
      //  MoveObject(pitch, 0, roll);
        if (serial.IsOpen)
            {
                try
                {

                    roll = int.Parse(serial.ReadLine());
                    pitch = int.Parse(serial.ReadLine());
                    MoveObject(pitch, 0,roll);


                }
                catch (System.Exception)
                {

                }

            }
         

    }
    void MoveObject(int xg,int yg,int zg)
    {
        transform.localEulerAngles = new Vector3(xg, yg, zg);
    }
    
      
       

 
    
}
