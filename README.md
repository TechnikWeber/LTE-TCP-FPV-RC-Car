# LTE-TCP-FPV-RC-Car BRANCH for Version 1.1 with PCA Chip (No more jitter on the servos)
Full project for creating an unlimited range fpv car driven over the web<br/>
CREDITS: Source code for Camera-Server on Raspberry Pi from Yasin Arabi<br/><br/>
GPIO3 or SCL pin to the SCL pin of the module<br/>
GPIO2 or SDA pin to the SDA pin of the module<br/>
5V pin to Vdc pin of the module<br/>
GND pin to GND pin of the module<br/>

Welcome to this project, if you just want to drive a RC-Car via Wifi network (locally) you are ready to go with the Server.py on "Raspberry Pi Zero"
and Server.exe on Windows PC, just insert your local IP in the code. You also need to autostart the server.py and the stream.py!<br/><br/>
Connect to the camera with: http://192.168.1.161:8001/stream.mjpg e.g., connect to the server.py with the client.exe.<br/>
Autostart both with:

<br/>
<br/>
sudo nano /etc/rc.local<br/>

sudo python3 /home/pi/stream.py &<br/>
sudo python3 /home/pi/server.py &<br/>

sudo reboot<br/><br/>

also needed:<br/><br/>
sudo apt-get -y install python3-rpi.gpio<br/>
sudo apt-get install python3-numpy 
<br/><br/>

You will need an gamepad, in the future i am planning to also use the keyboard keys to drive it. (I have an cheap CSL gamepad)<br/><br/>
If you are planning to drive it via LTE/3G, you will need to set up an reverse SSH tunnel, description to do that is planned in the future here.

<br/><br/>
ATTENTION: This is a BETA version, no liability is assumed for any damage, <br/>you are responsible for using it in full!
