using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Encryption_Form
{
    class Encrypt
    {
        //AUTOPROPERTY
        static Random rnd = new Random();  //random number generator = rnd.Next

        //METHODS
        public void encodeFile(string x){

            //Accept filename, streamread text, use encrypt method on text.
            string string1 = File.ReadAllText(x);
            string1 = encodeText(string1);

            //Overwrite old file with encrypted message.
            File.WriteAllText(x, string1); 
        }//end encodeFile method
        
        
        public string encodeText(string x){
            int garbageAmt = rnd.Next(12, 20); //how much garbage pads beginning of message
            int shiftAmt   = rnd.Next(48, 65); //shifts characters in x up by this amount
            int noiseFreq  = rnd.Next(3,6);    //random character insert frequency

            //Calculate length of char arrays
            char[] string1 = new char[garbageAmt];
            char[] string2 = new char[x.Length + (x.Length / noiseFreq)];

            //Key
            string1[0] = Convert.ToChar(garbageAmt + 100); //make garbageAmt a readable char
            string1[1] = (char)shiftAmt; //amount to shift letters
            string1[2] = Convert.ToChar(noiseFreq + 100); //make noiseFreq a readable char

            //Generate Front Pad
            for (int i = 3; i < garbageAmt; i ++){
                string1[i] = (char)rnd.Next(32, 127);
            }//end for
            
            //Add noise and message to string1
            int index = 0; //message index
            for (int i = 0; i < string2.Length; i ++){
                
                if (i % noiseFreq == 0){
                    string2[i] = (char)rnd.Next(32, 127);
                }else{
                    int letter = Convert.ToInt32(x[index]) + shiftAmt;
                    
                    //wrap character between 32 and 12
                    if (letter > 126){
                        letter = letter - 95;
                    }//end if

                    string2[i] = Convert.ToChar(letter); //add encrypted message to string1
                    index ++; //increment message index
                }//end if
            }//end for

            //Build message
            string message = "";
            foreach (char letter in string1){
                message += letter;
            }//end foreach
            foreach (char letter in string2){
                message += letter;
            }//end foreach
            
            return message;
        }//end encodeText method


    }//class
}//name