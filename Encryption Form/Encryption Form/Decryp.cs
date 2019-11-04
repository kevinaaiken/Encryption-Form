using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Encryption_Form
{
    class Decryp
    {
        //METHODS
        public void decodeFile(string x){
            //Accept filename, streamread text, use decrypt method on text.
            string string1 = File.ReadAllText(x);
            string1 = decodeText(string1);
            File.WriteAllText(x, string1); //overwrite old file with decrypted message
        }

        public string decodeText(string x){
            string string1 = ""; //holds encoded message
            string string2 = ""; //holds decoded message

            int garbageAmt = Convert.ToInt16(x[0]) - 100; //skip header (encrypt adds 100)
            int shiftAmt = Convert.ToInt16(x[1]); //amount to shift letters down
            int noiseFreq = Convert.ToInt16(x[2]) - 100; //random character frequency (encrypt adds 100)
            
            //Start at end of garbage header and grab message
            for(int i = garbageAmt; i < x.Length; i ++){
                string1 += x[i];
            }//end for

            //Decrypt message
            for(int i = 0; i < string1.Length; i ++){
                if (i % noiseFreq == 0){
                    //do nothing
                }else{
                    //shift char back to original value
                    int temp = Convert.ToInt16(string1[i]) - shiftAmt;

                    //keep char between 32 and 126
                    if (temp < 32){
                        temp = temp + 95;
                    }//end if

                    //concat encrypted character onto string after decrypting
                    string2 += (char)temp;
                }//end if
            }//end for

            return string2;
        }


    }//class
}//name
